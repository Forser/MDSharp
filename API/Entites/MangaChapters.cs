using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API.Entites
{
    public class MangaChapters
    {
        [JsonIgnore]
        [Key]
        public int MangaChaptersId { get; set; }
        public List<MangaChapter> results {get; set;}
        [JsonIgnore]
        [ForeignKey("MangaId")]
        public int FK_Manga_Id { get; set; }
    }

    public class MangaChapter
    {
        [JsonIgnore]
        [Key]
        public int MangaChapterId { get; set; }
        [JsonPropertyName("result")]
        public string Result { get; set; }

        [JsonPropertyName("data")]
        public ChapterData Data { get; set; }
        [JsonPropertyName("relationships")]
        public List<ChapterRelationship> Relationships { get; set; } = new List<ChapterRelationship>();
        [JsonIgnore]
        [ForeignKey("MangaChaptersId")]
        public int FK_MangaChapters_Id { get; set; }
    }

    public class ChapterData
    {
        [JsonIgnore]
        [Key]
        public int ChapterDataId { get; set; }
        [JsonPropertyName("id")]
        public string ChapterId { get; set; }
        [JsonPropertyName("type")]
        public string Type { get; set; }
        [JsonPropertyName("attributes")]
        public ChapterAttributes Attributes { get; set; }
        public bool ChapterRead { get; set; } = false;
        [JsonIgnore]
        [ForeignKey("MangaChapterId")]
        public int FK_MangaChapter_Id { get; set; }
    }

    public class ChapterAttributes
    {
        [JsonIgnore]
        [Key]
        public int ChapterAttributesId { get; set; }
        [JsonPropertyName("volume")]
        public string Volume { get; set; }
        [JsonPropertyName("chapter")]
        public string Chapter { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("translatedLanguage")]
        public string TranslatedLanguage { get; set; }
        [JsonPropertyName("hash")]
        public string Hash { get; set; }

        // [JsonPropertyName("data")]
        // public ICollection<DataCollection> Data { get; set; }
        // [JsonPropertyName("dataSaver")]
        // public List<DataSaverCollection> DataSaver { get; set; } = new List<DataSaverCollection>();

        [JsonPropertyName("publishAt")]
        public DateTime PublishAt { get; set; }
        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; set; }
        [JsonPropertyName("updatedAt")]
        public DateTime UpdatedAt { get; set; }
        [JsonPropertyName("version")]
        public int Version { get; set; }
        [JsonIgnore]
        [ForeignKey("ChapterDataId")]
        public int FK_ChapterData_Id { get; set; }
    }

    public class ChapterRelationship
    {
        [JsonIgnore]
        [Key]
        public int ChapterRelationshipId { get; set; }
        [JsonPropertyName("id")]
        public string RelationshipId { get; set; }
        [JsonPropertyName("type")]
        public string Type { get; set; }
        [JsonIgnore]
        [ForeignKey("MangaChapterId")]
        public int FK_MangaChapter_Id { get; set; }
    }
}