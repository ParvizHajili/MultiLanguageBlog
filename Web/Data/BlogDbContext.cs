using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Web.Models;

namespace Web.Data
{
    public class BlogDbContext:DbContext
    {
        public BlogDbContext(DbContextOptions options):base (options)
        {

        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogLanguage> BlogLanguages { get; set; }
    }
}
