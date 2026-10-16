using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Silvestre.App.Web.Pages
{
    public class AiModel : PageModel
    {
        public void OnGet()
        {
            ViewData["Title"] = "How I build with AI";
        }
    }
}
