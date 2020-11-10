using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Silvestre.Blog.API.Data
{
    public class BlogContext
    {
        private readonly string _connectionName;
        private readonly string _connectionString;

        public BlogContext(IConfiguration applicationConfiguration, string connectionName = null)
        {
            this._connectionName = connectionName ?? nameof(BlogContext);
            this._connectionString = applicationConfiguration.GetConnectionString(this._connectionName);
        }

        public Task Create(BlogPostDTO post)
        {
            if (post is null) throw new System.ArgumentNullException(nameof(post));

            using var sqlConnection = new SqlConnection(this._connectionString);

            var createCommand = new CommandDefinition("INSERT INTO blog.BlogPost (Url, When, Content, Version) VALUES (@Url, @When, @Content)",
                new { Url = post.Url, When = post.When, Content = post.Content }
            );

            return sqlConnection.ExecuteAsync(createCommand);
        }

        public Task<BlogPostDTO> Get(int postId)
        {
            using var sqlConnection = new SqlConnection(this._connectionString);

            var getCommand = new CommandDefinition("SELECT Id, Url, When, Content, Version FROM blog.BlogPost WHERE Id = @Id",
                new { Id = postId }
            );

            return sqlConnection.QuerySingleAsync<BlogPostDTO>(getCommand);
        }

        public Task<IEnumerable<BlogPostDTO>> ListAll()
        {
            using var sqlConnection = new SqlConnection(this._connectionString);

            var listAllCommand = new CommandDefinition("SELECT Id, Url, When, Content, Version FROM blog.BlogPost");

            return sqlConnection.QueryAsync<BlogPostDTO>(listAllCommand);
        }
    }
}
