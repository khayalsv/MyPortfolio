using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccsessLayer.Migrations
{
    public partial class added_img : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Homes",
                newName: "ImageUrl");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Homes",
                newName: "Image");
        }
    }
}
