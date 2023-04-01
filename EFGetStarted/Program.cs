using System;
using System.Linq;
using EFGetStarted;

using var db = new BloggingContext();

// Note: This sample requires the database to be created before running.
Console.WriteLine($"Database path: {db.DbPath267}.");

// Create
Console.WriteLine("Inserting a new blog");
db.Add(new Blog { Url267 = "http://blogs.msdn.com/adonet" });
db.SaveChanges();

// Read
Console.WriteLine("Querying for a blog");
var blog267 = db.Blogs267
    .OrderBy(b => b.BlogId267)
    .First();
Console.WriteLine(blog267.Url267);

// Update
Console.WriteLine("Updating the blog and adding a post");
blog267.Url267 = "https://devblogs.microsoft.com/dotnet";
blog267.Posts267.Add(
    new Post { Title267 = "Hello World", Content267 = "I wrote an app using EF Core!" });
db.SaveChanges();

// Delete
Console.WriteLine("Delete the blog");
db.Remove(blog267);
db.SaveChanges();
