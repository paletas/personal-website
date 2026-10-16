using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Silvestre.App.Web.Pages
{
    [IgnoreAntiforgeryToken]
    public class ErrorModel : PageModel
    {
        public int? Code { get; private set; }

        public void OnGet(int? code)
        {
            Code = code;
        }
    }
}
