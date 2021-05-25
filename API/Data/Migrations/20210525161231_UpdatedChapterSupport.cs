using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class UpdatedChapterSupport : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MangaCollectionId",
                table: "Mangas",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MangaCollectionId",
                table: "MangaChapters",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MangaId",
                table: "MangaChapters",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MangaCollections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MangaCollections", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mangas_MangaCollectionId",
                table: "Mangas",
                column: "MangaCollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_MangaChapters_MangaCollectionId",
                table: "MangaChapters",
                column: "MangaCollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_MangaChapters_MangaId",
                table: "MangaChapters",
                column: "MangaId");

            migrationBuilder.AddForeignKey(
                name: "FK_MangaChapters_MangaCollections_MangaCollectionId",
                table: "MangaChapters",
                column: "MangaCollectionId",
                principalTable: "MangaCollections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MangaChapters_Mangas_MangaId",
                table: "MangaChapters",
                column: "MangaId",
                principalTable: "Mangas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mangas_MangaCollections_MangaCollectionId",
                table: "Mangas",
                column: "MangaCollectionId",
                principalTable: "MangaCollections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MangaChapters_MangaCollections_MangaCollectionId",
                table: "MangaChapters");

            migrationBuilder.DropForeignKey(
                name: "FK_MangaChapters_Mangas_MangaId",
                table: "MangaChapters");

            migrationBuilder.DropForeignKey(
                name: "FK_Mangas_MangaCollections_MangaCollectionId",
                table: "Mangas");

            migrationBuilder.DropTable(
                name: "MangaCollections");

            migrationBuilder.DropIndex(
                name: "IX_Mangas_MangaCollectionId",
                table: "Mangas");

            migrationBuilder.DropIndex(
                name: "IX_MangaChapters_MangaCollectionId",
                table: "MangaChapters");

            migrationBuilder.DropIndex(
                name: "IX_MangaChapters_MangaId",
                table: "MangaChapters");

            migrationBuilder.DropColumn(
                name: "MangaCollectionId",
                table: "Mangas");

            migrationBuilder.DropColumn(
                name: "MangaCollectionId",
                table: "MangaChapters");

            migrationBuilder.DropColumn(
                name: "MangaId",
                table: "MangaChapters");
        }
    }
}
