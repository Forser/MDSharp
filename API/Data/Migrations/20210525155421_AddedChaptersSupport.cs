using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class AddedChaptersSupport : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MangaChapters",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Result = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MangaChapters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChapterData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ChapterId = table.Column<string>(type: "TEXT", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: true),
                    MangaChapterId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChapterData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChapterData_MangaChapters_MangaChapterId",
                        column: x => x.MangaChapterId,
                        principalTable: "MangaChapters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChapterRelationship",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RelationshipId = table.Column<string>(type: "TEXT", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: true),
                    MangaChapterId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChapterRelationship", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChapterRelationship_MangaChapters_MangaChapterId",
                        column: x => x.MangaChapterId,
                        principalTable: "MangaChapters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChapterAttributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Volume = table.Column<string>(type: "TEXT", nullable: true),
                    Chapter = table.Column<string>(type: "TEXT", nullable: true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    TranslatedLanguage = table.Column<string>(type: "TEXT", nullable: true),
                    Hash = table.Column<string>(type: "TEXT", nullable: true),
                    PublishAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Version = table.Column<int>(type: "INTEGER", nullable: false),
                    ChapterDataId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChapterAttributes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChapterAttributes_ChapterData_ChapterDataId",
                        column: x => x.ChapterDataId,
                        principalTable: "ChapterData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DataCollection",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FileName = table.Column<string>(type: "TEXT", nullable: true),
                    ChapterAttributesId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataCollection", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataCollection_ChapterAttributes_ChapterAttributesId",
                        column: x => x.ChapterAttributesId,
                        principalTable: "ChapterAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DataSaverCollection",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FileName = table.Column<string>(type: "TEXT", nullable: true),
                    ChapterAttributesId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataSaverCollection", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataSaverCollection_ChapterAttributes_ChapterAttributesId",
                        column: x => x.ChapterAttributesId,
                        principalTable: "ChapterAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChapterAttributes_ChapterDataId",
                table: "ChapterAttributes",
                column: "ChapterDataId");

            migrationBuilder.CreateIndex(
                name: "IX_ChapterData_MangaChapterId",
                table: "ChapterData",
                column: "MangaChapterId");

            migrationBuilder.CreateIndex(
                name: "IX_ChapterRelationship_MangaChapterId",
                table: "ChapterRelationship",
                column: "MangaChapterId");

            migrationBuilder.CreateIndex(
                name: "IX_DataCollection_ChapterAttributesId",
                table: "DataCollection",
                column: "ChapterAttributesId");

            migrationBuilder.CreateIndex(
                name: "IX_DataSaverCollection_ChapterAttributesId",
                table: "DataSaverCollection",
                column: "ChapterAttributesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChapterRelationship");

            migrationBuilder.DropTable(
                name: "DataCollection");

            migrationBuilder.DropTable(
                name: "DataSaverCollection");

            migrationBuilder.DropTable(
                name: "ChapterAttributes");

            migrationBuilder.DropTable(
                name: "ChapterData");

            migrationBuilder.DropTable(
                name: "MangaChapters");
        }
    }
}
