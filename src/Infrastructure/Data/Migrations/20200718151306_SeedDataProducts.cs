using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data.Migrations
{
    public partial class SeedDataProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Apple iOS, Display 6.5\" OLED(1242x2688), Apple A13 Bionic, RAM 4 GB, Capasity 256 GB, Camera 12 Mp, Battery 3969 mAh, 1 SIM Color: Dark Green", "images/products/mobiles/phone-11-pro-max/phone-11-pro-max-dark-green-thumbnail.jpg", "images/products/mobiles/phone-11-pro-max/phone-11-pro-max-dark-green.jpg", "Phone 11 Pro Max", 1099m },
                    { 2, 1, "Apple iOS, Display 5.8\" OLED(1125x2436), Apple A13 Bionic, RAM 4 GB, Capasity 64 GB, Camera 12 Mp, Battery 3190 mAh, 1 SIM, Color: Gold", "images/products/mobiles/phone-11-pro/phone-11-pro-gold-thumbnail.jpg", "images/products/mobiles/phone-11-pro/phone-11-pro-gold.jpg", "Phone 11 Pro", 999m },
                    { 3, 1, "Apple iOS, Display 6.1\" IPS (828x1792), Apple A13 Bionic, RAM 4 GB, Capasity 64 GB, Camera 12 Mp, Battery 3046 mAh, 1 SIM, Color: Black", "images/products/mobiles/phone-11/phone-11-black-thumbnail.jpg", "images/products/mobiles/phone-11/pphone-11-black.jpg", "Phone 11", 699m },
                    { 4, 2, "13.3\" 2560 x 1600 IPS, Intel Core i5 8257U 1400 MHz, 8 GB, SSD 256 GB, Graphics: integrated, Mac OS, Color: Silver", "images/products/mobiles/phone-11/notebook-pro-silver-thumbnail.jpg", "images/products/notebooks/pro/notebook-pro-silver.jpg", "Notebook Pro", 1299m },
                    { 5, 2, "13.3\" 2560 x 1600 IPS, Intel Core i3 1000G4 1100 MHz, 8 GB, SSD 256 GB, Graphics: integrated, Mac OS, Color: Silver", "images/products/notebooks/air/notebook-air-space-gary-thumbnail.jpg", "images/products/notebooks/air/notebook-air-space-gary.jpg", "Notebook Air", 899m },
                    { 6, 3, "12.9\" IPS (2732x2048), iPadOS, Apple A12Z Bionic, RAM 6 GB, Capasity 128 GB, Color: Gray", "images/products/tablets/pro/tablet-pro-gray-thumbnail.jpg", "images/products/tablets/pro/tablet-pro-gray.jpg", "Tablet Pro", 999m },
                    { 7, 3, "7.9\" IPS (2048x1536), iOS, Apple A12 Bionic, RAM 3 GB, Capasity 64 GB, Color: Space Gray", "images/products/tablets/mini/tablet-mini-space-gray-thumbnail.jpg", "images/products/tablets/mini/tablet-mini-space-gray.jpg", "Tablet Mini", 399m },
                    { 8, 4, "CPU 8-core Intel Xeon W 3.2GHz, RAM DDR4 ECC 32 GB, Storage 1 TB, Graphics: Radeon Pro Vega 56 with 8GB of HBM2 memory", "images/products/computers/pro/computer-pro-tumbnail.jpg", "images/products/computers/pro/computer-pro.jpg", "Computer Pro", 5999m },
                    { 9, 4, "CPU Intel Core i5 8500B 3000 MHz, RAM DDR4 SO-DIMM 8 GB, Storage SSD 512 GB, Graphics: Intel UHD Graphics 630", "images/products/computers/mini/computer-mini-gray-thumbnail.jpg", "images/products/computers/mini/computer-mini-gray.jpg", "Computer Mini", 799m },
                    { 10, 5, "Support iOS, Display AMOLED 1.57\" (324x394, sensor), pedometer, pulsometer", "images/products/whatches/whatch-5/whatch-5-space-gray-thumbnail.jpg", "images/products/whatches/whatch-5/whatch-5-space-gray.jpg", "Whatch 5", 399m },
                    { 11, 6, "In-ear headphones, Bluetooth 5.0", "images/products/accessories/headphones/headphone-pro-thumbnails.jpg", "images/products/accessories/headphones/headphone-pro-thumbnails.jpg", "Headphones Pro", 249m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);
        }
    }
}
