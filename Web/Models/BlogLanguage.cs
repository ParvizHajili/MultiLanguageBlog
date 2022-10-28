namespace Web.Models
{
    public class BlogLanguage : BaseModel
    {
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
        public string Language { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
