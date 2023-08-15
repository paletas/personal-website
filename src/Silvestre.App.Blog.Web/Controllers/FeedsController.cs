using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.Options;
using Microsoft.SyndicationFeed;
using Microsoft.SyndicationFeed.Atom;
using Microsoft.SyndicationFeed.Rss;
using Silvestre.App.Blog.Web.Blog;
using Silvestre.App.Blog.Web.Options;
using System.Net.Mime;
using System.Text;
using System.Threading;
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
        public async Task<IActionResult> GetRssFeed()
        {
            IEnumerable<BlogPost> blogPosts = await this._blogRepository.GetBlogPosts(this.HttpContext.RequestAborted);
            FeedOptions feedOptions = this._feedOptions.Value;

            StringWriter stringWriter = new();
            using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Async = true, Indent = true, Encoding = Encoding.UTF8 }))
            {
                RssFeedWriter feedWriter = new(xmlWriter);
                await feedWriter.WriteTitle(feedOptions.BlogTitle);
                await feedWriter.WriteDescription(feedOptions.BlogDescription);
                await feedWriter.WriteGenerator(GeneratorName);
                await feedWriter.WritePubDate(DateTimeOffset.Now);
                await feedWriter.WriteLastBuildDate(new DateTimeOffset(blogPosts.Max(p => p.CreatedAt).ToDateTime(TimeOnly.MinValue), TimeSpan.Zero));
                await feedWriter.WriteValue("link", feedOptions.BlogUrl);

                await GeneratePostEntries(feedOptions, blogPosts, feedWriter);
            }

            return Content(stringWriter.ToString(), MediaTypeNames.Application.Xml);
        }

        [HttpGet("atom")]
        public async Task<IActionResult> GetAtomFeed()
        {
            IEnumerable<BlogPost> blogPosts = await this._blogRepository.GetBlogPosts(this.HttpContext.RequestAborted);
            FeedOptions feedOptions = this._feedOptions.Value;

            StringWriter stringWriter = new();
            using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Async = true, Indent = true, Encoding = Encoding.UTF8 }))
            {
                AtomFeedWriter feedWriter = new(xmlWriter);
                await feedWriter.WriteId(feedOptions.BlogUrl);
                await feedWriter.WriteTitle(feedOptions.BlogTitle);
                await feedWriter.WriteSubtitle(feedOptions.BlogDescription);
                await feedWriter.WriteGenerator(GeneratorName, feedOptions.BlogUrl, GeneratorVersion);
                await feedWriter.WriteUpdated(new DateTimeOffset(blogPosts.Max(p => p.LastUpdate).ToDateTime(TimeOnly.MinValue), TimeSpan.Zero));

                await GeneratePostEntries(feedOptions, blogPosts, feedWriter);
            }

            return Content(stringWriter.ToString(), MediaTypeNames.Application.Xml);
        }

        private async Task GeneratePostEntries(FeedOptions feedOptions, IEnumerable<BlogPost> blogPosts, XmlFeedWriter feedWriter)
        {
            foreach (BlogPost post in blogPosts)
            {
                AtomEntry postEntry = new()
                {
                    Id = new Uri(new Uri("https://itssilvestre.com/blog"), post.Uri).ToString(),
                    Title = post.Title,
                    Summary = post.Summary,
                    Published = new DateTimeOffset(post.CreatedAt.ToDateTime(TimeOnly.MinValue), TimeSpan.Zero),
                    LastUpdated = new DateTimeOffset(post.LastUpdate.ToDateTime(TimeOnly.MinValue), TimeSpan.Zero),
                    ContentType = "html",
                };

                postEntry.AddCategory(new SyndicationCategory(post.Category.Title));
                postEntry.AddContributor(new SyndicationPerson(feedOptions.AuthorName, feedOptions.AuthorEmail));
                postEntry.AddLink(new SyndicationLink(new Uri($"https://itssilvestre.com/blog/{post.Uri}")));

                await feedWriter.Write(postEntry);
            }
        }
    }
}
