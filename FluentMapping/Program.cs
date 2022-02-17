using System;
using System.Linq;
using FluentMapping.Data;
using FluentMapping.Models;

namespace FluentMapping
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new FluentBlogContext();

            /*context.Users.Add(new User
            {
                Name = "Berit Carvalho",
                Email = "berit@berit.com",
                Image = "https://berit.com",
                Bio = "Estudando muito",
                PasswordHash = "berit123",
                Slug = "berit-carvalho132"
            });

            context.SaveChanges();*/
            var user = context.Users.FirstOrDefault();
            var post = new Post
            {
                Author = user,
                Body = "Meu Artigo de teste",
                Category = new Category
                {
                    Name = "Backend",
                    Slug = "backend"
                },
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                Slug = "meu-artigo",
                Summary = "Vamos conferir a primeira postagem",
                Title = "Meu artigo"
            };

            context.Posts.Add(post);
            context.SaveChanges();
            Console.WriteLine("Hello World!");
        }
    }
}
