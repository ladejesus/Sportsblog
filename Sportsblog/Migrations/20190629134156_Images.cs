using Microsoft.EntityFrameworkCore.Migrations;

namespace Sportsblog.Migrations
{
    public partial class Images : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Sports",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Sports",
                keyColumn: "SportId",
                keyValue: 1,
                column: "ImageUrl",
                value: "/CSS/Images/MessiRonaldo.jpg");

            migrationBuilder.UpdateData(
                table: "Sports",
                keyColumn: "SportId",
                keyValue: 2,
                column: "ImageUrl",
                value: "/CSS/Images/Jordan.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Sports");
        }
    }
}
