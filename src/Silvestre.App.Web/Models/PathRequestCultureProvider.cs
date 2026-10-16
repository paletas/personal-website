using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using System;
using System.Threading.Tasks;

namespace Silvestre.App.Web.Models
{
    // Culture comes from the URL only: /pt and /pt/... are Portuguese, everything else English.
    public class PathRequestCultureProvider : RequestCultureProvider
    {
        public override Task<ProviderCultureResult?> DetermineProviderCultureResult(HttpContext httpContext)
        {
            var path = httpContext.Request.Path;
            var isPt = path.Equals("/pt", StringComparison.OrdinalIgnoreCase)
                || path.StartsWithSegments("/pt", StringComparison.OrdinalIgnoreCase);
            return Task.FromResult<ProviderCultureResult?>(new ProviderCultureResult(isPt ? "pt-PT" : "en"));
        }
    }
}
