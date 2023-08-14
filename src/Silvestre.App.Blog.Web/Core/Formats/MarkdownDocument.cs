namespace Silvestre.App.Blog.Web.Core.Formats
{
    public class MarkdownDocument
    {
        public string RawContent { get; set; } = null!;

        public string? HtmlContent { get; set; }
    }

    public class MarkdownDocument<T> : MarkdownDocument
    {
        public T? FrontMatter { get; set; }
    }
}
