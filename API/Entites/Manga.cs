using System;
using System.Collections.Generic;

namespace API.Entites
{
    public class Manga
    {
        public string Id { get; set; }
        public Dictionary<string, string> Title { get; set; }
        public Dictionary<string, string> AltTitles { get; set; }
        public Dictionary<string, string> Description { get; set; }
        public bool IsLocked { get; set; } = false;
        public Dictionary<string, string> Links { get; set; }
        public string OriginalLanguage { get; set; }
        public string LastVolume { get; set; }
        public string LastChapter { get; set; }
        public string PublicationDemographic { get; set; }
        public string Status { get; set; }
        public int Year { get; set; } = 0;
        public string ContentRating { get; set; }
        public List<string> Tags { get; set; }
        public int Version { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}