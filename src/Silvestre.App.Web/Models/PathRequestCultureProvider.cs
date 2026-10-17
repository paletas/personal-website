using Microsoft.AspNetCore.Diagnostics;
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
            // Error pages re-execute at /Error/..., so use the originally requested path.
            var original = httpContext.Features.Get<IStatusCodeReExecuteFeature>()?.OriginalPath
                ?? httpContext.Features.Get<IExceptionHandlerPathFeature>()?.Path;
            if (!string.IsNullOrEmpty(original)) path = new PathString(original);
            var isPt = path.Equals("/pt", StringComparison.OrdinalIgnoreCase)
                || path.StartsWithSegments("/pt", StringComparison.OrdinalIgnoreCase);
            return Task.FromResult<ProviderCultureResult?>(new ProviderCultureResult(isPt ? "pt-PT" : "en"));
        }
    }
}
