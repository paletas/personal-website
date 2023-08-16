namespace Silvestre.App.Blog.Web.Core
{
    public class PageMeta
    {
        public string Description { get; set; }

        public string Summary { get; set; }
        
        public string[] Tags { get; set; } = Array.Empty<string>();
    }
}
