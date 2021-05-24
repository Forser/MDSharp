using System;

namespace API.Entites
{
    public class CoverArt
    {
        public string Id { get; set; }
        public string Volume { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}