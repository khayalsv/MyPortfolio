using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccsessLayer.Migrations
{
    public partial class addedimages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Skills",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Portfolios",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "Logo",
                table: "Details",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Blogs",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Abouts",
                newName: "ImageUrl");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Skills",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Portfolios",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Details",
                newName: "Logo");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Blogs",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Abouts",
                newName: "Image");
        }
    }
}
