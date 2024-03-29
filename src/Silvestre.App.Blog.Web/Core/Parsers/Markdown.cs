﻿using Markdig;
using Silvestre.App.Blog.Web.Core.Formats;

namespace Silvestre.App.Blog.Web.Core.Parsers
{
    public static class Markdown
    {
        private static MarkdownPipelineBuilder _PipelineBuilder;

        static Markdown()
        {
            _PipelineBuilder = new MarkdownPipelineBuilder()
                .UseYamlFrontMatter()
                .UseBootstrap()
                .UseAutoLinks();
        }

        public static string BaseUrlPlaceholder { get; set; } = "PLACEHOLDER_BASE_URL";

        public static async Task<MarkdownDocument<T>> Deserialize<T>(Stream markdownStream, CancellationToken cancellationToken = default)
        {
            using StreamReader reader = new(markdownStream);
            string rawMarkdown = await reader.ReadToEndAsync(cancellationToken);

            using StringWriter htmlWriter = new();
            Markdig.Renderers.HtmlRenderer htmlRenderer = new(htmlWriter)
            {
                LinkRewriter = path =>
                {
                    if (path.StartsWith("http://") || path.StartsWith("https://"))
                        return path;
                    else
                        return $"{BaseUrlPlaceholder}{(path.StartsWith("/") ? string.Empty : "/")}{path}";
                }
            };

            MarkdownPipeline pipeline = _PipelineBuilder.Build();
            pipeline.Setup(htmlRenderer);

            T? metadata = default;
            Markdig.Syntax.MarkdownDocument document = Markdig.Markdown.Parse(rawMarkdown, pipeline);
            Markdig.Extensions.Yaml.YamlFrontMatterBlock? frontMatterBlock = Markdig.Syntax.MarkdownObjectExtensions.Descendants<Markdig.Extensions.Yaml.YamlFrontMatterBlock>(document).SingleOrDefault();
            if (frontMatterBlock is not null)
            {
                string yaml = rawMarkdown.Substring(frontMatterBlock.Span.Start + 3, frontMatterBlock.Span.Length - 6);
                metadata = YAML.Deserialize<T>(yaml);
            }

            htmlRenderer.Render(document);
            htmlWriter.Flush();

            return new MarkdownDocument<T>
            {
                RawContent = rawMarkdown,
                HtmlContent = htmlWriter.ToString(),
                FrontMatter = metadata
            };
        }
    }
}
