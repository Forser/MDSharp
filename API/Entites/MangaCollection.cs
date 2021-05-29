using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace API.Entites
{
    public class MangaCollection
    {
        [Key]
        [JsonIgnore]
        public int Id { get; set; }
        [JsonPropertyName("results")]
        public List<Manga> Mangas { get; set; } = new List<Manga>();
        //public List<MangaChapter> Chapters { get; set; } = new List<MangaChapter>();
    }
}