//Módulo 1
//using System;
//using Blog.Models;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Logging;

//namespace Blog.Data
//{
//    public class BlogDataContext : DbContext
//    {
//        public DbSet<Category> Categories { get; set; }
//        public DbSet<Post> Posts { get; set; }
//        public DbSet<User> Users { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            optionsBuilder.UseSqlServer("Server=localhost;Database=Blog;Integrated Security=True;");
//            optionsBuilder.LogTo(Console.WriteLine);
//        }
//    }
//}

//Módulo 2
using System;
using Blog.Data.Mappings;
using Blog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Blog.Data
{
    public class BlogDataContext : DbContext
    {   
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<PostWithTagsCount> PostWithTagsCount { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=Module3FluentBlog;Integrated Security=True;");
            optionsBuilder.LogTo(Console.WriteLine);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new PostMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.Entity<PostWithTagsCount>(x =>
            {
                x.ToSqlQuery(@"SELECT
                    [Title] AS [Name],
                    SELECT COUNT([Id]) FROM [Tags] WHERE [PostId] = [Id] AS [Count]
                    FROM [Posts]");
            });
        }
    }
}
