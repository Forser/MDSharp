using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace API.Entites
{
    public class MangaCollection
    {
        [Key]
        [JsonIgnore]
        public int MangaCollectionId { get; set; }
        [JsonPropertyName("results")]
        public List<Manga> Mangas { get; set; } = new List<Manga>();
    }
}