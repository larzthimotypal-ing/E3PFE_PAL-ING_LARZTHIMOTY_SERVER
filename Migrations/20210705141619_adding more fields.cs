using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Migrations
{
    public partial class addingmorefields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Hobby",
                table: "AppUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Section",
                table: "AppUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hobby",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "Section",
                table: "AppUsers");
        }
    }
}
