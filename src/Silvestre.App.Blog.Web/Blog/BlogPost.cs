namespace Silvestre.App.Blog.Web.Blog
{
    public record BlogPost(string Uri, string? Title, string RawContent, string HtmlContent, BlogCategory Category, string[] Tags, DateOnly CreatedAt)
    {
    }
}
