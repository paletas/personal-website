using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text.Json;

namespace Silvestre.App.Web.Models
{
    public class SiteContentProvider
    {
        private readonly Dictionary<string, SiteContent> _content = new();

        public SiteContentProvider(IWebHostEnvironment env)
        {
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            foreach (var lang in new[] { "en", "pt" })
            {
                var path = Path.Combine(env.ContentRootPath, "Content", lang, "site.json");
                var json = File.ReadAllText(path);
                _content[lang] = JsonSerializer.Deserialize<SiteContent>(json, options)
                    ?? throw new InvalidOperationException($"Empty site content: {path}");
            }
        }

        public SiteContent Get(CultureInfo culture) => _content[IsPt(culture) ? "pt" : "en"];

        public static bool IsPt(CultureInfo culture) => culture.TwoLetterISOLanguageName == "pt";

        public static string Prefix(CultureInfo culture) => IsPt(culture) ? "/pt" : "";

        public static string HtmlLang(CultureInfo culture) => IsPt(culture) ? "pt-PT" : "en";

        public static string AlternatePath(PathString path, bool currentIsPt)
        {
            var value = path.HasValue ? path.Value! : "/";
            if (currentIsPt)
            {
                if (value.Equals("/pt", StringComparison.OrdinalIgnoreCase) || value.Equals("/pt/", StringComparison.OrdinalIgnoreCase))
                    return "/";
                return value.Length > 3 ? value.Substring(3) : "/";
            }
            return value == "/" ? "/pt" : "/pt" + value;
        }
    }
}
