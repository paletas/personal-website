namespace Silvestre.App.Blog.Web.Blog
{
    public interface IBlogRepository
    {
        Task<IEnumerable<BlogCategory>> GetCategories(CancellationToken cancellationToken = default);

        Task<IEnumerable<BlogCategory>> GetCategoriesUsingTag(string tag, CancellationToken cancellationToken = default);

        Task<BlogPost?> GetBlogPost(string postUri, CancellationToken cancellationToken = default);

        Task<IEnumerable<BlogPost>> GetLatestPosts(int count, CancellationToken cancellationToken = default);

        Task<IEnumerable<BlogPost>> GetLatestPostsForCategory(string categoryUri, int count, CancellationToken cancellationToken = default);

        Task<IEnumerable<BlogPost>> GetLatestPostsForTag(string tag, int count, CancellationToken cancellationToken = default);
    }
}
