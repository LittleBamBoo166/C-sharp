using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace EFGetStarted
{
    public class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs267 { get; set; }
        public DbSet<Post> Posts267 { get; set; }

        public string DbPath267 { get; }

        public BloggingContext()
        {
            var folder267 = Environment.SpecialFolder.LocalApplicationData;
            var path267 = Environment.GetFolderPath(folder267);
            DbPath267 = System.IO.Path.Join(path267, "blogging.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath267}");
    }

    public class Blog
    {
        public int BlogId267 { get; set; }
        public string Url267 { get; set; }

        public List<Post> Posts267 { get; } = new();
    }

    public class Post
    {
        public int PostId267 { get; set; }
        public string Title267 { get; set; }
        public string Content267 { get; set; }

        public int BlogId267 { get; set; }
        public Blog Blog { get; set; }
    }
}
