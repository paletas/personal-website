namespace Silvestre.App.Blog.Web.Blog.Readers
{
    public class Category
    {
        public string? Title { get; set; }

        public string? Description { get; set; }

        public string[] Tags { get; set; } = Array.Empty<string>();
    }
}
