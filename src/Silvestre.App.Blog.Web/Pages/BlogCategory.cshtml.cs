using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Silvestre.App.Blog.Web.Blog;

namespace Silvestre.App.Blog.Web.Pages
{
    public class BlogCategoryModel : PageModel
    {
        private readonly IBlogRepository _blogRepository;

        public BlogCategoryModel(IBlogRepository blogRepository)
        {
            this._blogRepository = blogRepository;
        }

        public BlogCategory Category { get; internal set; }

        public string BaseUri { get; set; }

        public IEnumerable<BlogPost> LatestPosts { get; internal set; }

        public IEnumerable<BlogCategory> OtherCategories { get; internal set; } = Array.Empty<BlogCategory>();

        public async Task OnGet([FromRoute(Name = "uri")]string categoryUri)
        {
            this.LatestPosts = await this._blogRepository.GetLatestBlogPostsForCategory(categoryUri, 10, base.HttpContext.RequestAborted);
            this.OtherCategories = await this._blogRepository.GetCategories(base.HttpContext.RequestAborted);

            this.BaseUri = $"{base.HttpContext.Request.Scheme}://{base.HttpContext.Request.Host.ToUriComponent()}";
            this.Category = this.OtherCategories.Single(c => c.Uri == categoryUri);
            this.OtherCategories = this.OtherCategories.Where(c => c.Uri != categoryUri);
        }
    }
}
