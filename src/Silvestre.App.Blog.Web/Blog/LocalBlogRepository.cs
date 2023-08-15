using Silvestre.App.Blog.Web.Blog.Readers;
using System.Collections.Concurrent;

namespace Silvestre.App.Blog.Web.Blog
{
    public class LocalBlogRepository : IBlogRepository
    {
        private readonly string _blogRootPath;
        private readonly bool _loadDrafts;
        private volatile bool _isInitialized;

        private readonly ConcurrentDictionary<string, BlogCategory> _blogCategories = new();
        private readonly ConcurrentDictionary<string, BlogPost> _blogPosts = new();

        public LocalBlogRepository(string blogRootPath, bool loadDrafts = false)
        {
            this._blogRootPath = blogRootPath;
            this._loadDrafts = loadDrafts;
        }

        public async Task<BlogPost?> GetBlogPost(string postUri, CancellationToken cancellationToken = default)
        {
            await EnsureInitialization();
            if (this._blogPosts.TryGetValue(postUri, out BlogPost? blogPost))
                return blogPost;
            else
                return null;
        }

        public async Task<IEnumerable<BlogPost>> GetBlogPosts(string? category, string? tag, CancellationToken cancellationToken = default)
        {
            await EnsureInitialization();
            IEnumerable<BlogPost> posts = this._blogPosts.Values;
            if (category is not null)
            {
                posts = posts.Where(p => p.Category.Uri == category);
            }

            if (tag is not null)
            {
                posts = posts.Where(p => p.Tags.Contains(tag));
            }
            return posts;
        }

        public async Task<IEnumerable<BlogCategory>> GetCategories(CancellationToken cancellationToken = default)
        {
            await EnsureInitialization();
            return this._blogCategories.Values;
        }

        public async Task<IEnumerable<BlogPost>> GetLatestBlogPosts(int count, CancellationToken cancellationToken = default)
        {
            await EnsureInitialization();
            return this._blogPosts.Values.OrderByDescending(post => post.CreatedAt).Take(count);
        }

        public async Task<IEnumerable<BlogPost>> GetLatestBlogPostsForCategory(string categoryUri, int count, CancellationToken cancellationToken = default)
        {
            await EnsureInitialization();
            return this._blogPosts.Values.Where(post => post.Category.Uri == categoryUri).OrderByDescending(post => post.CreatedAt).Take(count);
        }

        public async Task<IEnumerable<BlogCategory>> GetCategoriesUsingTag(string tag, CancellationToken cancellationToken = default)
        {
            await EnsureInitialization();
            return this._blogPosts.Values.Where(post => post.Tags.Contains(tag)).Select(post => post.Category);
        }

        public async Task<IEnumerable<BlogPost>> GetLatestBlogPostsForTag(string tag, int count, CancellationToken cancellationToken = default)
        {
            await EnsureInitialization();
            return this._blogPosts.Values.Where(post => post.Tags.Contains(tag)).OrderByDescending(post => post.CreatedAt).Take(count);
        }

        private async Task EnsureInitialization()
        {
            if (this._isInitialized)
                return;

            await ParseDirectory(this._blogRootPath, this._loadDrafts, this._blogCategories, this._blogPosts);
            this._isInitialized = true;
        }

        private static async Task ParseDirectory(string directoryPath, bool loadDrafts, ConcurrentDictionary<string, BlogCategory> categories, ConcurrentDictionary<string, BlogPost> posts, string[]? tags = null)
        {
            List<string> localTags = new(tags ?? Array.Empty<string>());

            BlogCategory? blogCategory = await ParseMetadataFiles(directoryPath, categories, localTags);

            if (blogCategory is not null)
            {
                await ParsePostFiles(directoryPath, loadDrafts, posts, localTags, blogCategory);
            }

            foreach (string subDirectory in Directory.GetDirectories(directoryPath))
            {
                await ParseDirectory(subDirectory, loadDrafts, categories, posts, localTags.ToArray());
            }
        }

        private static async Task ParsePostFiles(string directoryPath, bool loadDrafts, ConcurrentDictionary<string, BlogPost> posts, List<string> localTags, BlogCategory blogCategory)
        {
            foreach (string postFile in Directory.EnumerateFiles(directoryPath, "*.md", SearchOption.TopDirectoryOnly))
            {
                string postUri = Path.GetFileNameWithoutExtension(postFile);
                FileStream postStream = File.OpenRead(postFile);

                PostReader postReader = new(postStream);
                Post? post = await postReader.ReadPost();
                if (post is null || (!loadDrafts && post.Draft)) continue;

                ArgumentNullException.ThrowIfNullOrEmpty(post.Title, nameof(post.Title));
                ArgumentNullException.ThrowIfNullOrEmpty(post.Summary, nameof(post.Summary));

                BlogPost blogPost = new(postUri, post.Title, post.Description, post.Summary, post.RawContent, post.HtmlContent, blogCategory, localTags.Concat(post.Tags).ToArray(), post.CreationDate, post.UpdateDate ?? post.CreationDate);
                if (posts.TryAdd(postUri, blogPost) == false)
                {
                    throw new InvalidOperationException($"duplicate post {postUri}");
                }
            }
        }

        private static async Task<BlogCategory?> ParseMetadataFiles(string directoryPath, ConcurrentDictionary<string, BlogCategory> categories, List<string> foundTags)
        {
            short fileCount = 0;
            BlogCategory? blogCategory = null;
            foreach (string metadataFile in Directory.EnumerateFiles(directoryPath, "*.yml", SearchOption.TopDirectoryOnly))
            {
                if (++fileCount > 1)
                {
                    throw new InvalidOperationException("more than one metadata file found");
                }

                string categoryUri = Path.GetFileNameWithoutExtension(metadataFile);
                FileStream categoryContentStream = File.OpenRead(metadataFile);

                CategoryReader categoryReader = new(categoryContentStream);
                Category category = await categoryReader.ReadCategory();

                if (category.Title is not null)
                {
                    ArgumentNullException.ThrowIfNull(category.Description, nameof(category.Description));

                    blogCategory = new(categoryUri, category.Title, category.Description, category.Tags);
                    if (categories.TryAdd(categoryUri, blogCategory) == false)
                    {
                        throw new InvalidOperationException($"duplicate category {categoryUri}");
                    }
                }

                foundTags.AddRange(category.Tags);
            }
            return blogCategory;
        }
    }
}
