using Markdig;
using Markdig.Extensions.Yaml;
using Markdig.Syntax;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Silvestre.App.Web.Models
{
    public record PostSummary(string Slug, string Title, string Description, string Summary, DateTime Created, DateTime Updated);

    public record Post(PostSummary Summary, string Html);

    // Renders the Markdown posts under Content/writing once at start-up.
    public class WritingArchive
    {
        private readonly Dictionary<string, Post> _posts = new(StringComparer.Ordinal);

        public WritingArchive(IWebHostEnvironment env)
        {
            var dir = Path.Combine(env.ContentRootPath, "Content", "writing");
            if (!Directory.Exists(dir))
                throw new DirectoryNotFoundException($"Writing folder not found: {dir}");

            var pipeline = new MarkdownPipelineBuilder().UseAdvancedExtensions().UseYamlFrontMatter().Build();

            foreach (var file in Directory.GetFiles(dir, "*.md"))
            {
                var slug = Path.GetFileNameWithoutExtension(file);
                var doc = Markdown.Parse(File.ReadAllText(file), pipeline);
                var meta = ReadFrontMatter(doc);
                if (meta.TryGetValue("draft", out var draft) && draft.Equals("true", StringComparison.OrdinalIgnoreCase))
                    continue;

                meta.TryGetValue("title", out var title);
                meta.TryGetValue("description", out var description);
                meta.TryGetValue("summary", out var summary);
                var created = ParseDate(meta, "creationDate");
                var updated = meta.TryGetValue("updateDate", out var u) && !string.IsNullOrWhiteSpace(u) ? ParseDate(meta, "updateDate") : created;

                var summaryRecord = new PostSummary(slug, title ?? slug, description ?? "", summary ?? "", created, updated);
                _posts[slug] = new Post(summaryRecord, Markdown.ToHtml(doc, pipeline));
            }
        }

        public IReadOnlyList<PostSummary> List() =>
            _posts.Values.Select(p => p.Summary).OrderByDescending(p => p.Created).ThenBy(p => p.Slug, StringComparer.Ordinal).ToList();

        public Post? Get(string slug) => _posts.TryGetValue(slug, out var post) ? post : null;

        private static Dictionary<string, string> ReadFrontMatter(MarkdownDocument doc)
        {
            var result = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            var block = doc.OfType<YamlFrontMatterBlock>().FirstOrDefault();
            if (block is null) return result;

            foreach (var line in block.Lines.Lines.Take(block.Lines.Count))
            {
                var text = line.ToString().Trim();
                if (text.Length == 0 || text.StartsWith('-')) continue;
                var colon = text.IndexOf(':');
                if (colon <= 0) continue;
                var key = text.Substring(0, colon).Trim();
                if (key.Equals("tags", StringComparison.OrdinalIgnoreCase)) continue;
                var value = text.Substring(colon + 1).Trim();
                if (value.Length >= 2 && value[0] == '"' && value[^1] == '"') value = value.Substring(1, value.Length - 2);
                result[key] = value;
            }
            return result;
        }

        private static DateTime ParseDate(Dictionary<string, string> meta, string key) =>
            meta.TryGetValue(key, out var value)
                && DateTime.TryParse(value, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeUniversal, out var date)
                ? date : DateTime.MinValue;
    }
}
