using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Silvestre.App.Blog.Web.Blog;

namespace Silvestre.App.Blog.Web.Pages
{
    public class TagModel : PageModel
    {
        private readonly IBlogRepository _blogRepository;

        public TagModel(IBlogRepository blogRepository)
        {
            this._blogRepository = blogRepository;
        }

        public string Tag { get; internal set; }

        public string BaseUri { get; set; }

        public IEnumerable<BlogPost> LatestPosts { get; internal set; }

        public IEnumerable<BlogCategory> Categories { get; internal set; } = Array.Empty<BlogCategory>();

        public async Task OnGet([FromRoute(Name = "uri")] string tag)
        {
            this.BaseUri = $"{base.HttpContext.Request.Scheme}://{base.HttpContext.Request.Host.ToUriComponent()}";
            this.Tag = tag;
            this.LatestPosts = await this._blogRepository.GetLatestBlogPostsForTag(tag, 10, base.HttpContext.RequestAborted);
            this.Categories = await this._blogRepository.GetCategoriesUsingTag(tag, base.HttpContext.RequestAborted);
        }
    }
}
