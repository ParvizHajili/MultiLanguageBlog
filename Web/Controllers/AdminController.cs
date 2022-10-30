using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Security.Cryptography;
using Web.Data;
using Web.Helper;
using Web.Models;
using Web.ViewModels;

namespace Web.Controllers
{
    public class AdminController : Controller
    {
        private readonly BlogDbContext _context;
        private readonly IWebHostEnvironment _environment;
        public AdminController(BlogDbContext dbContext, IWebHostEnvironment environment)
        {
            _context = dbContext;
            _environment = environment;
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
        public async Task<IActionResult> CreateBlog(Blog blog, List<string> Title, List<string> Content, List<string> Language, IFormFile PhotoUrl)
        {
            blog.PhotoUrl = ImageHelper.UploadImage(PhotoUrl, _environment);
            blog.CreatedDate = DateTime.Now;

            _context.Blogs.Add(blog);
            _context.SaveChanges();
            for (int i = 0; i < Title.Count; i++)
            {
                BlogLanguage blogLanguage = new()
                {
                    Title = Title[i],
                    Content = Content[i],
                    Language = Language[i],
                    BlogId = blog.Id,
                    CreatedDate=DateTime.Now
                };
                _context.BlogLanguages.Add(blogLanguage);
                _context.SaveChanges();
            }
            return RedirectToAction("BlogList", "Admin");
        }

        [HttpGet]
        public IActionResult EditBlog(int id)
        {
            EditBlogViewModel editViewModel = new()
            {
                BlogLanguages = _context.BlogLanguages.Where(x => x.Blog.Id == id).ToList(),
                Blog = _context.Blogs.FirstOrDefault(x => x.Id == id)
            };
            return View(editViewModel);
        }

        [HttpPost]
        public IActionResult EditBlog(Blog blog, int blogId, List<string> title, List<string> content, List<int> languageId, List<string> language,IFormFile PhotoUrl)
        {
            blog.PhotoUrl = ImageHelper.UploadImage(PhotoUrl,_environment);
            blog.UpdatedDate = DateTime.Now;

            _context.Blogs.Update(blog);
            _context.SaveChanges();

            for (int i = 0; i < title.Count; i++)
            {
                BlogLanguage blogLanguage = new()
                {
                    Id = languageId[i],
                    BlogId = blogId,
                    Title = title[i],
                    Content = content[i],
                    Language = language[i],
                    UpdatedDate = DateTime.Now
                };
                _context.BlogLanguages.Update(blogLanguage);
                _context.SaveChanges();
            }
            return RedirectToAction("BlogList", "Admin");
        }

        [HttpGet]
        public IActionResult DeleteBlog(int id)
        {
            var product = _context.Blogs.FirstOrDefault(x => x.Id == id);

            return View(product);
        }

        [HttpPost]
        public IActionResult DeleteBlog(Blog blog)
        {
            var result = _context.Blogs.FirstOrDefault(x => x.Id == blog.Id);
            _context.Blogs.Remove(result);
            _context.SaveChanges();

            return RedirectToAction("BlogList","Admin");
        }
    }
}
