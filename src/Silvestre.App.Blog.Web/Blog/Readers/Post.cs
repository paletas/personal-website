namespace Silvestre.App.Blog.Web.Blog.Readers
{
    public class Post
    {
        public string RawContent { get; set; } = null!;

        public string HtmlContent { get; set; } = null!;

        public string? Title { get; set; } = null!;

        public string? Description { get; set; } = null!;

        public string[] Tags { get; set; } = Array.Empty<string>();

        public DateOnly CreationDate { get; set; }

        public DateOnly? UpdateDate { get; set; }
    }
}
