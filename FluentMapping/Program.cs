using System;
using FluentMapping.Data;
using FluentMapping.Models;

namespace FluentMapping
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new FluentBlogContext();

            context.Users.Add(new User
            {
                Name = "Berit Carvalho",
                Email = "berit@berit.com",
                Image = "https://berit.com",
                Bio = "Estudando muito",
                PasswordHash = "berit123",
                Slug = "berit-carvalho132"
            });

            context.SaveChanges();
            Console.WriteLine("Hello World!");
        }
    }
}
