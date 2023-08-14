using Markdig;
using Silvestre.App.Blog.Web.Core.Formats;

namespace Silvestre.App.Blog.Web.Core.Parsers
{
    public static class Markdown
    {
        private static MarkdownPipelineBuilder _PipelineBuilder;

        static Markdown()
        {
            _PipelineBuilder = new MarkdownPipelineBuilder()
                .UseYamlFrontMatter();
        }

        public static async Task<MarkdownDocument> Deserialize(Stream markdownStream, CancellationToken cancellationToken = default)
        {
            using StreamReader reader = new(markdownStream);
            string rawMarkdown = await reader.ReadToEndAsync(cancellationToken);

            using StringWriter htmlWriter = new();
            Markdig.Renderers.HtmlRenderer htmlRenderer = new(htmlWriter);

            MarkdownPipeline pipeline = _PipelineBuilder.Build();
            pipeline.Setup(htmlRenderer);

            Markdig.Markdown.Parse(rawMarkdown, pipeline);

            return new MarkdownDocument
            {
                RawContent = rawMarkdown,
                HtmlContent = htmlWriter.ToString()
            };
        }

        public static async Task<MarkdownDocument<T>> Deserialize<T>(Stream markdownStream, CancellationToken cancellationToken = default)
        {
            using StreamReader reader = new(markdownStream);
            string rawMarkdown = await reader.ReadToEndAsync(cancellationToken);

            using StringWriter htmlWriter = new();
            Markdig.Renderers.HtmlRenderer htmlRenderer = new(htmlWriter);

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
