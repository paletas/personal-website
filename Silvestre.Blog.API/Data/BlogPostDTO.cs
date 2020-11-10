using System;

namespace Silvestre.Blog.API.Data
{
    public class BlogPostDTO
    {
        public int Id { get; set; }

        public Uri Url { get; set; }

        public DateTime When { get; set; }

        public string Content { get; set; }

#pragma warning disable CA1819 // Properties should not return arrays
        public byte[] RowVersion { get; set; }
#pragma warning restore CA1819 // Properties should not return arrays
    }
}
