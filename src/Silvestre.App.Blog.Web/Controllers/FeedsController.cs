using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.SyndicationFeed;
using Microsoft.SyndicationFeed.Atom;
using Microsoft.SyndicationFeed.Rss;
using Silvestre.App.Blog.Web.Blog;
using System.Net.Mime;
using System.Text;
using System.Xml;

namespace Silvestre.App.Blog.Web.Controllers
{
    [ApiController]
    [Route("~/feed")]
    public class FeedsController : ControllerBase
    {
        private readonly IBlogRepository _blogRepository;

        public FeedsController(IBlogRepository blogRepository)
        {
            this._blogRepository = blogRepository;
        }

        [HttpGet("rss")]
        public async Task<IActionResult> GetRssFeed()
        {
            IEnumerable<BlogPost> blogPosts = await this._blogRepository.GetBlogPosts(this.HttpContext.RequestAborted);

            StringWriter stringWriter = new();
            using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Async = true, Indent = true, Encoding = Encoding.UTF8 }))
            {
                RssFeedWriter feedWriter = new(xmlWriter);
                await feedWriter.WriteTitle("João Silvestre the Blog");
                await feedWriter.WriteDescription("João Silvestre's bad takes");
                await feedWriter.WriteGenerator("Silvestre.App.Blog.Web");
                await feedWriter.WritePubDate(DateTimeOffset.Now);
                await feedWriter.WriteLastBuildDate(DateTimeOffset.Now);
                await feedWriter.WriteValue("link", "https://itssilvestre.com/blog");

                foreach (BlogPost post in blogPosts)
                {
                    AtomEntry postEntry = new()
                    {
                        Id = post.Uri,
                        Title = post.Title,
                        Description = post.Description,
                        Published = new DateTimeOffset(post.CreatedAt.ToDateTime(TimeOnly.MinValue), TimeSpan.Zero),
                        LastUpdated = new DateTimeOffset(post.LastUpdate.ToDateTime(TimeOnly.MinValue), TimeSpan.Zero),
                        ContentType = "html",
                    };

                    postEntry.AddCategory(new SyndicationCategory(post.Category.Title));
                    postEntry.AddContributor(new SyndicationPerson("João Silvestre", "email"));
                    postEntry.AddLink(new SyndicationLink(new Uri($"https://itssilvestre.com/blog/{post.Uri}")));

                    await feedWriter.Write(postEntry);
                }
            }

            return Content(stringWriter.ToString(), MediaTypeNames.Application.Xml);
        }
    }
}
