using FluentMapping.Models;
using Microsoft.EntityFrameworkCore;

namespace FluentMapping.Data
{
    public class FluentBlogContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Server=localhost,1433;Database=FluentBlog;User ID=sa;Password=1q2w3e4r@#$");
    }
}


