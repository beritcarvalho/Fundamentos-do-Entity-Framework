using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Data;
using Blog.Models;

namespace Blog.Trash
{
    public class InsercaoPostAuthorCategory
    {
        public void InserirPostAuthorCategory()
        {
            var author = new User
            {
                Name = "Berit Carvalho",
                Email = "berit@berit.com",
                PasswordHash = "berit",
                Bio = "Estudante de Carreira BackEnd .NET",
                Image = "https://media-exp1.licdn.com/dms/image/C4E03AQHGijvOK2kRFw/profile-displayphoto-shrink_800_800/0/1633297004539?e=1649894400&v=beta&t=ox3quPCNjIjGElwEOZI2utdnxIjPsv_LFmiwmSWIry8",
                Slug = "beritcarvalho"
            };
            Console.WriteLine(author);


            Category category = new Category
            {
                Name = "Fundamentos do Entity Framework",
                Slug = "fundamentosentityframework"
            };
            Console.WriteLine(category);


            var post = new Post
            {
                Category = category,
                Author = author,
                Title = "Como é iniciar os estudos em Entity Framework",
                Summary = "Resumo de como um aluno se sente ao estudar entity",
                Body = @"Realizei um CRUD automatico gerado pelo entity, achei incrivel e resolvi estudar.
                Estou gostando muito",
                Slug = "aluno-inicia-estudos-entity",
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now
            };
            Console.WriteLine(post);

            using (var context = new BlogDataContext())
            {
                context.Add(post);
                context.SaveChanges();
                Console.WriteLine("Dados salvos no banco de dados");
            }
        }
    }
}
