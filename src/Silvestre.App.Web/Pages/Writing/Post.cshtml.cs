using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Silvestre.App.Web.Models;

namespace Silvestre.App.Web.Pages.Writing
{
    public class PostModel : PageModel
    {
        private readonly WritingArchive _archive;

        public PostModel(WritingArchive archive)
        {
            _archive = archive;
        }

        public Post Post { get; private set; } = null!;

        public IActionResult OnGet(string slug)
        {
            var post = _archive.Get(slug);
            if (post is null) return NotFound();
            Post = post;
            return Page();
        }
    }
}
