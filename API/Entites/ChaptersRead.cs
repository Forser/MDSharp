using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API.Entites
{
    public class ChaptersRead
    {
        [Key]
        public int Id { get; set; }
        [JsonPropertyName("result")]
        public string Result { get; set; }
        [JsonPropertyName("data")]
        public IList<string> Data { get; set; }
    }
}