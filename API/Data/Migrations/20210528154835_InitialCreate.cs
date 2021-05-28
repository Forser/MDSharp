using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    Version = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChapterAttributes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChaptersReads",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Result = table.Column<string>(type: "TEXT", nullable: true),
                    Data = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChaptersReads", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CoverArts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Volume = table.Column<string>(type: "TEXT", nullable: true),
                    FileName = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoverArts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Description",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Description", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Link",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AniList = table.Column<string>(type: "TEXT", nullable: true),
                    AnimePlanet = table.Column<string>(type: "TEXT", nullable: true),
                    BookWalker = table.Column<string>(type: "TEXT", nullable: true),
                    Kitsu = table.Column<string>(type: "TEXT", nullable: true),
                    MangaUpdates = table.Column<string>(type: "TEXT", nullable: true),
                    NovelUpdates = table.Column<string>(type: "TEXT", nullable: true),
                    Amazon = table.Column<string>(type: "TEXT", nullable: true),
                    EBookJP = table.Column<string>(type: "TEXT", nullable: true),
                    Raw = table.Column<string>(type: "TEXT", nullable: true),
                    MAL = table.Column<string>(type: "TEXT", nullable: true),
                    EngTL = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Link", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MangaChapters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MangaChapters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TagName",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagName", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Title",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Title", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserAttributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Version = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAttributes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChapterData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ChapterId = table.Column<string>(type: "TEXT", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: true),
                    AttributesId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChapterData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChapterData_ChapterAttributes_AttributesId",
                        column: x => x.AttributesId,
                        principalTable: "ChapterAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TagAttributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NameId = table.Column<int>(type: "INTEGER", nullable: true),
                    Group = table.Column<string>(type: "TEXT", nullable: true),
                    Version = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagAttributes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TagAttributes_TagName_NameId",
                        column: x => x.NameId,
                        principalTable: "TagName",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MangaAttributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MangaId = table.Column<string>(type: "TEXT", nullable: true),
                    titleId = table.Column<int>(type: "INTEGER", nullable: true),
                    descriptionId = table.Column<int>(type: "INTEGER", nullable: true),
                    linksId = table.Column<int>(type: "INTEGER", nullable: true),
                    isLocked = table.Column<bool>(type: "INTEGER", nullable: false),
                    originalLanguage = table.Column<string>(type: "TEXT", nullable: true),
                    lastVolume = table.Column<string>(type: "TEXT", nullable: true),
                    lastChapter = table.Column<string>(type: "TEXT", nullable: true),
                    publicationDemographic = table.Column<string>(type: "TEXT", nullable: true),
                    status = table.Column<string>(type: "TEXT", nullable: true),
                    year = table.Column<DateTime>(type: "TEXT", nullable: true),
                    contentRating = table.Column<string>(type: "TEXT", nullable: true),
                    version = table.Column<int>(type: "INTEGER", nullable: false),
                    createdAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MangaAttributes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MangaAttributes_Description_descriptionId",
                        column: x => x.descriptionId,
                        principalTable: "Description",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MangaAttributes_Link_linksId",
                        column: x => x.linksId,
                        principalTable: "Link",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MangaAttributes_Title_titleId",
                        column: x => x.titleId,
                        principalTable: "Title",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Key = table.Column<string>(type: "TEXT", nullable: true),
                    Value = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bio_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ScanlationGroups",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    LeaderId = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScanlationGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScanlationGroups_User_LeaderId",
                        column: x => x.LeaderId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: true),
                    AttributesId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserData_UserAttributes_AttributesId",
                        column: x => x.AttributesId,
                        principalTable: "UserAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MangaChapter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Result = table.Column<string>(type: "TEXT", nullable: true),
                    DataId = table.Column<int>(type: "INTEGER", nullable: true),
                    MangaChaptersId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MangaChapter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MangaChapter_ChapterData_DataId",
                        column: x => x.DataId,
                        principalTable: "ChapterData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MangaChapter_MangaChapters_MangaChaptersId",
                        column: x => x.MangaChaptersId,
                        principalTable: "MangaChapters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AltTitle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    MangaAttributesId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AltTitle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AltTitle_MangaAttributes_MangaAttributesId",
                        column: x => x.MangaAttributesId,
                        principalTable: "MangaAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MangaData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MangaAttributesId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MangaData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MangaData_MangaAttributes_MangaAttributesId",
                        column: x => x.MangaAttributesId,
                        principalTable: "MangaAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TagId = table.Column<string>(type: "TEXT", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: true),
                    AttributesId = table.Column<int>(type: "INTEGER", nullable: true),
                    MangaAttributesId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tag_MangaAttributes_MangaAttributesId",
                        column: x => x.MangaAttributesId,
                        principalTable: "MangaAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tag_TagAttributes_AttributesId",
                        column: x => x.AttributesId,
                        principalTable: "TagAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MangaUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Result = table.Column<string>(type: "TEXT", nullable: true),
                    DataId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MangaUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MangaUsers_UserData_DataId",
                        column: x => x.DataId,
                        principalTable: "UserData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserRelationship",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MangaId = table.Column<string>(type: "TEXT", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: true),
                    UserDataId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRelationship", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRelationship_UserData_UserDataId",
                        column: x => x.UserDataId,
                        principalTable: "UserData",
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
                    MangaChapterId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChapterRelationship", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChapterRelationship_MangaChapter_MangaChapterId",
                        column: x => x.MangaChapterId,
                        principalTable: "MangaChapter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mangas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    result = table.Column<string>(type: "TEXT", nullable: true),
                    dataId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mangas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mangas_MangaData_dataId",
                        column: x => x.dataId,
                        principalTable: "MangaData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Relationship",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RelationshipId = table.Column<string>(type: "TEXT", nullable: true),
                    RelationshipType = table.Column<string>(type: "TEXT", nullable: true),
                    MangaId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relationship", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Relationship_Mangas_MangaId",
                        column: x => x.MangaId,
                        principalTable: "Mangas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AltTitle_MangaAttributesId",
                table: "AltTitle",
                column: "MangaAttributesId");

            migrationBuilder.CreateIndex(
                name: "IX_Bio_UserId",
                table: "Bio",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ChapterData_AttributesId",
                table: "ChapterData",
                column: "AttributesId");

            migrationBuilder.CreateIndex(
                name: "IX_ChapterRelationship_MangaChapterId",
                table: "ChapterRelationship",
                column: "MangaChapterId");

            migrationBuilder.CreateIndex(
                name: "IX_MangaAttributes_descriptionId",
                table: "MangaAttributes",
                column: "descriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_MangaAttributes_linksId",
                table: "MangaAttributes",
                column: "linksId");

            migrationBuilder.CreateIndex(
                name: "IX_MangaAttributes_titleId",
                table: "MangaAttributes",
                column: "titleId");

            migrationBuilder.CreateIndex(
                name: "IX_MangaChapter_DataId",
                table: "MangaChapter",
                column: "DataId");

            migrationBuilder.CreateIndex(
                name: "IX_MangaChapter_MangaChaptersId",
                table: "MangaChapter",
                column: "MangaChaptersId");

            migrationBuilder.CreateIndex(
                name: "IX_MangaData_MangaAttributesId",
                table: "MangaData",
                column: "MangaAttributesId");

            migrationBuilder.CreateIndex(
                name: "IX_Mangas_dataId",
                table: "Mangas",
                column: "dataId");

            migrationBuilder.CreateIndex(
                name: "IX_MangaUsers_DataId",
                table: "MangaUsers",
                column: "DataId");

            migrationBuilder.CreateIndex(
                name: "IX_Relationship_MangaId",
                table: "Relationship",
                column: "MangaId");

            migrationBuilder.CreateIndex(
                name: "IX_ScanlationGroups_LeaderId",
                table: "ScanlationGroups",
                column: "LeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_Tag_AttributesId",
                table: "Tag",
                column: "AttributesId");

            migrationBuilder.CreateIndex(
                name: "IX_Tag_MangaAttributesId",
                table: "Tag",
                column: "MangaAttributesId");

            migrationBuilder.CreateIndex(
                name: "IX_TagAttributes_NameId",
                table: "TagAttributes",
                column: "NameId");

            migrationBuilder.CreateIndex(
                name: "IX_UserData_AttributesId",
                table: "UserData",
                column: "AttributesId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRelationship_UserDataId",
                table: "UserRelationship",
                column: "UserDataId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AltTitle");

            migrationBuilder.DropTable(
                name: "Bio");

            migrationBuilder.DropTable(
                name: "ChapterRelationship");

            migrationBuilder.DropTable(
                name: "ChaptersReads");

            migrationBuilder.DropTable(
                name: "CoverArts");

            migrationBuilder.DropTable(
                name: "MangaUsers");

            migrationBuilder.DropTable(
                name: "Relationship");

            migrationBuilder.DropTable(
                name: "ScanlationGroups");

            migrationBuilder.DropTable(
                name: "Tag");

            migrationBuilder.DropTable(
                name: "UserRelationship");

            migrationBuilder.DropTable(
                name: "MangaChapter");

            migrationBuilder.DropTable(
                name: "Mangas");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "TagAttributes");

            migrationBuilder.DropTable(
                name: "UserData");

            migrationBuilder.DropTable(
                name: "ChapterData");

            migrationBuilder.DropTable(
                name: "MangaChapters");

            migrationBuilder.DropTable(
                name: "MangaData");

            migrationBuilder.DropTable(
                name: "TagName");

            migrationBuilder.DropTable(
                name: "UserAttributes");

            migrationBuilder.DropTable(
                name: "ChapterAttributes");

            migrationBuilder.DropTable(
                name: "MangaAttributes");

            migrationBuilder.DropTable(
                name: "Description");

            migrationBuilder.DropTable(
                name: "Link");

            migrationBuilder.DropTable(
                name: "Title");
        }
    }
}
