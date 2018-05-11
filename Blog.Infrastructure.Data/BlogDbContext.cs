using System.Data.Entity;
using Blog.Domain.Core;

namespace Blog.Infrastructure.Data
{
    public class BlogDbContext : DbContext
    {
        /// <summary>
        /// Creates a set of articles in database.
        /// </summary>
        public DbSet<Article> Articles { get; set; }
        /// <summary>
        /// Creates a set of questions in database.
        /// </summary>
        public DbSet<Question> Questions { get; set; }
        /// <summary>
        /// Creates a set of responses in database.
        /// </summary>
        public DbSet<Response> Responses { get; set; }
        /// <summary>
        /// Creates a connection with database using connection string.
        /// </summary>
        /// <param name="connectionString">Connection string with database.</param>
        public BlogDbContext(string connectionString) : base(connectionString)
        { }
        /// <summary>
        /// Static constructor to initialize the database.
        /// </summary>
        static BlogDbContext()
        {
            Database.SetInitializer(new BlogDbInitializer());
        }
    }
}