using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogProject.Migrations
{
    public partial class BlogModel_change : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryName",
                table: "Blogs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CategoryName",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
