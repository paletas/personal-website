using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Silvestre.App.Web.Pages.Home
{
    public record StackContent(List<string> Stack, List<string> AiTooling);

    public class ProfileModel : PageModel
    {
        private static readonly object StackLock = new();
        private static StackContent _stackContent;

        private readonly IWebHostEnvironment _env;

        public ProfileModel(IWebHostEnvironment env)
        {
            _env = env;
        }

        public IReadOnlyList<string> Stack { get; private set; } = Array.Empty<string>();

        public IReadOnlyList<string> AiTooling { get; private set; } = Array.Empty<string>();

        public void OnGet()
        {
            var content = LoadStack(_env.ContentRootPath);
            Stack = content.Stack;
            AiTooling = content.AiTooling;
        }

        private static StackContent LoadStack(string contentRoot)
        {
            if (_stackContent != null)
            {
                return _stackContent;
            }

            lock (StackLock)
            {
                if (_stackContent == null)
                {
                    var path = Path.Combine(contentRoot, "Content", "stack.json");
                    var json = System.IO.File.ReadAllText(path);
                    _stackContent = JsonSerializer.Deserialize<StackContent>(
                        json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                }

                return _stackContent;
            }
        }
    }
}
