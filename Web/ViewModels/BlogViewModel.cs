using Web.Models;

namespace Web.ViewModels
{
    public class BlogViewModel
    {
        public List<Blog> Blogs { get; set; }
        public List<BlogLanguage> BlogLanguages { get; set; }
    }
}
