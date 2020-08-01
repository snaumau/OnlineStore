using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data.Migrations
{
    public partial class ShoppingCartAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "ThumbnailUrl",
                value: "/images/categories/mobiles.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "ThumbnailUrl",
                value: "/images/categories/notebooks.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "ThumbnailUrl",
                value: "/images/categories/tablets.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "ThumbnailUrl",
                value: "/images/categories/computers.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "ThumbnailUrl",
                value: "/images/categories/whatches.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                column: "ThumbnailUrl",
                value: "/images/categories/accessories.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "/images/products/mobiles/phone-11-pro-max/phone-11-pro-max-dark-green-thumbnail.jpg", "/images/products/mobiles/phone-11-pro-max/phone-11-pro-max-dark-green.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "/images/products/mobiles/phone-11-pro/phone-11-pro-gold-thumbnail.jpg", "/images/products/mobiles/phone-11-pro/phone-11-pro-gold.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "/images/products/mobiles/phone-11/phone-11-black-thumbnail.jpg", "/images/products/mobiles/phone-11/pphone-11-black.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "/images/products/notebooks/pro/notebook-pro-silver-thumbnail.jpg", "/images/products/notebooks/pro/notebook-pro-silver.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "/images/products/notebooks/air/notebook-air-space-gary-thumbnail.jpg", "/images/products/notebooks/air/notebook-air-space-gary.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "/images/products/tablets/pro/tablet-pro-gray-thumbnail.jpg", "/images/products/tablets/pro/tablet-pro-gray.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "/images/products/tablets/mini/tablet-mini-space-gray-thumbnail.jpg", "/images/products/tablets/mini/tablet-mini-space-gray.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "/images/products/computers/pro/computer-pro-tumbnail.jpg", "/images/products/computers/pro/computer-pro.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "/images/products/computers/mini/computer-mini-gray-thumbnail.jpg", "/images/products/computers/mini/computer-mini-gray.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "/images/products/whatches/whatch-5/whatch-5-space-gray-thumbnail.jpg", "/images/products/whatches/whatch-5/whatch-5-space-gray.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "/images/products/accessories/headphones/headphone-pro-thumbnails.jpg", "/images/products/accessories/headphones/headphone-pro-thumbnails.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "ThumbnailUrl",
                value: "images/categories/mobiles.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "ThumbnailUrl",
                value: "images/categories/notebooks.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "ThumbnailUrl",
                value: "images/categories/tablets.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "ThumbnailUrl",
                value: "images/categories/computers.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "ThumbnailUrl",
                value: "images/categories/whatches.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                column: "ThumbnailUrl",
                value: "images/categories/accessories.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "images/products/mobiles/phone-11-pro-max/phone-11-pro-max-dark-green-thumbnail.jpg", "images/products/mobiles/phone-11-pro-max/phone-11-pro-max-dark-green.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "images/products/mobiles/phone-11-pro/phone-11-pro-gold-thumbnail.jpg", "images/products/mobiles/phone-11-pro/phone-11-pro-gold.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "images/products/mobiles/phone-11/phone-11-black-thumbnail.jpg", "images/products/mobiles/phone-11/pphone-11-black.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "images/products/mobiles/phone-11/notebook-pro-silver-thumbnail.jpg", "images/products/notebooks/pro/notebook-pro-silver.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "images/products/notebooks/air/notebook-air-space-gary-thumbnail.jpg", "images/products/notebooks/air/notebook-air-space-gary.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "images/products/tablets/pro/tablet-pro-gray-thumbnail.jpg", "images/products/tablets/pro/tablet-pro-gray.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "images/products/tablets/mini/tablet-mini-space-gray-thumbnail.jpg", "images/products/tablets/mini/tablet-mini-space-gray.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "images/products/computers/pro/computer-pro-tumbnail.jpg", "images/products/computers/pro/computer-pro.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "images/products/computers/mini/computer-mini-gray-thumbnail.jpg", "images/products/computers/mini/computer-mini-gray.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "images/products/whatches/whatch-5/whatch-5-space-gray-thumbnail.jpg", "images/products/whatches/whatch-5/whatch-5-space-gray.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "images/products/accessories/headphones/headphone-pro-thumbnails.jpg", "images/products/accessories/headphones/headphone-pro-thumbnails.jpg" });
        }
    }
}
