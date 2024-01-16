//Módulo 1
//using System;
//using System.Linq;
//using Blog.Data;
//using Blog.Models;
//using Microsoft.EntityFrameworkCore;

//namespace Blog
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //using (var context = new BlogDataContext())
//            //{
//            // Add
//            // var tag = new Tag { Name = ".NET", Slug = "dotnet2" };
//            // context.Tags.Add(tag);
//            // context.SaveChanges();

//            // Update 
//            // var tag = context.Tags.FirstOrDefault(x => x.Id == 1);
//            // tag.Name = ".NET";
//            // tag.Slug = "aspnet";
//            // context.Update(tag);
//            // context.SaveChanges();

//            // Delete
//            // var tag = context.Tags.FirstOrDefault(x => x.Id == 3);
//            // context.Remove(tag);
//            // context.SaveChanges();

//            // Select
//            // var tags = context
//            //     .Tags
//            //     .AsNoTracking() // Melhorará a performance // apenas no select, não usar no update
//            //     .ToList(); // sempre no final
//            // foreach (var tag in tags)
//            // {
//            //     Console.WriteLine(tag.Name);
//            // }

//            // Update - Comentários adicionais
//            // var tag = context
//            //     .Tags
//            //     .FirstOrDefault(x => x.Id == 3); // não usar o .AsNoTracking() // FirstDefault() trará NULL caso não exista, First() trará erro
//            // tag.Name = "Ponto NET";
//            // tag.Slug = "dotnet";
//            // context.Update(tag);
//            // context.SaveChanges();

//            // var tag = context
//            //     .Tags
//            //     .AsNoTracking()
//            //     .FirstOrDefault(x => x.Id == 3);

//            // Console.WriteLine(tag?.Name);
//            //}



//            // Add a data nested 
//            //using var context = new BlogDataContext();

//            //var user = new User
//            //{
//            //    Name = "Test",
//            //    Slug = "Test",
//            //    Email = "Test",
//            //    Bio = "Test",
//            //    Image = "Test",
//            //    PasswordHash = "Test"
//            //};

//            //var category = new Category
//            //{
//            //    Name = "Test",
//            //    Slug = "Test"
//            //};

//            //var post = new Post
//            //{
//            //    Author = user,
//            //    Category = category,
//            //    Body = "Test",
//            //    Slug = "Test",
//            //    Summary = "Test",
//            //    Title = "Test",
//            //    CreateDate = DateTime.Now,
//            //    LastUpdateDate = DateTime.Now
//            //};

//            //context.Posts.Add(post);
//            //context.SaveChanges();


//            //using var context = new BlogDataContext();
//            //var posts = context
//            //    .Posts
//            //    .AsNoTracking()
//            //    //.Where(x => x.AuthorId == 1)
//            //    .Include(x => x.Author)
//            //    .OrderBy(x => x.LastUpdateDate)
//            //    .ToList();
//            //foreach (var post in posts)
//            //{
//            //    Console.WriteLine($"{post.Title} escrito por {post.Author?.Name}");
//            //}
//        }
//    }
//}

//Módulo 2
//using System;
//using System.Linq;
//using Blog.Data;
//using Blog.Models;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Design;

//namespace Blog
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            using var context = new BlogDataContext();

//            context.Users.Add(new User
//            {
//                Name = "André Baltieri",
//                Email = "andre@balta.io",
//                PasswordHash = "123098457",
//                Bio = "9x Microsoft MVP",
//                Image = "https://balta.io",
//                Slug = "andrebaltieri",
//                Github = "andrebaltieri",
//            });
//            context.SaveChanges();

//            var user = context.Users.FirstOrDefault();
//            var post = new Post
//            {                
//                Category = new Category
//                {
//                    Name = "Backend",
//                    Slug = "backend"
//                },
//                Author = user,
//                Title = "Meu artigo",
//                Summary = "Neste artigo vamos conferir...",
//                Body = "Meu artigo",
//                Slug = "meu-artigo",
//                CreateDate = System.DateTime.Now,
//                //LastUpdateDate = DateTime.Now,
//                Tags = null,
//            };
//            context.Posts.Add(post);   
//            context.SaveChanges();
//        }
//    }
//}

//Módulo 3
using System;
using System.Linq;
using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new BlogDataContext();

            var posts = context.PostWithTagsCount.ToList();
            foreach(var item in posts)
            {
                var itemCount = item.Count;
            }

        }
    }
}
