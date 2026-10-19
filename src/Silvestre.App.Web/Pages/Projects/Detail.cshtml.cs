using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Silvestre.App.Web.Models;
using System.Globalization;

namespace Silvestre.App.Web.Pages.Projects
{
    public class DetailModel : PageModel
    {
        private readonly ProjectArchive _archive;

        public DetailModel(ProjectArchive archive)
        {
            _archive = archive;
        }

        public ProjectEntry Entry { get; private set; } = null!;

        public ProjectFacts? Facts { get; private set; }

        public IActionResult OnGet(string slug)
        {
            var isPt = SiteContentProvider.IsPt(CultureInfo.CurrentUICulture);
            var entry = _archive.Get(slug, isPt);
            if (entry is null) return NotFound();
            Entry = entry;
            Facts = _archive.Facts(slug);
            return Page();
        }
    }
}
