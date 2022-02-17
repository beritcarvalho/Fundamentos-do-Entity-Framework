using FluentMapping.Data.Mappings;
using FluentMapping.Models;
using Microsoft.EntityFrameworkCore;

namespace FluentMapping.Data
{
    public class FluentBlogContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Server=localhost,1433;Database=FluentBlog;User ID=sa;Password=1q2w3e4r@#$");

        //alem das configurações padroes do context, quando utilizamos o fluent mapping e classes de mapeamento
        //é necessário dizer para o contexto que temos classes de mapeamento

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new PostMap());
        }
    }
}


