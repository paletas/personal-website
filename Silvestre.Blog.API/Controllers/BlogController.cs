using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Silvestre.Blog.API.Data;
using Silvestre.Blog.API.Model;
using Silvestre.Blog.API.Model.Mapper;
using System;
using System.Threading.Tasks;

namespace Silvestre.Blog.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly ILogger<BlogController> _logger;
        private readonly BlogContext _blogContext;

        public BlogController(ILogger<BlogController> logger, BlogContext blogContext)
        {
            this._logger = logger;
            this._blogContext = blogContext;
        }

        [HttpGet("{id}")]
        public async Task<BlogPost> Get(int id)
        {
            _logger.LogInformation($"Get called by {base.HttpContext.Connection.RemoteIpAddress} with Id {id}");

            var blogPost = await _blogContext.Get(id).ConfigureAwait(false);
            return blogPost.AsModel();
        }
    }
}
