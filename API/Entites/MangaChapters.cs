using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace API.Entites
{
    public class MangaChapters
    {
        [JsonIgnore]
        [Key]
        public int Id { get; set; }
        public List<MangaChapter> results {get; set;}
    }

    public class MangaChapter
    {
        [JsonIgnore]
        [Key]
        public int Id { get; set; }
        [JsonPropertyName("result")]
        public string Result { get; set; }

        [JsonPropertyName("data")]
        public ChapterData Data { get; set; }
        [JsonPropertyName("relationships")]
        public List<ChapterRelationship> Relationships { get; set; } = new List<ChapterRelationship>();
    }

    public class ChapterData
    {
        [JsonIgnore]
        [Key]
        public int Id { get; set; }
        [JsonPropertyName("id")]
        public string ChapterId { get; set; }
        [JsonPropertyName("type")]
        public string Type { get; set; }
        [JsonPropertyName("attributes")]
        public ChapterAttributes Attributes { get; set; }
        public bool ChapterRead { get; set; } = false;
    }

    public class ChapterAttributes
    {
        [JsonIgnore]
        [Key]
        public int Id { get; set; }
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
    }

    public class ChapterRelationship
    {
        [JsonIgnore]
        [Key]
        public int Id { get; set; }
        [JsonPropertyName("id")]
        public string RelationshipId { get; set; }
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}