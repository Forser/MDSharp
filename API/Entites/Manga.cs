using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace API.Entites
{
  public class Manga
  {
    [Key]
    [JsonIgnore]
    public int Id { get; set; }
    [JsonPropertyName("result")]
    public string Result { get; set; }
    [JsonPropertyName("data")]
    public MangaData Data { get; set; }
    [JsonPropertyName("relationships")]
    public IList<Relationship> Relationships { get; set; }
  }

  public class Relationship
  {
    [JsonIgnore]
    [Key]
    public int Id { get; set; }
    [JsonPropertyName("id")]
    public string RelationshipId { get; set; }
    [JsonPropertyName("type")]
    public string RelationshipType { get; set; }
  }

  public class MangaData
  {
    [Key]
    [JsonIgnore]
    public int Id { get; set; }
    [JsonPropertyName("id")]
    public string MangaId { get; set; }
    [JsonPropertyName("attributes")]
    public MangaAttributes MangaAttributes { get; set; }
  }

  public class MangaAttributes
  {
    [Key]
    [JsonIgnore]
    public int Id { get; set; }

    [JsonPropertyName("title")]
    public Title Title { get; set; }
    [JsonPropertyName("altTitles")]
    public List<AltTitle> AltTitles { get; set; } = new List<AltTitle>();
    [JsonPropertyName("description")]
    public Description Description { get; set; }
    [JsonPropertyName("tags")]
    public List<Tag> Tags { get; set; } = new List<Tag>();
    [JsonPropertyName("links")]
    public Link Links { get; set; }
    [JsonPropertyName("isLocked")]
    public bool IsLocked { get; set; } = false;
    [JsonPropertyName("originalLanguage")]
    public string OriginalLanguage { get; set; }
    [JsonPropertyName("lastVolume")]
    public string LastVolume { get; set; }
    [JsonPropertyName("lastChapter")]
    public string LastChapter { get; set; }
    [JsonPropertyName("publicationDemographic")]
    public string PublicationDemographic { get; set; }
    [JsonPropertyName("status")]
    public string Status { get; set; }
    [JsonPropertyName("year")]
    public DateTime? Year { get; set; }
    [JsonPropertyName("contentRating")]
    public string ContentRating { get; set; }
    [JsonPropertyName("version")]
    public int Version { get; set; }
    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; set; }
    [JsonPropertyName("updatedAt")]
    public DateTime UpdatedAt { get; set; }
  }

  public class Description
  {
    [Key]
    [JsonIgnore]
    public int Id { get; set; }
    [JsonPropertyName("en")]
    public string Value { get; set; }
  }

  public class Title
  {
    [Key]
    [JsonIgnore]
    public int Id { get; set; }
    [JsonPropertyName("en")]
    public string Name { get; set; }
  }

  public class AltTitle
  {
    [Key]
    [JsonIgnore]
    public int Id { get; set; }
    [JsonPropertyName("en")]
    public string Name { get; set; }
  }
  public class Link
  {
    [Key]
    [JsonIgnore]
    public int Id { get; set; }

    [JsonPropertyName("al")]
    public string AniList { get; set; }
    [JsonPropertyName("ap")]
    public string AnimePlanet { get; set; }
    [JsonPropertyName("bw")]
    public string BookWalker { get; set; }
    [JsonPropertyName("kt")]
    public string Kitsu { get; set; }
    [JsonPropertyName("mu")]
    public string MangaUpdates { get; set; }
    [JsonPropertyName("nu")]
    public string NovelUpdates { get; set; }
    [JsonPropertyName("amz")]
    public string Amazon { get; set; }
    [JsonPropertyName("ebj")]
    public string EBookJP { get; set; }
    [JsonPropertyName("raw")]
    public string Raw { get; set; }
    [JsonPropertyName("mal")]
    public string MAL { get; set; }
    [JsonPropertyName("engtl")]
    public string EngTL { get; set; }
  }

  public class Tag
  {
    [Key]
    [JsonIgnore]
    public int Id { get; set; }
    [JsonPropertyName("id")]
    public string TagId { get; set; }
    [JsonPropertyName("type")]
    public string Type { get; set; }
    [JsonPropertyName("attributes")]
    public TagAttributes Attributes { get; set; }
  }

  public class TagAttributes
  {
    [Key]
    [JsonIgnore]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public TagName Name { get; set; }
    [JsonPropertyName("group")]
    public string Group { get; set; }
    [JsonPropertyName("version")]
    public int Version { get; set; }
  }

  public class TagName
  {
    [Key]
    [JsonIgnore]
    public int Id { get; set; }
    [JsonPropertyName("en")]
    public string Name { get; set; }
  }
}