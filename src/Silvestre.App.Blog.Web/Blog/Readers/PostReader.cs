using Silvestre.App.Blog.Web.Core.Formats;
using Silvestre.App.Blog.Web.Core.Parsers;

namespace Silvestre.App.Blog.Web.Blog.Readers
{
    public class PostReader
    {
        private readonly Stream _postContents;

        public PostReader(Stream postContents)
        {
            this._postContents = postContents;
        }

        public async Task<Post?> ReadPost(CancellationToken cancellationToken = default)
        {
            MarkdownDocument<Post> markdownDocument = await Markdown.Deserialize<Post>(this._postContents);
            if (markdownDocument.FrontMatter is null)
                return null;

            return new Post
            {
                RawContent = markdownDocument.RawContent,
                HtmlContent = markdownDocument.HtmlContent ?? throw new InvalidOperationException("missing html data for the post"),
                Title = markdownDocument.FrontMatter.Title,
                Description = markdownDocument.FrontMatter.Description,
                Summary = markdownDocument.FrontMatter.Summary,
                Tags = markdownDocument.FrontMatter.Tags,
                CreationDate = markdownDocument.FrontMatter.CreationDate,
                UpdateDate = markdownDocument.FrontMatter.UpdateDate
            };
        }
    }
}
