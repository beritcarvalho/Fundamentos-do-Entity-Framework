using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Trash
{
    public class UpdatePostAuthorCategory
    {
        public void AtualizarPostAuthorCategory()
        {
            using(var context = new BlogDataContext())
            {      
                var postParaAtualizar = 
                context.Posts
                .Include(a => a.Author)
                .Include(c => c.Category)
                .OrderByDescending(p => p.LastUpdateDate)
                .FirstOrDefault();

                postParaAtualizar.Author.Name = "Berit Carvalho";
                context.Posts.Update(postParaAtualizar);
                context.SaveChanges();
            }
        }
    }
}
