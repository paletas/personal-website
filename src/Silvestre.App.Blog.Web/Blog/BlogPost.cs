namespace Silvestre.App.Blog.Web.Blog
{
    public record BlogPost(
        string Uri, 
        string Title, 
        string? Description, 
        string Summary, 
        string RawContent, 
        string HtmlContent, 
        BlogCategory Category, 
        string[] Tags, 
        DateTime CreatedAt, 
        DateTime? LastUpdate);
}
