using Markdig;
using Markdig.Extensions.Yaml;
using Markdig.Syntax;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Silvestre.App.Web.Models
{
    public record ProjectEntry(string Slug, string Title, string Tagline, int Order, string Kind, string Html);

    public record ProjectFacts(string Status, IReadOnlyList<string> Stack, string LastActive);

    // Renders the Markdown case studies under Content/projects/{en,pt} and the shared facts.json once at start-up.
    public class ProjectArchive
    {
        private readonly Dictionary<string, ProjectEntry> _en = new(StringComparer.Ordinal);
        private readonly Dictionary<string, ProjectEntry> _pt = new(StringComparer.Ordinal);
        private readonly Dictionary<string, ProjectFacts> _facts = new(StringComparer.Ordinal);

        public ProjectArchive(IWebHostEnvironment env)
        {
            var root = Path.Combine(env.ContentRootPath, "Content", "projects");
            if (!Directory.Exists(root))
                throw new DirectoryNotFoundException($"Projects folder not found: {root}");

            var pipeline = new MarkdownPipelineBuilder().UseAdvancedExtensions().UseYamlFrontMatter().Build();
            Load(Path.Combine(root, "en"), _en, pipeline);
            Load(Path.Combine(root, "pt"), _pt, pipeline);

            var factsFile = Path.Combine(root, "facts.json");
            if (!File.Exists(factsFile))
                throw new FileNotFoundException($"Project facts not found: {factsFile}");
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var parsed = JsonSerializer.Deserialize<FactsFile>(File.ReadAllText(factsFile), options);
            if (parsed?.Projects is not null)
            {
                foreach (var (slug, facts) in parsed.Projects)
                    _facts[slug] = new ProjectFacts(facts.Status ?? "", facts.Stack ?? new List<string>(), facts.LastActive ?? "");
            }

            foreach (var slug in _en.Keys.Union(_pt.Keys, StringComparer.Ordinal))
            {
                if (!_en.ContainsKey(slug)) throw new InvalidOperationException($"Project '{slug}' exists in pt but not in en.");
                if (!_pt.ContainsKey(slug)) throw new InvalidOperationException($"Project '{slug}' exists in en but not in pt.");
                if (_en[slug].Kind == "project" && !_facts.ContainsKey(slug))
                    throw new InvalidOperationException($"Project '{slug}' has no entry in facts.json.");
            }
        }

        public IReadOnlyList<ProjectEntry> All(bool pt) =>
            (pt ? _pt : _en).Values.OrderBy(p => p.Order).ThenBy(p => p.Slug, StringComparer.Ordinal).ToList();

        public ProjectEntry? Get(string slug, bool pt) => (pt ? _pt : _en).TryGetValue(slug, out var entry) ? entry : null;

        public ProjectFacts? Facts(string slug) => _facts.TryGetValue(slug, out var facts) ? facts : null;

        private static void Load(string dir, Dictionary<string, ProjectEntry> target, MarkdownPipeline pipeline)
        {
            if (!Directory.Exists(dir))
                throw new DirectoryNotFoundException($"Projects folder not found: {dir}");

            foreach (var file in Directory.GetFiles(dir, "*.md"))
            {
                var slug = Path.GetFileNameWithoutExtension(file);
                var doc = Markdown.Parse(File.ReadAllText(file), pipeline);
                var meta = ReadFrontMatter(doc);

                meta.TryGetValue("title", out var title);
                meta.TryGetValue("tagline", out var tagline);
                meta.TryGetValue("kind", out var kind);
                var order = meta.TryGetValue("order", out var o) && !string.IsNullOrWhiteSpace(o)
                    ? int.Parse(o, CultureInfo.InvariantCulture) : 0;

                target[slug] = new ProjectEntry(slug, title ?? slug, tagline ?? "", order,
                    string.IsNullOrWhiteSpace(kind) ? "project" : kind, Markdown.ToHtml(doc, pipeline));
            }
        }

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
                var value = text.Substring(colon + 1).Trim();
                if (value.Length >= 2 && value[0] == '"' && value[^1] == '"') value = value.Substring(1, value.Length - 2);
                result[key] = value;
            }
            return result;
        }

        private class FactsFile
        {
            public Dictionary<string, FactsRow>? Projects { get; set; }
        }

        private class FactsRow
        {
            public string? Status { get; set; }
            public List<string>? Stack { get; set; }
            public string? LastActive { get; set; }
        }
    }
}
