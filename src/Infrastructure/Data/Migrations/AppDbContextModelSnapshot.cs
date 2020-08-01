﻿// <auto-generated />
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ApplicationCore.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Name = "Mobiles",
                            ThumbnailUrl = "/images/categories/mobiles.jpg"
                        },
                        new
                        {
                            CategoryId = 2,
                            Name = "Notebooks",
                            ThumbnailUrl = "/images/categories/notebooks.jpg"
                        },
                        new
                        {
                            CategoryId = 3,
                            Name = "Tablets",
                            ThumbnailUrl = "/images/categories/tablets.jpg"
                        },
                        new
                        {
                            CategoryId = 4,
                            Name = "Computers",
                            ThumbnailUrl = "/images/categories/computers.jpg"
                        },
                        new
                        {
                            CategoryId = 5,
                            Name = "Whatches",
                            ThumbnailUrl = "/images/categories/whatches.jpg"
                        },
                        new
                        {
                            CategoryId = 6,
                            Name = "Accessories",
                            ThumbnailUrl = "/images/categories/accessories.jpg"
                        });
                });

            modelBuilder.Entity("ApplicationCore.Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            Description = "Apple iOS, Display 6.5\" OLED(1242x2688), Apple A13 Bionic, RAM 4 GB, Capasity 256 GB, Camera 12 Mp, Battery 3969 mAh, 1 SIM Color: Dark Green",
                            ImageThumbnailUrl = "/images/products/mobiles/phone-11-pro-max/phone-11-pro-max-dark-green-thumbnail.jpg",
                            ImageUrl = "/images/products/mobiles/phone-11-pro-max/phone-11-pro-max-dark-green.jpg",
                            Name = "Phone 11 Pro Max",
                            Price = 1099m
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1,
                            Description = "Apple iOS, Display 5.8\" OLED(1125x2436), Apple A13 Bionic, RAM 4 GB, Capasity 64 GB, Camera 12 Mp, Battery 3190 mAh, 1 SIM, Color: Gold",
                            ImageThumbnailUrl = "/images/products/mobiles/phone-11-pro/phone-11-pro-gold-thumbnail.jpg",
                            ImageUrl = "/images/products/mobiles/phone-11-pro/phone-11-pro-gold.jpg",
                            Name = "Phone 11 Pro",
                            Price = 999m
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 1,
                            Description = "Apple iOS, Display 6.1\" IPS (828x1792), Apple A13 Bionic, RAM 4 GB, Capasity 64 GB, Camera 12 Mp, Battery 3046 mAh, 1 SIM, Color: Black",
                            ImageThumbnailUrl = "/images/products/mobiles/phone-11/phone-11-black-thumbnail.jpg",
                            ImageUrl = "/images/products/mobiles/phone-11/pphone-11-black.jpg",
                            Name = "Phone 11",
                            Price = 699m
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 2,
                            Description = "13.3\" 2560 x 1600 IPS, Intel Core i5 8257U 1400 MHz, 8 GB, SSD 256 GB, Graphics: integrated, Mac OS, Color: Silver",
                            ImageThumbnailUrl = "/images/products/notebooks/pro/notebook-pro-silver-thumbnail.jpg",
                            ImageUrl = "/images/products/notebooks/pro/notebook-pro-silver.jpg",
                            Name = "Notebook Pro",
                            Price = 1299m
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 2,
                            Description = "13.3\" 2560 x 1600 IPS, Intel Core i3 1000G4 1100 MHz, 8 GB, SSD 256 GB, Graphics: integrated, Mac OS, Color: Silver",
                            ImageThumbnailUrl = "/images/products/notebooks/air/notebook-air-space-gary-thumbnail.jpg",
                            ImageUrl = "/images/products/notebooks/air/notebook-air-space-gary.jpg",
                            Name = "Notebook Air",
                            Price = 899m
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 3,
                            Description = "12.9\" IPS (2732x2048), iPadOS, Apple A12Z Bionic, RAM 6 GB, Capasity 128 GB, Color: Gray",
                            ImageThumbnailUrl = "/images/products/tablets/pro/tablet-pro-gray-thumbnail.jpg",
                            ImageUrl = "/images/products/tablets/pro/tablet-pro-gray.jpg",
                            Name = "Tablet Pro",
                            Price = 999m
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 3,
                            Description = "7.9\" IPS (2048x1536), iOS, Apple A12 Bionic, RAM 3 GB, Capasity 64 GB, Color: Space Gray",
                            ImageThumbnailUrl = "/images/products/tablets/mini/tablet-mini-space-gray-thumbnail.jpg",
                            ImageUrl = "/images/products/tablets/mini/tablet-mini-space-gray.jpg",
                            Name = "Tablet Mini",
                            Price = 399m
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryId = 4,
                            Description = "CPU 8-core Intel Xeon W 3.2GHz, RAM DDR4 ECC 32 GB, Storage 1 TB, Graphics: Radeon Pro Vega 56 with 8GB of HBM2 memory",
                            ImageThumbnailUrl = "/images/products/computers/pro/computer-pro-tumbnail.jpg",
                            ImageUrl = "/images/products/computers/pro/computer-pro.jpg",
                            Name = "Computer Pro",
                            Price = 5999m
                        },
                        new
                        {
                            ProductId = 9,
                            CategoryId = 4,
                            Description = "CPU Intel Core i5 8500B 3000 MHz, RAM DDR4 SO-DIMM 8 GB, Storage SSD 512 GB, Graphics: Intel UHD Graphics 630",
                            ImageThumbnailUrl = "/images/products/computers/mini/computer-mini-gray-thumbnail.jpg",
                            ImageUrl = "/images/products/computers/mini/computer-mini-gray.jpg",
                            Name = "Computer Mini",
                            Price = 799m
                        },
                        new
                        {
                            ProductId = 10,
                            CategoryId = 5,
                            Description = "Support iOS, Display AMOLED 1.57\" (324x394, sensor), pedometer, pulsometer",
                            ImageThumbnailUrl = "/images/products/whatches/whatch-5/whatch-5-space-gray-thumbnail.jpg",
                            ImageUrl = "/images/products/whatches/whatch-5/whatch-5-space-gray.jpg",
                            Name = "Whatch 5",
                            Price = 399m
                        },
                        new
                        {
                            ProductId = 11,
                            CategoryId = 6,
                            Description = "In-ear headphones, Bluetooth 5.0",
                            ImageThumbnailUrl = "/images/products/accessories/headphones/headphone-pro-thumbnails.jpg",
                            ImageUrl = "/images/products/accessories/headphones/headphone-pro-thumbnails.jpg",
                            Name = "Headphones Pro",
                            Price = 249m
                        });
                });

            modelBuilder.Entity("ApplicationCore.Entities.Product", b =>
                {
                    b.HasOne("ApplicationCore.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
