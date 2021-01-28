using Microsoft.EntityFrameworkCore.Migrations;

namespace Barbu_Nicoleta_ProiectRecords.Migrations
{
    public partial class Genre23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecordGenre");

            migrationBuilder.AddColumn<int>(
                name: "GenreID",
                table: "Record",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GenreID",
                table: "Record");

            migrationBuilder.CreateTable(
                name: "RecordGenre",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenreID = table.Column<int>(type: "int", nullable: false),
                    RecordID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecordGenre", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RecordGenre_Genre_GenreID",
                        column: x => x.GenreID,
                        principalTable: "Genre",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecordGenre_Record_RecordID",
                        column: x => x.RecordID,
                        principalTable: "Record",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RecordGenre_GenreID",
                table: "RecordGenre",
                column: "GenreID");

            migrationBuilder.CreateIndex(
                name: "IX_RecordGenre_RecordID",
                table: "RecordGenre",
                column: "RecordID");
        }
    }
}
