namespace Web.Helper
{
    public static class ImageHelper
    {
        public static string UploadImage(IFormFile PhotoUrl, IWebHostEnvironment environment)
        {
            string path = "/images/" + Guid.NewGuid() + PhotoUrl.FileName;
            using (FileStream fileStream = new FileStream(environment.WebRootPath + path, FileMode.Create))
            {
                PhotoUrl.CopyTo(fileStream);
            }
            return path;
        }
    }
}
