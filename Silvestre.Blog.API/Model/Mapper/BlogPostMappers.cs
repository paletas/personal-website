using Silvestre.Blog.API.Data;
using System;

namespace Silvestre.Blog.API.Model.Mapper
{
    public static class BlogPostMappers
    {
        public static BlogPost AsModel(this BlogPostDTO blogPost)
        {
            if (blogPost is null) throw new ArgumentNullException(nameof(blogPost));

            return new BlogPost
            {
                Url = blogPost.Url,
                PostedAt = blogPost.When,
                Content = blogPost.Content
            };
        }
    }
}
