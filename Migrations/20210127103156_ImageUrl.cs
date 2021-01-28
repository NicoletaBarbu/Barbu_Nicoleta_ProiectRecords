using Microsoft.EntityFrameworkCore.Migrations;

namespace Barbu_Nicoleta_ProiectRecords.Migrations
{
    public partial class ImageUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Record",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Record");
        }
    }
}
