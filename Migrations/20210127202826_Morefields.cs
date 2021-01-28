using Microsoft.EntityFrameworkCore.Migrations;

namespace Barbu_Nicoleta_ProiectRecords.Migrations
{
    public partial class Morefields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RecordhouseName",
                table: "Recordhouse",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Recordhouse",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Recordhouse",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Recordhouse");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Recordhouse");

            migrationBuilder.AlterColumn<string>(
                name: "RecordhouseName",
                table: "Recordhouse",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
