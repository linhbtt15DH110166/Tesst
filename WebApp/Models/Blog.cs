using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Blog
    {
        public int BlogID { get; set; }
        public string Name { get; set; }
    }
    public class BloggingContext : DbContext
    {
        public BloggingContext() : base("Default")
        { }
        public DbSet<Blog> Blogs { get; set; }
    }
}