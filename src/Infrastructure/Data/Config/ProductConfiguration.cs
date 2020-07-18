using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    ProductId = 1,
                    CategoryId = 1,
                    Name = "Phone 11 Pro Max",
                    Description = "Apple iOS, Display 6.5\" OLED(1242x2688), Apple A13 Bionic, RAM 4 GB, Capasity 256 GB, Camera 12 Mp, Battery 3969 mAh, 1 SIM Color: Dark Green",
                    Price = 1099M,
                    ImageUrl = "images/products/mobiles/phone-11-pro-max/phone-11-pro-max-dark-green.jpg",
                    ImageThumbnailUrl = "images/products/mobiles/phone-11-pro-max/phone-11-pro-max-dark-green-thumbnail.jpg",
                },
                new Product
                {
                    ProductId = 2,
                    CategoryId = 1,
                    Name = "Phone 11 Pro",
                    Description = "Apple iOS, Display 5.8\" OLED(1125x2436), Apple A13 Bionic, RAM 4 GB, Capasity 64 GB, Camera 12 Mp, Battery 3190 mAh, 1 SIM, Color: Gold", 
                    Price = 999M,
                    ImageUrl = "images/products/mobiles/phone-11-pro/phone-11-pro-gold.jpg",
                    ImageThumbnailUrl = "images/products/mobiles/phone-11-pro/phone-11-pro-gold-thumbnail.jpg",
                },
                new Product
                {
                    ProductId = 3,
                    CategoryId = 1,
                    Name = "Phone 11",
                    Description = "Apple iOS, Display 6.1\" IPS (828x1792), Apple A13 Bionic, RAM 4 GB, Capasity 64 GB, Camera 12 Mp, Battery 3046 mAh, 1 SIM, Color: Black",
                    Price = 699M,
                    ImageUrl = "images/products/mobiles/phone-11/pphone-11-black.jpg",
                    ImageThumbnailUrl = "images/products/mobiles/phone-11/phone-11-black-thumbnail.jpg",
                },
                new Product
                {
                    ProductId = 4,
                    CategoryId = 2,
                    Name = "Notebook Pro",
                    Description = "13.3\" 2560 x 1600 IPS, Intel Core i5 8257U 1400 MHz, 8 GB, SSD 256 GB, Graphics: integrated, Mac OS, Color: Silver",
                    Price = 1299M,
                    ImageUrl = "images/products/notebooks/pro/notebook-pro-silver.jpg",
                    ImageThumbnailUrl = "images/products/mobiles/phone-11/notebook-pro-silver-thumbnail.jpg",
                },
                new Product
                {
                    ProductId = 5,
                    CategoryId = 2,
                    Name = "Notebook Air",
                    Description = "13.3\" 2560 x 1600 IPS, Intel Core i3 1000G4 1100 MHz, 8 GB, SSD 256 GB, Graphics: integrated, Mac OS, Color: Silver",
                    Price = 899M,
                    ImageUrl = "images/products/notebooks/air/notebook-air-space-gary.jpg",
                    ImageThumbnailUrl = "images/products/notebooks/air/notebook-air-space-gary-thumbnail.jpg",
                },
                new Product
                {
                    ProductId = 6,
                    CategoryId = 3,
                    Name = "Tablet Pro",
                    Description = "12.9\" IPS (2732x2048), iPadOS, Apple A12Z Bionic, RAM 6 GB, Capasity 128 GB, Color: Gray",
                    Price = 999M,
                    ImageUrl = "images/products/tablets/pro/tablet-pro-gray.jpg",
                    ImageThumbnailUrl = "images/products/tablets/pro/tablet-pro-gray-thumbnail.jpg",
                },
                new Product
                {
                    ProductId = 7,
                    CategoryId = 3,
                    Name = "Tablet Mini",
                    Description = "7.9\" IPS (2048x1536), iOS, Apple A12 Bionic, RAM 3 GB, Capasity 64 GB, Color: Space Gray",
                    Price = 399M,
                    ImageUrl = "images/products/tablets/mini/tablet-mini-space-gray.jpg",
                    ImageThumbnailUrl = "images/products/tablets/mini/tablet-mini-space-gray-thumbnail.jpg",
                },
                new Product
                {
                    ProductId = 8,
                    CategoryId = 4,
                    Name = "Computer Pro",
                    Description = "CPU 8-core Intel Xeon W 3.2GHz, RAM DDR4 ECC 32 GB, Storage 1 TB, Graphics: Radeon Pro Vega 56 with 8GB of HBM2 memory",
                    Price = 5999M,
                    ImageUrl = "images/products/computers/pro/computer-pro.jpg",
                    ImageThumbnailUrl = "images/products/computers/pro/computer-pro-tumbnail.jpg",
                },
                new Product
                {
                    ProductId = 9,
                    CategoryId = 4,
                    Name = "Computer Mini",
                    Description = "CPU Intel Core i5 8500B 3000 MHz, RAM DDR4 SO-DIMM 8 GB, Storage SSD 512 GB, Graphics: Intel UHD Graphics 630",
                    Price = 799M,
                    ImageUrl = "images/products/computers/mini/computer-mini-gray.jpg",
                    ImageThumbnailUrl = "images/products/computers/mini/computer-mini-gray-thumbnail.jpg",
                },
                new Product
                {
                    ProductId = 10,
                    CategoryId = 5,
                    Name = "Whatch 5",
                    Description = "Support iOS, Display AMOLED 1.57\" (324x394, sensor), pedometer, pulsometer",
                    Price = 399M,
                    ImageUrl = "images/products/whatches/whatch-5/whatch-5-space-gray.jpg",
                    ImageThumbnailUrl = "images/products/whatches/whatch-5/whatch-5-space-gray-thumbnail.jpg",
                },
                new Product
                {
                    ProductId = 11,
                    CategoryId = 6,
                    Name = "Headphones Pro",
                    Description = "In-ear headphones, Bluetooth 5.0",
                    Price = 249M,
                    ImageUrl = "images/products/accessories/headphones/headphone-pro-thumbnails.jpg",
                    ImageThumbnailUrl = "images/products/accessories/headphones/headphone-pro-thumbnails.jpg",
                });
        }
    }
}
