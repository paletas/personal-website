using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Silvestre.App.Blog.Web.Blog;
using Silvestre.App.Blog.Web.Core.Parsers;
using Silvestre.App.Blog.Web.Options;
using System.Net.Mime;
using System.ServiceModel.Syndication;
using System.Text;
using System.Xml;

namespace Silvestre.App.Blog.Web.Controllers
{
    [ApiController]
    [Route("~/feed")]
    public class FeedsController : ControllerBase
    {
        private const string GeneratorName = "Silvestre.App.Blog.Web";
        private const string GeneratorVersion = "1.0.0";

        private readonly IBlogRepository _blogRepository;
        private readonly IOptionsSnapshot<FeedOptions> _feedOptions;

        public FeedsController(IBlogRepository blogRepository, IOptionsSnapshot<FeedOptions> feedOptions)
        {
            this._blogRepository = blogRepository;
            this._feedOptions = feedOptions;
        }

        [HttpGet("rss")]
        public async Task<IActionResult> GetRssFeed([FromQuery] string? category, [FromQuery] string? tag)
        {
            IEnumerable<BlogPost> blogPosts = await this._blogRepository.GetBlogPosts(category, tag, this.HttpContext.RequestAborted);
            FeedOptions feedOptions = this._feedOptions.Value;

            StringWriter stringWriter = new();
            using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Async = true, Indent = true, Encoding = Encoding.UTF8 }))
            {
                SyndicationFeed syndicationFeed = GenerateFeed(blogPosts, feedOptions);

                syndicationFeed.SaveAsRss20(xmlWriter);
            }

            return Content(stringWriter.ToString(), MediaTypeNames.Application.Xml);
        }

        [HttpGet("atom")]
        public async Task<IActionResult> GetAtomFeed([FromQuery] string? category, [FromQuery] string? tag)
        {
            IEnumerable<BlogPost> blogPosts = await this._blogRepository.GetBlogPosts(category, tag, this.HttpContext.RequestAborted);
            FeedOptions feedOptions = this._feedOptions.Value;

            StringWriter stringWriter = new();
            using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Async = true, Indent = true, Encoding = Encoding.UTF8 }))
            {
                SyndicationFeed syndicationFeed = GenerateFeed(blogPosts, feedOptions);

                syndicationFeed.SaveAsAtom10(xmlWriter);
            }

            return Content(stringWriter.ToString(), MediaTypeNames.Application.Xml);
        }

        private static SyndicationFeed GenerateFeed(IEnumerable<BlogPost> blogPosts, FeedOptions feedOptions)
        {
            SyndicationFeed syndicationFeed = new(
                feedOptions.BlogTitle,
                feedOptions.BlogDescription,
                new Uri(feedOptions.BlogUrl),
                $"{feedOptions.BlogUrl}/feeds/rss",
                blogPosts.Any() ? new DateTimeOffset(blogPosts.Max(p => p.CreatedAt), TimeSpan.Zero) : DateTimeOffset.UtcNow);

            syndicationFeed.Generator = GeneratorName;
            syndicationFeed.Links.Add(new SyndicationLink(new Uri(feedOptions.BlogUrl)));
            syndicationFeed.Items = GeneratePostEntries(feedOptions, blogPosts);
            return syndicationFeed;
        }

        private static IEnumerable<SyndicationItem> GeneratePostEntries(FeedOptions feedOptions, IEnumerable<BlogPost> blogPosts)
        {
            foreach (BlogPost post in blogPosts)
            {
                Uri postAbsoluteUri = new(new Uri(feedOptions.BlogUrl, UriKind.Absolute), post.Uri);
                SyndicationItem postEntry = new(
                    post.Title,
                    SyndicationContent.CreateHtmlContent(post.HtmlContent.Replace(Markdown.BaseUrlPlaceholder, feedOptions.BlogUrl)),
                    null,
                    post.Uri,
                    new DateTimeOffset(post.LastUpdate ?? post.CreatedAt, TimeSpan.Zero))
                {
                    Summary = TextSyndicationContent.CreatePlaintextContent(post.Summary),
                    PublishDate = new DateTimeOffset(post.CreatedAt, TimeSpan.Zero)
                };

                postEntry.Authors.Add(new SyndicationPerson(feedOptions.AuthorEmail, feedOptions.AuthorName, null));
                postEntry.Categories.Add(new SyndicationCategory(post.Category.Title));
                postEntry.AddPermalink(postAbsoluteUri);

                yield return postEntry;
            }
        }
    }
}
