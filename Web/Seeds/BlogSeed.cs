using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Web.Models;

namespace Web.Seeds
{
    public class BlogSeed : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.HasData(
                new Blog()
                {
                    Id = 1,
                    PhotoUrl="x.jpg",
                    CreatedDate=DateTime.Now,
                },
                new Blog()
                {
                     Id = 2,
                     PhotoUrl = "y.jpg",
                     CreatedDate = DateTime.Now,
                },
                new Blog()
                {
                    Id=3,
                    PhotoUrl="x.jpg",
                    CreatedDate=DateTime.Now
                }
                );
        }
    }
}
