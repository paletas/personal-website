using Silvestre.App.Blog.Web.Core.Parsers;

namespace Silvestre.App.Blog.Web.Blog.Readers
{
    public class CategoryReader
    {
        private readonly Stream _categoryContents;

        public CategoryReader(Stream categoryContents)
        {
            this._categoryContents = categoryContents;
        }

        public Task<Category> ReadCategory(CancellationToken cancellationToken = default)
        {
            return Task.FromResult(YAML.Deserialize<Category>(this._categoryContents));
        }
    }
}
