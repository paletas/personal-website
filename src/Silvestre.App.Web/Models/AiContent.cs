using Markdig;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Silvestre.App.Web.Models
{
    public record AiItem(string Title, string Who, string BodyHtml);

    public record AiSection(string Id, string Label, string HeadingHtml, string IntroHtml, IReadOnlyList<AiItem> Items, string Code, string Cta);

    public class AiDocument
    {
        private readonly Dictionary<string, AiSection> _sections;

        public AiDocument(AiSection head, Dictionary<string, AiSection> sections)
        {
            Head = head;
            _sections = sections;
        }

        public AiSection Head { get; }

        public AiSection Section(string id) => _sections[id];
    }

    // Loads Content/{en,pt}/ai.md: marker lines split the file into sections, see ParseSection.
    public class AiContent
    {
        private static readonly string[] SectionIds = { "loop", "prototype", "behaviour", "unbounded", "benefits", "under-the-hood", "in-practice", "contact" };
        private static readonly Regex Marker = new(@"^<!-- ([a-z-]+)(?: \| (.+))? -->$", RegexOptions.Compiled);
        private static readonly MarkdownPipeline Pipeline = new MarkdownPipelineBuilder().UseAdvancedExtensions().Build();

        private readonly Dictionary<string, AiDocument> _documents = new();

        public AiContent(IWebHostEnvironment env)
        {
            foreach (var lang in new[] { "en", "pt" })
            {
                var path = Path.Combine(env.ContentRootPath, "Content", lang, "ai.md");
                _documents[lang] = Parse(File.ReadAllText(path), path);
            }
        }

        public AiDocument Get(CultureInfo culture) => _documents[SiteContentProvider.IsPt(culture) ? "pt" : "en"];

        private static AiDocument Parse(string text, string path)
        {
            var chunks = new List<(string Id, string Label, List<string> Lines)>();
            foreach (var line in text.Replace("\r\n", "\n").TrimStart('﻿').Split('\n'))
            {
                var m = Marker.Match(line.TrimEnd());
                if (m.Success) chunks.Add((m.Groups[1].Value, m.Groups[2].Success ? m.Groups[2].Value : "", new List<string>()));
                else if (chunks.Count > 0) chunks[^1].Lines.Add(line);
            }

            var sections = chunks.ToDictionary(c => c.Id, c => ParseSection(c.Id, c.Label, c.Lines));
            foreach (var id in new[] { "head" }.Concat(SectionIds))
                if (!sections.ContainsKey(id))
                    throw new InvalidOperationException($"Missing section '{id}' in {path}");

            var head = sections["head"];
            sections.Remove("head");
            return new AiDocument(head, sections);
        }

        private static AiSection ParseSection(string id, string label, List<string> lines)
        {
            var headingPrefix = id == "head" ? "# " : "## ";
            string heading = "", cta = "";
            var intro = new List<string>();
            var code = new List<string>();
            var items = new List<(string Title, string Who, List<string> Body)>();
            var inFence = false;
            var seenFence = false;

            foreach (var line in lines)
            {
                if (line.StartsWith("```"))
                {
                    if (inFence) inFence = false;
                    else if (!seenFence) { inFence = true; seenFence = true; }
                    continue;
                }
                if (inFence) { code.Add(line); continue; }

                if (line.StartsWith("### ")) { items.Add((line.Substring(4).Trim(), "", new List<string>())); continue; }
                if (items.Count == 0 && heading.Length == 0 && line.StartsWith(headingPrefix)) { heading = line.Substring(headingPrefix.Length).Trim(); continue; }
                if (line.StartsWith("cta: ")) { cta = line.Substring(5).Trim(); continue; }

                if (items.Count > 0)
                {
                    var item = items[^1];
                    if (item.Body.All(string.IsNullOrWhiteSpace) && item.Who.Length == 0 && line.StartsWith("who: "))
                        items[^1] = (item.Title, line.Substring(5).Trim(), item.Body);
                    else
                        item.Body.Add(line);
                }
                else intro.Add(line);
            }

            var headingHtml = heading.Length == 0 ? "" : Regex.Replace(StripParagraph(Markdown.ToHtml(heading, Pipeline)), @"\{\{(.+?)\}\}", "<span class=\"grad-text\">$1</span>");
            var introHtml = Markdown.ToHtml(string.Join("\n", intro).Trim(), Pipeline).Trim();
            var itemList = items.Select(i => new AiItem(i.Title, i.Who, StripParagraph(Markdown.ToHtml(string.Join("\n", i.Body).Trim(), Pipeline)))).ToList();
            return new AiSection(id, label, headingHtml, introHtml, itemList, string.Join("\n", code).TrimEnd('\n'), cta);
        }

        // "<p>x</p>" -> "x" for single-paragraph fragments used inside an existing element.
        private static string StripParagraph(string html)
        {
            html = html.Trim();
            if (html.StartsWith("<p>") && html.EndsWith("</p>") && html.IndexOf("<p>", 3, StringComparison.Ordinal) < 0)
                return html.Substring(3, html.Length - 7);
            return html;
        }

        private static readonly string[] Keywords = { "Given", "When", "Then", "And", "Dado", "Quando", "Então", "E" };

        // Turns the scenario text of ai.md into the coloured spans used by the .scn block.
        public static string HighlightScenario(string code)
        {
            var sb = new StringBuilder();
            var first = true;
            foreach (var line in code.Replace("\r\n", "\n").Split('\n'))
            {
                if (!first) sb.Append('\n');
                first = false;
                sb.Append(HighlightLine(line));
            }
            return sb.ToString();
        }

        private static string HighlightLine(string line)
        {
            var trimmed = line.TrimStart();
            var indent = line.Substring(0, line.Length - trimmed.Length);
            if (trimmed.Length == 0) return "";
            if (trimmed[0] == '#' || trimmed[0] == '─') return $"<span class=\"d\">{Enc(line)}</span>";

            foreach (var scenario in new[] { "Scenario:", "Cenário:" })
                if (trimmed.StartsWith(scenario, StringComparison.Ordinal))
                    return $"{indent}<span class=\"kw\">{scenario}</span> <span class=\"t\">{Enc(trimmed.Substring(scenario.Length).TrimStart())}</span>";

            foreach (var kw in Keywords)
                if (trimmed.StartsWith(kw + " ", StringComparison.Ordinal))
                    return $"{indent}<span class=\"kw\">{kw}</span>{Enc(trimmed.Substring(kw.Length))}";

            var mock = Regex.Match(trimmed, @"^mockup v\d");
            if (mock.Success) return $"{indent}<span class=\"kw\">{mock.Value}</span>{Enc(trimmed.Substring(mock.Length))}";

            if (trimmed[0] == '✓')
            {
                // "✓ name   description": the description (after a run of two or more spaces) is dimmed.
                var rest = trimmed.Substring(1);
                var gap = Regex.Match(rest, @"\S {2,}(?=\S)");
                var split = gap.Success ? gap.Index + gap.Length : -1;
                var body = split < 0 ? Enc(rest) : Enc(rest.Substring(0, split)) + $"<span class=\"d\">{Enc(rest.Substring(split))}</span>";
                return $"{indent}<span class=\"g\">✓</span>{body}";
            }
            if (trimmed[0] == '→') return $"{indent}<span class=\"g\">→</span> <span class=\"d\">{Enc(trimmed.Substring(1).TrimStart())}</span>";

            return Enc(line);
        }

        // Only the characters that matter in HTML text, so apostrophes stay readable.
        private static string Enc(string s) => s.Replace("&", "&amp;").Replace("<", "&lt;").Replace(">", "&gt;");
    }
}
