using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Web.Data;
using Web.Models;
using Web.ViewModels;

namespace Web.Controllers
{
    public class AdminController : Controller
    {
        private readonly BlogDbContext _context;

        public AdminController(BlogDbContext dbContext)
        {
            _context = dbContext;
        }

        public IActionResult BlogList()
        {
            var blogs = _context.BlogLanguages.Include(x => x.Blog).ToList();

            BlogViewModel blogViewModel = new()
            {
                BlogLanguages = blogs
            };
            return View(blogViewModel);
        }

        public IActionResult GetLanguage(string language)
        {
            var blogs = _context.BlogLanguages.Where(x => x.Language == language).ToList();

            return View(blogs);
        }

        public IActionResult CreateBlog()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateBlog(Blog blog, List<string> Title, List<string> Content, List<string> Language)
        {
            _context.Blogs.Add(blog);
            _context.SaveChanges();
            for (int i = 0; i < Title.Count; i++)
            {
                BlogLanguage blogLanguage = new()
                {
                    Title = Title[i],
                    Content = Content[i],
                    Language = Language[i],
                    BlogId = blog.Id

                };
                _context.BlogLanguages.Add(blogLanguage);
                _context.SaveChanges();
            }
            return RedirectToAction("BlogList", "Admin");
        }

        [HttpGet]
        public IActionResult EditBlog(int id)
        {
            var blog = _context.Blogs.FirstOrDefault(x => x.Id == id);
            var blogLanguages = _context.BlogLanguages.Where(x => x.Blog.Id == id).ToList();
            EditBlogViewModel editViewModel = new()
            {
                BlogLanguages = blogLanguages,
                Blog = blog
            };
            return View(editViewModel);
        }

        [HttpPost]
        public IActionResult EditBlog(Blog blog, int blogId, List<string> title, List<string> content, List<int> languageId, List<string> language)
        {
            blog.PhotoUrl = "pythonA.jpg";
            _context.Blogs.Update(blog);
            _context.SaveChanges();

            for (int i = 0; i < title.Count; i++)
            {
                BlogLanguage blogLanguage = new()
                {
                    Id = languageId[i],
                    BlogId=blogId,
                    Title=title[i],
                    Content = content[i],
                    Language = language[i]
                };
                _context.BlogLanguages.Update(blogLanguage);
                _context.SaveChanges();
            }
            return RedirectToAction("BlogList", "Admin");
        }
    }
}
