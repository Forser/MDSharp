using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;

namespace API.Entites
{
  public class Manga
  {
    [Key]
    public int Id { get; set; }
    public string result { get; set; }
    public MangaData data { get; set; }
    public IList<Relationship> relationships { get; set; }
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
    [JsonIgnore]
    public int Id { get; set; }
    [JsonPropertyName("attributes")]
    public MangaAttributes MangaAttributes { get; set; }
  }

  public class MangaAttributes
  {
    [Key]
    [JsonIgnore]
    public int Id { get; set; }

    [JsonPropertyName("id")]
    public string MangaId { get; set; }
    public Title title { get; set; }
    public List<AltTitle> altTitles { get; set; } = new List<AltTitle>();
    public Description description { get; set; }
    [JsonPropertyName("tags")]
    public List<Tag> Tags { get; set; } = new List<Tag>();
    public Link links { get; set; }
    public bool isLocked { get; set; } = false;
    public string originalLanguage { get; set; }
    public string lastVolume { get; set; }
    public string lastChapter { get; set; }
    public string publicationDemographic { get; set; }
    public string status { get; set; }
    public DateTime? year { get; set; }
    public string contentRating { get; set; }
    public int version { get; set; }
    public DateTime createdAt { get; set; }
    public DateTime updatedAt { get; set; }
  }

  public class Description
  {
    [JsonIgnore]
    public int Id { get; set; }
    [JsonPropertyName("en")]
    public string Value { get; set; }
  }

  public class Title
  {
    [JsonIgnore]
    public int Id { get; set; }
    [JsonPropertyName("en")]
    public string Name { get; set; }
  }

  public class AltTitle
  {
    [JsonIgnore]
    public int Id { get; set; }
    [JsonPropertyName("en")]
    public string Name { get; set; }
  }
  public class Link
  {
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