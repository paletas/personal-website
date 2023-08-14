namespace Silvestre.App.Blog.Web.Blog.Readers
{
    public class Post
    {
        public string RawContent { get; set; } = null!;

        public string HtmlContent { get; set; } = null!;

        public string? Title { get; set; }

        public string? Description { get; set; }

        public string? Summary { get; set; } = null!;

        public string[] Tags { get; set; } = Array.Empty<string>();

        public bool Draft { get; set; }

        public DateOnly CreationDate { get; set; }

        public DateOnly? UpdateDate { get; set; }
    }
}
