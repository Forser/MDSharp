using System;
using System.Collections.Generic;

namespace API.Entites
{
  public class Manga
  {
    public string Id { get; set; }
    public ICollection<Title> Title { get; set; }
    public ICollection<AltTitle> AltTitles { get; set; }
    public ICollection<Description> Description { get; set; }
    public bool IsLocked { get; set; } = false;
    public ICollection<Link> Links { get; set; }
    public string OriginalLanguage { get; set; }
    public string LastVolume { get; set; }
    public string LastChapter { get; set; }
    public string PublicationDemographic { get; set; }
    public string Status { get; set; }
    public int Year { get; set; } = 0;
    public string ContentRating { get; set; }
    public ICollection<Tag> Tags { get; set; }
    public int Version { get; set; }
    public DateTime createdAt { get; set; }
    public DateTime updatedAt { get; set; }
  }

  public class AltTitle
  {
    public int Id { get; set; }
    public string Key { get; set; }
    public string Value { get; set; }
  }

  public class Description
  {
    public int Id { get; set; }
    public string Key { get; set; }
    public string Value { get; set; }
  }

  public class Title
  {
    public int Id { get; set; }
    public string Key { get; set; }
    public string Value { get; set; }
  }

  public class Link
  {
    public int Id { get; set; }
    public string Key { get; set; }
    public string Value { get; set; }
  }

  public class Tag
  {
    public int Id { get; set; }
    public string TagId { get; set; }
    public string Type { get; set; }
    public ICollection<TagDescription> Description { get; set; }
    public ICollection<TagAttributes> Attributes { get; set; }
  }

  public class TagAttributes
  {
    public int Id { get; set; }
    public ICollection<TagAttributesName> TagAttributeName { get; set; }
    public ICollection<TagDescription> TagDescription { get; set; }
    public string Group { get; set; }
    public int Version { get; set; }
  }

  public class TagAttributesName
  {
    public int Id { get; set; }
    public string Key { get; set; }
    public string Value { get; set; }
  }

  public class TagDescription
  {
    public int Id { get; set; }
    public string Key { get; set; }
    public string Value { get; set; }
  }
}