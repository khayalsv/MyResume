using Microsoft.EntityFrameworkCore.Migrations;

namespace ResumeApp.Migrations
{
    public partial class addportt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DynamicTitle",
                table: "Homes");

            migrationBuilder.RenameColumn(
                name: "StaticTitle",
                table: "Homes",
                newName: "Title");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Homes",
                newName: "StaticTitle");

            migrationBuilder.AddColumn<string>(
                name: "DynamicTitle",
                table: "Homes",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
