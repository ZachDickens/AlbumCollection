using Microsoft.EntityFrameworkCore.Migrations;

namespace AlbumCollection.Migrations
{
    public partial class AddedImgPath : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgPath",
                table: "Albums",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 1,
                column: "ImgPath",
                value: "~/Images/HybridTheoryBackground");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 2,
                column: "ImgPath",
                value: "~/Images/MeteoraBackground");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 3,
                column: "ImgPath",
                value: "~/Images/MinutestoMidnightBackground");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgPath",
                table: "Albums");
        }
    }
}
