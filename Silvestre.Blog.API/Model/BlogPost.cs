using System;

namespace Silvestre.Blog.API.Model
{
    public class BlogPost
    {
        public Uri Url { get; set; }

        public DateTime PostedAt { get; set; }

        public string Content { get; set; }
    }
}
