using System;
using System.Collections.Generic;

namespace API.Entites
{
  public class Manga
  {
    public int Id { get; set; }
    public string result { get; set; }
    public MangaData data { get; set; }
    public IList<IDictionary<string, string>> relationships { get; set; }
  }

  public class MangaData
  {
    public MangaAttributes attributes { get; set; }
  }

  public class MangaAttributes
  {
    public string id { get; set; }
    public IDictionary<string, string> title { get; set; }
    public IList<IDictionary<string, string>> altTitles { get; set; }
    public IDictionary<string, string> description { get; set; }
    public IList<Tag> tags { get; set; }
    public IDictionary<string, string> links { get; set; }
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

  public class Tag
  {
    public string id { get; set; }
    public string tagId { get; set; }
    public string type { get; set; }
    public TagAttributes attributes { get; set; }
  }

  public class TagAttributes
  {
    public int Id { get; set; }
    public IDictionary<string, string> name { get; set; }
    public IList<IDictionary<string, string>> description { get; set; }
    public string group { get; set; }
    public int version { get; set; }
  }
}