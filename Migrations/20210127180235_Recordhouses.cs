using Microsoft.EntityFrameworkCore.Migrations;

namespace Barbu_Nicoleta_ProiectRecords.Migrations
{
    public partial class Recordhouses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RecordhouseID",
                table: "Record",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Recordhouse",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecordhouseName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recordhouse", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Record_RecordhouseID",
                table: "Record",
                column: "RecordhouseID");

            migrationBuilder.AddForeignKey(
                name: "FK_Record_Recordhouse_RecordhouseID",
                table: "Record",
                column: "RecordhouseID",
                principalTable: "Recordhouse",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Record_Recordhouse_RecordhouseID",
                table: "Record");

            migrationBuilder.DropTable(
                name: "Recordhouse");

            migrationBuilder.DropIndex(
                name: "IX_Record_RecordhouseID",
                table: "Record");

            migrationBuilder.DropColumn(
                name: "RecordhouseID",
                table: "Record");
        }
    }
}
