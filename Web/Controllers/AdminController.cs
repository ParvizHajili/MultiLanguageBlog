using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
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
                BlogLanguages=blogs
            };
            return View(blogViewModel);
        }

        public IActionResult CreateBlog()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateBlog(Blog blog,List<string> Title,List<string> Content,List<string> Language)
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
            return RedirectToAction("BlogList","Admin");
        }

        [HttpGet]
        public IActionResult EditBlog()
        {
            var blogs = _context.Blogs.ToList();
            var blogLanguages = _context.BlogLanguages.ToList();
            BlogViewModel blogViewModel = new()
            {
                BlogLanguages=blogLanguages,
                Blogs=blogs
            };
            return View(blogViewModel);
        }

        [HttpPost]
        public IActionResult EditBlog(String a)
        {
            return View();
        }
    }
}
