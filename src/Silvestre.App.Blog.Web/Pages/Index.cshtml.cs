using Microsoft.AspNetCore.Mvc.RazorPages;
using Silvestre.App.Blog.Web.Blog;

namespace Silvestre.App.Blog.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IBlogRepository _blogRepository;

        public IndexModel(IBlogRepository blogRepository)
        {
            this._blogRepository = blogRepository;
        }

        public string BaseUri { get; set; }

        public IEnumerable<BlogPost> LatestPosts { get; internal set; }

        public IEnumerable<BlogCategory> Categories { get; set; } = Array.Empty<BlogCategory>();

        public async Task OnGet()
        {
            this.BaseUri = $"{base.HttpContext.Request.Scheme}://{base.HttpContext.Request.Host.ToUriComponent()}";
            this.LatestPosts = await this._blogRepository.GetLatestBlogPosts(10, base.HttpContext.RequestAborted);
            this.Categories = await this._blogRepository.GetCategories(base.HttpContext.RequestAborted);
        }
    }
}