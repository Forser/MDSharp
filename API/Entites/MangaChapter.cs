using System;
using System.Collections.Generic;

namespace API.Entites
{
    public class MangaChapter
    {
        public string Id { get; set; }
        public string Result { get; set; }

        public ICollection<ChapterData> Data { get; set; }
        public ICollection<ChapterRelationship> Relationships { get; set; }
    }

    public class ChapterData
    {
        public int Id { get; set; }
        public string ChapterId { get; set; }
        public string Type { get; set; }
        public ICollection<ChapterAttributes> Attributes { get; set; }
    }

    public class ChapterAttributes
    {
        public int Id { get; set; }
        public string Volume { get; set; }
        public string Chapter { get; set; }
        public string Title { get; set; }
        public string TranslatedLanguage { get; set; }
        public string Hash { get; set; }

        public ICollection<DataCollection> Data { get; set; }
        public ICollection<DataSaverCollection> DataSaver { get; set; }

        public DateTime PublishAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int Version { get; set; }
    }

    public class ChapterRelationship
    {
        public int Id { get; set; }
        public string RelationshipId { get; set; }
        public string Type { get; set; }
    }

    public class DataCollection
    {
        public int Id { get; set; }
        public string FileName { get; set; }
    }

    public class DataSaverCollection
    {
        public int Id { get; set; }
        public string FileName { get; set; }
    }
}