using System;
using System.Collections.Generic;

namespace API.Entites
{
    public class MangaChapter
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Volume { get; set; }
        public string Chapter { get; set; }
        public string MangaId { get; set; }
        public string ScanlationGroupId { get; set; }
        public string TranslatedLanguage { get; set; }
        public string Hash { get; set; }
        public List<string> Data { get; set; }
        public string Uploader { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UploadedAt { get; set; }
        public DateTime PublishAt { get; set; }
    }
}