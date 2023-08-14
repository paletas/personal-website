using Microsoft.AspNetCore.Mvc;
using Silvestre.App.Blog.Web.Blog;

namespace Silvestre.App.Blog.Web.ViewComponents
{
    public class BlogPostReader : ViewComponent
    {
        public IViewComponentResult Invoke(BlogPost post, bool showSummary = false)
        {
            if (showSummary)
            {
                return View("Summary", post);
            }

            return View(post);
        }
    }
}
