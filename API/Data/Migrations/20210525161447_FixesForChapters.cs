using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class FixesForChapters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MangaChapters_Mangas_MangaId",
                table: "MangaChapters");

            migrationBuilder.DropIndex(
                name: "IX_MangaChapters_MangaId",
                table: "MangaChapters");

            migrationBuilder.DropColumn(
                name: "MangaId",
                table: "MangaChapters");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MangaId",
                table: "MangaChapters",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MangaChapters_MangaId",
                table: "MangaChapters",
                column: "MangaId");

            migrationBuilder.AddForeignKey(
                name: "FK_MangaChapters_Mangas_MangaId",
                table: "MangaChapters",
                column: "MangaId",
                principalTable: "Mangas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
