using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API.Entites
{
  public class Manga
  {
    [Key]
    [JsonIgnore]
    public int MangaId { get; set; }
    [JsonPropertyName("result")]
    public string Result { get; set; }
    [JsonPropertyName("data")]
    public MangaData Data { get; set; }
    [JsonPropertyName("relationships")]
    public IList<Relationship> Relationships { get; set; }
    [JsonIgnore]
    public MangaChapters MangaChapters { get; set; }
    [JsonIgnore]
    [ForeignKey("MangaCollectionId")]
    public int FK_MangaCollection_Id { get; set; }
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
    [JsonIgnore]
    [ForeignKey("MangaId")]
    public int FK_Manga_Id { get; set; }
  }

  public class MangaData
  {
    [Key]
    [JsonIgnore]
    public int MangaDataId { get; set; }
    [JsonPropertyName("id")]
    public string MangaId { get; set; }
    [JsonPropertyName("attributes")]
    public MangaAttributes MangaAttributes { get; set; }
    [JsonIgnore]
    [ForeignKey("MangaId")]
    public int FK_Manga_Id { get; set; }
  }

  public class MangaAttributes
  {
    [Key]
    [JsonIgnore]
    public int MangaAttributesId { get; set; }

    [JsonPropertyName("title")]
    public MangaTitle Title { get; set; }
    [JsonPropertyName("altTitles")]
    public List<MangaAltTitle> AltTitles { get; set; } = new List<MangaAltTitle>();
    [JsonPropertyName("description")]
    public MangaDescription MangaDescription { get; set; }
    [JsonPropertyName("tags")]
    public List<MangaTag> Tags { get; set; } = new List<MangaTag>();
    [JsonPropertyName("links")]
    public MangaLink MangaLinks { get; set; }
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

    [JsonIgnore]
    [ForeignKey("MangaDataId")]
    public int FK_MangaData_Id { get; set; }
  }

  public class MangaDescription
  {
    [Key]
    [JsonIgnore]
    public int MangaDescriptionId { get; set; }
    [JsonPropertyName("en")]
    public string Description { get; set; }
    [JsonIgnore]
    [ForeignKey("MangaAttributesId")]
    public int FK_MangaAttributes_Id { get; set; }
  }

  public class MangaTitle
  {
    [Key]
    [JsonIgnore]
    public int MangaTitleId { get; set; }
    [JsonPropertyName("en")]
    public string Title { get; set; }
    [JsonIgnore]
    [ForeignKey("MangaAttributesId")]
    public int FK_MangaAttributes_Id { get; set; }
  }

  public class MangaAltTitle
  {
    [Key]
    [JsonIgnore]
    public int MangaAltTitleId { get; set; }
    [JsonPropertyName("en")]
    public string AltTitle { get; set; }
    [JsonIgnore]
    [ForeignKey("MangaAttributesId")]
    public int FK_MangaAttributes_Id { get; set; }
  }
  public class MangaLink
  {
    [Key]
    [JsonIgnore]
    public int MangaLinkId { get; set; }

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
    [JsonIgnore]
    [ForeignKey("MangaAttributesId")]
    public int FK_MangaAttributes_Id { get; set; }
  }

  public class MangaTag
  {
    [Key]
    [JsonIgnore]
    public int MangaTagId { get; set; }
    [JsonPropertyName("id")]
    public string TagId { get; set; }
    [JsonPropertyName("type")]
    public string Type { get; set; }
    [JsonPropertyName("attributes")]
    public TagAttributes TagAttributes { get; set; }
    [JsonIgnore]
    [ForeignKey("MangaAttributesId")]
    public int FK_MangaAttributes_Id { get; set; }
  }

  public class TagAttributes
  {
    [Key]
    [JsonIgnore]
    public int TagAttributesId { get; set; }

    [JsonPropertyName("name")]
    public TagName Name { get; set; }
    [JsonPropertyName("group")]
    public string Group { get; set; }
    [JsonPropertyName("version")]
    public int Version { get; set; }
    [JsonIgnore]
    [ForeignKey("MangaTagId")]
    public int FK_MangaTag_Id { get; set; }
  }

  public class TagName
  {
    [Key]
    [JsonIgnore]
    public int TagNameId { get; set; }
    [JsonPropertyName("en")]
    public string Name { get; set; }
    [JsonIgnore]
    [ForeignKey("TagAttributesId")]
    public int FK_TagAttributes_Id { get; set; }
  }
}