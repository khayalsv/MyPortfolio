using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccsessLayer.Migrations
{
    public partial class mig_home_iage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Homes",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Homes");
        }
    }
}
