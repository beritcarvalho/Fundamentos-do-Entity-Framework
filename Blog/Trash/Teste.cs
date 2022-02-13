using Blog.Data;
using Blog.Models;

public class Teste
{
    public void Insert()
    {
        using (var context = new BlogDataContext())
        {
            var user = new User
            {
                Name = "Teste",
                Email = "teste",
                PasswordHash = "teste",
                Bio = "teste",
                Image = "teste",
                Slug = "teste"
            };

            context.Add(user);
            context.SaveChanges();
        }
    }

    public void Update()
    {
        using (var context = new BlogDataContext())
        {
            var user = context.Users.FirstOrDefault(u => u.Id == 5);

            user.Name = "Garen Stemmaguarda";
            user.Email = "garen@lol.com";
            user.PasswordHash = "garen123";
            user.Slug = "garem";

            context.Update(user);
            context.SaveChanges();
        }
    }



    public void Delete()
    {
        using (var context = new BlogDataContext())
        {
            var user = context.Users.FirstOrDefault(u => u.Id == 6 || u.Id == 7);

            context.Remove(user);
            context.SaveChanges();
        }
    }
}