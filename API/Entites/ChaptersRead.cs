using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace API.Entites
{
  public class ChaptersRead
    {
        [Key]
        [JsonIgnore]
        public int Id { get; set; }
        [JsonPropertyName("result")]
        public string Result { get; set; } = "ok";
        [JsonPropertyName("data")]
        public List<ChapterId> Data { get; set; } = new List<ChapterId>();
    }

    public class ChapterId
    {
        [Key]
        [JsonIgnore]
        public int Id { get; set; }
        public string ReadId { get; set; }
    }
}