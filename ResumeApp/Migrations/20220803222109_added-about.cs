using Microsoft.EntityFrameworkCore.Migrations;

namespace ResumeApp.Migrations
{
    public partial class addedabout : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DynamicTitle",
                table: "Homes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StaticTitle",
                table: "Homes",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DynamicTitle",
                table: "Homes");

            migrationBuilder.DropColumn(
                name: "StaticTitle",
                table: "Homes");
        }
    }
}
