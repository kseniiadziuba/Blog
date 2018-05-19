using System.Data.Entity;
using Blog.Domain.Core;

namespace Blog.Infrastructure.Data
{
    public class UserContext:DbContext
    {
        public UserContext() : base("DefaultConnection")
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}