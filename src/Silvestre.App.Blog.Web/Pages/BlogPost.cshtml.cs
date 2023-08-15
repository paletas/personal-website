using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Silvestre.App.Blog.Web.Blog;

namespace Silvestre.App.Blog.Web.Pages
{
    public class BlogPostModel : PageModel
    {
        private readonly IBlogRepository _blogRepository;

        public BlogPostModel(IBlogRepository blogRepository)
        {
            this._blogRepository = blogRepository;
        }   

        [FromRoute(Name = "postUri")]
        public string PostUri { get; set; } = null!;

        public BlogPost Post { get; set; } = null!;

        public IEnumerable<BlogCategory> Categories { get; set; } = Array.Empty<BlogCategory>();

        public async Task<IActionResult> OnGet()
        {
            BlogPost? blogPost = await this._blogRepository.GetBlogPost(this.PostUri, base.HttpContext.RequestAborted);
            if (blogPost is null)
                return NotFound();

            this.Post = blogPost;
            this.Categories = await this._blogRepository.GetCategories(base.HttpContext.RequestAborted);
            return Page();
        }
    }
}
