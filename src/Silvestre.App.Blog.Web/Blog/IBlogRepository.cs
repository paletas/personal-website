namespace Silvestre.App.Blog.Web.Blog
{
    public interface IBlogRepository
    {
        Task<IEnumerable<BlogCategory>> GetCategories(CancellationToken cancellationToken = default);

        Task<IEnumerable<BlogCategory>> GetCategoriesUsingTag(string tag, CancellationToken cancellationToken = default);

        Task<BlogPost?> GetBlogPost(string postUri, CancellationToken cancellationToken = default);

        Task<IEnumerable<BlogPost>> GetBlogPosts(string? category, string? tag, CancellationToken cancellationToken = default);

        Task<IEnumerable<BlogPost>> GetLatestBlogPosts(int count, CancellationToken cancellationToken = default);

        Task<IEnumerable<BlogPost>> GetLatestBlogPostsForCategory(string categoryUri, int count, CancellationToken cancellationToken = default);

        Task<IEnumerable<BlogPost>> GetLatestBlogPostsForTag(string tag, int count, CancellationToken cancellationToken = default);
    }
}
