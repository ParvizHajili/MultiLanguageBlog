namespace Web.Models
{
    public class Blog : BaseModel
    {
        public string PhotoUrl { get; set; }
        public List<BlogLanguage> BlogLanguages { get; set; }
    }
}
