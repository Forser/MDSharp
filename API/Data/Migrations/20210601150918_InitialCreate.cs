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
                    ChapterAttributesId = table.Column<int>(type: "INTEGER", nullable: false)
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
                    FK_ChapterData_Id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChapterAttributes", x => x.ChapterAttributesId);
                });

            migrationBuilder.CreateTable(
                name: "ChaptersReads",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Result = table.Column<string>(type: "TEXT", nullable: true)
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
                name: "MangaChapters",
                columns: table => new
                {
                    MangaChaptersId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FK_Manga_Id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MangaChapters", x => x.MangaChaptersId);
                });

            migrationBuilder.CreateTable(
                name: "MangaCollection",
                columns: table => new
                {
                    MangaCollectionId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MangaCollection", x => x.MangaCollectionId);
                });

            migrationBuilder.CreateTable(
                name: "MangaDescription",
                columns: table => new
                {
                    MangaDescriptionId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    FK_MangaAttributes_Id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MangaDescription", x => x.MangaDescriptionId);
                });

            migrationBuilder.CreateTable(
                name: "MangaLink",
                columns: table => new
                {
                    MangaLinkId = table.Column<int>(type: "INTEGER", nullable: false)
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
                    EngTL = table.Column<string>(type: "TEXT", nullable: true),
                    FK_MangaAttributes_Id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MangaLink", x => x.MangaLinkId);
                });

            migrationBuilder.CreateTable(
                name: "MangaTitle",
                columns: table => new
                {
                    MangaTitleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    FK_MangaAttributes_Id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MangaTitle", x => x.MangaTitleId);
                });

            migrationBuilder.CreateTable(
                name: "TagName",
                columns: table => new
                {
                    TagNameId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    FK_TagAttributes_Id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagName", x => x.TagNameId);
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
                    ChapterDataId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ChapterId = table.Column<string>(type: "TEXT", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: true),
                    AttributesChapterAttributesId = table.Column<int>(type: "INTEGER", nullable: true),
                    ChapterRead = table.Column<bool>(type: "INTEGER", nullable: false),
                    FK_MangaChapter_Id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChapterData", x => x.ChapterDataId);
                    table.ForeignKey(
                        name: "FK_ChapterData_ChapterAttributes_AttributesChapterAttributesId",
                        column: x => x.AttributesChapterAttributesId,
                        principalTable: "ChapterAttributes",
                        principalColumn: "ChapterAttributesId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChapterId",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ReadId = table.Column<string>(type: "TEXT", nullable: true),
                    ChaptersReadId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChapterId", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChapterId_ChaptersReads_ChaptersReadId",
                        column: x => x.ChaptersReadId,
                        principalTable: "ChaptersReads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MangaAttributes",
                columns: table => new
                {
                    MangaAttributesId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TitleMangaTitleId = table.Column<int>(type: "INTEGER", nullable: true),
                    MangaDescriptionId = table.Column<int>(type: "INTEGER", nullable: true),
                    MangaLinksMangaLinkId = table.Column<int>(type: "INTEGER", nullable: true),
                    IsLocked = table.Column<bool>(type: "INTEGER", nullable: false),
                    OriginalLanguage = table.Column<string>(type: "TEXT", nullable: true),
                    LastVolume = table.Column<string>(type: "TEXT", nullable: true),
                    LastChapter = table.Column<string>(type: "TEXT", nullable: true),
                    PublicationDemographic = table.Column<string>(type: "TEXT", nullable: true),
                    Status = table.Column<string>(type: "TEXT", nullable: true),
                    Year = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ContentRating = table.Column<string>(type: "TEXT", nullable: true),
                    Version = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FK_MangaData_Id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MangaAttributes", x => x.MangaAttributesId);
                    table.ForeignKey(
                        name: "FK_MangaAttributes_MangaDescription_MangaDescriptionId",
                        column: x => x.MangaDescriptionId,
                        principalTable: "MangaDescription",
                        principalColumn: "MangaDescriptionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MangaAttributes_MangaLink_MangaLinksMangaLinkId",
                        column: x => x.MangaLinksMangaLinkId,
                        principalTable: "MangaLink",
                        principalColumn: "MangaLinkId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MangaAttributes_MangaTitle_TitleMangaTitleId",
                        column: x => x.TitleMangaTitleId,
                        principalTable: "MangaTitle",
                        principalColumn: "MangaTitleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TagAttributes",
                columns: table => new
                {
                    TagAttributesId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NameTagNameId = table.Column<int>(type: "INTEGER", nullable: true),
                    Group = table.Column<string>(type: "TEXT", nullable: true),
                    Version = table.Column<int>(type: "INTEGER", nullable: false),
                    FK_MangaTag_Id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagAttributes", x => x.TagAttributesId);
                    table.ForeignKey(
                        name: "FK_TagAttributes_TagName_NameTagNameId",
                        column: x => x.NameTagNameId,
                        principalTable: "TagName",
                        principalColumn: "TagNameId",
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
                    MangaChapterId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Result = table.Column<string>(type: "TEXT", nullable: true),
                    DataChapterDataId = table.Column<int>(type: "INTEGER", nullable: true),
                    FK_MangaChapters_Id = table.Column<int>(type: "INTEGER", nullable: false),
                    MangaChaptersId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MangaChapter", x => x.MangaChapterId);
                    table.ForeignKey(
                        name: "FK_MangaChapter_ChapterData_DataChapterDataId",
                        column: x => x.DataChapterDataId,
                        principalTable: "ChapterData",
                        principalColumn: "ChapterDataId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MangaChapter_MangaChapters_MangaChaptersId",
                        column: x => x.MangaChaptersId,
                        principalTable: "MangaChapters",
                        principalColumn: "MangaChaptersId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MangaAltTitle",
                columns: table => new
                {
                    MangaAltTitleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AltTitle = table.Column<string>(type: "TEXT", nullable: true),
                    FK_MangaAttributes_Id = table.Column<int>(type: "INTEGER", nullable: false),
                    MangaAttributesId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MangaAltTitle", x => x.MangaAltTitleId);
                    table.ForeignKey(
                        name: "FK_MangaAltTitle_MangaAttributes_MangaAttributesId",
                        column: x => x.MangaAttributesId,
                        principalTable: "MangaAttributes",
                        principalColumn: "MangaAttributesId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MangaData",
                columns: table => new
                {
                    MangaDataId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MangaId = table.Column<string>(type: "TEXT", nullable: true),
                    MangaAttributesId = table.Column<int>(type: "INTEGER", nullable: true),
                    FK_Manga_Id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MangaData", x => x.MangaDataId);
                    table.ForeignKey(
                        name: "FK_MangaData_MangaAttributes_MangaAttributesId",
                        column: x => x.MangaAttributesId,
                        principalTable: "MangaAttributes",
                        principalColumn: "MangaAttributesId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MangaTag",
                columns: table => new
                {
                    MangaTagId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TagId = table.Column<string>(type: "TEXT", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: true),
                    TagAttributesId = table.Column<int>(type: "INTEGER", nullable: true),
                    FK_MangaAttributes_Id = table.Column<int>(type: "INTEGER", nullable: false),
                    MangaAttributesId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MangaTag", x => x.MangaTagId);
                    table.ForeignKey(
                        name: "FK_MangaTag_MangaAttributes_MangaAttributesId",
                        column: x => x.MangaAttributesId,
                        principalTable: "MangaAttributes",
                        principalColumn: "MangaAttributesId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MangaTag_TagAttributes_TagAttributesId",
                        column: x => x.TagAttributesId,
                        principalTable: "TagAttributes",
                        principalColumn: "TagAttributesId",
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
                    ChapterRelationshipId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RelationshipId = table.Column<string>(type: "TEXT", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: true),
                    FK_MangaChapter_Id = table.Column<int>(type: "INTEGER", nullable: false),
                    MangaChapterId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChapterRelationship", x => x.ChapterRelationshipId);
                    table.ForeignKey(
                        name: "FK_ChapterRelationship_MangaChapter_MangaChapterId",
                        column: x => x.MangaChapterId,
                        principalTable: "MangaChapter",
                        principalColumn: "MangaChapterId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mangas",
                columns: table => new
                {
                    MangaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Result = table.Column<string>(type: "TEXT", nullable: true),
                    DataMangaDataId = table.Column<int>(type: "INTEGER", nullable: true),
                    MangaChaptersId = table.Column<int>(type: "INTEGER", nullable: true),
                    FK_MangaCollection_Id = table.Column<int>(type: "INTEGER", nullable: false),
                    MangaCollectionId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mangas", x => x.MangaId);
                    table.ForeignKey(
                        name: "FK_Mangas_MangaChapters_MangaChaptersId",
                        column: x => x.MangaChaptersId,
                        principalTable: "MangaChapters",
                        principalColumn: "MangaChaptersId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mangas_MangaCollection_MangaCollectionId",
                        column: x => x.MangaCollectionId,
                        principalTable: "MangaCollection",
                        principalColumn: "MangaCollectionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mangas_MangaData_DataMangaDataId",
                        column: x => x.DataMangaDataId,
                        principalTable: "MangaData",
                        principalColumn: "MangaDataId",
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
                    FK_Manga_Id = table.Column<int>(type: "INTEGER", nullable: false),
                    MangaId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relationship", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Relationship_Mangas_MangaId",
                        column: x => x.MangaId,
                        principalTable: "Mangas",
                        principalColumn: "MangaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bio_UserId",
                table: "Bio",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ChapterData_AttributesChapterAttributesId",
                table: "ChapterData",
                column: "AttributesChapterAttributesId");

            migrationBuilder.CreateIndex(
                name: "IX_ChapterId_ChaptersReadId",
                table: "ChapterId",
                column: "ChaptersReadId");

            migrationBuilder.CreateIndex(
                name: "IX_ChapterRelationship_MangaChapterId",
                table: "ChapterRelationship",
                column: "MangaChapterId");

            migrationBuilder.CreateIndex(
                name: "IX_MangaAltTitle_MangaAttributesId",
                table: "MangaAltTitle",
                column: "MangaAttributesId");

            migrationBuilder.CreateIndex(
                name: "IX_MangaAttributes_MangaDescriptionId",
                table: "MangaAttributes",
                column: "MangaDescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_MangaAttributes_MangaLinksMangaLinkId",
                table: "MangaAttributes",
                column: "MangaLinksMangaLinkId");

            migrationBuilder.CreateIndex(
                name: "IX_MangaAttributes_TitleMangaTitleId",
                table: "MangaAttributes",
                column: "TitleMangaTitleId");

            migrationBuilder.CreateIndex(
                name: "IX_MangaChapter_DataChapterDataId",
                table: "MangaChapter",
                column: "DataChapterDataId");

            migrationBuilder.CreateIndex(
                name: "IX_MangaChapter_MangaChaptersId",
                table: "MangaChapter",
                column: "MangaChaptersId");

            migrationBuilder.CreateIndex(
                name: "IX_MangaData_MangaAttributesId",
                table: "MangaData",
                column: "MangaAttributesId");

            migrationBuilder.CreateIndex(
                name: "IX_Mangas_DataMangaDataId",
                table: "Mangas",
                column: "DataMangaDataId");

            migrationBuilder.CreateIndex(
                name: "IX_Mangas_MangaChaptersId",
                table: "Mangas",
                column: "MangaChaptersId");

            migrationBuilder.CreateIndex(
                name: "IX_Mangas_MangaCollectionId",
                table: "Mangas",
                column: "MangaCollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_MangaTag_MangaAttributesId",
                table: "MangaTag",
                column: "MangaAttributesId");

            migrationBuilder.CreateIndex(
                name: "IX_MangaTag_TagAttributesId",
                table: "MangaTag",
                column: "TagAttributesId");

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
                name: "IX_TagAttributes_NameTagNameId",
                table: "TagAttributes",
                column: "NameTagNameId");

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
                name: "Bio");

            migrationBuilder.DropTable(
                name: "ChapterId");

            migrationBuilder.DropTable(
                name: "ChapterRelationship");

            migrationBuilder.DropTable(
                name: "CoverArts");

            migrationBuilder.DropTable(
                name: "MangaAltTitle");

            migrationBuilder.DropTable(
                name: "MangaTag");

            migrationBuilder.DropTable(
                name: "MangaUsers");

            migrationBuilder.DropTable(
                name: "Relationship");

            migrationBuilder.DropTable(
                name: "ScanlationGroups");

            migrationBuilder.DropTable(
                name: "UserRelationship");

            migrationBuilder.DropTable(
                name: "ChaptersReads");

            migrationBuilder.DropTable(
                name: "MangaChapter");

            migrationBuilder.DropTable(
                name: "TagAttributes");

            migrationBuilder.DropTable(
                name: "Mangas");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "UserData");

            migrationBuilder.DropTable(
                name: "ChapterData");

            migrationBuilder.DropTable(
                name: "TagName");

            migrationBuilder.DropTable(
                name: "MangaChapters");

            migrationBuilder.DropTable(
                name: "MangaCollection");

            migrationBuilder.DropTable(
                name: "MangaData");

            migrationBuilder.DropTable(
                name: "UserAttributes");

            migrationBuilder.DropTable(
                name: "ChapterAttributes");

            migrationBuilder.DropTable(
                name: "MangaAttributes");

            migrationBuilder.DropTable(
                name: "MangaDescription");

            migrationBuilder.DropTable(
                name: "MangaLink");

            migrationBuilder.DropTable(
                name: "MangaTitle");
        }
    }
}
