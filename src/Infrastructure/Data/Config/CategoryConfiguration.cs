using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { CategoryId = 1, Name = "Mobiles", ThumbnailUrl = "images/categories/mobiles.jpg" },
                new Category { CategoryId = 2, Name = "Notebooks", ThumbnailUrl = "images/categories/notebooks.jpg" },
                new Category { CategoryId = 3, Name = "Tablets", ThumbnailUrl = "images/categories/tablets.jpg" },
                new Category { CategoryId = 4, Name = "Computers", ThumbnailUrl = "images/categories/computers.jpg" },
                new Category { CategoryId = 5, Name = "Whatches", ThumbnailUrl = "images/categories/whatches.jpg" },
                new Category { CategoryId = 6, Name = "Accessories", ThumbnailUrl = "images/categories/accessories.jpg" });
        }
    }
}
