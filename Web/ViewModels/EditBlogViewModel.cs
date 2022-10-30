using Web.Models;

namespace Web.ViewModels
{
    public class EditBlogViewModel
    {
        public Blog Blog { get; set; }
        public List<BlogLanguage> BlogLanguages { get; set; }
    }
}
