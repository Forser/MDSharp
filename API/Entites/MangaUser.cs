using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace API.Entites
{
    public class MangaUser
    {
        [Key]
        [JsonIgnore]
        public int Id { get; set; }

        [JsonPropertyName("result")]
        public string Result { get; set; }
        [JsonPropertyName("data")]
        public UserData Data { get; set; }
    }

    public class UserData
    {
        [JsonIgnore]
        [Key]
        public int Id { get; set; }

        [JsonPropertyName("id")]
        public string UserId { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("attributes")]
        public UserAttributes Attributes { get; set; }

        [JsonPropertyName("relationships")]
        public List<UserRelationship> Relationships { get; set; } = new List<UserRelationship>();
    }

    public class UserAttributes
    {
        [JsonIgnore]
        [Key]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("imageUrl")]
        public string ImageUrl { get; set; }
        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; set; }
        [JsonPropertyName("updateAt")]
        public DateTime UpdatedAt { get; set; }
        [JsonPropertyName("version")]
        public int Version { get; set; }
    }
    public class UserRelationship
    {
        [JsonIgnore]
        [Key]
        public int Id { get; set; }

        [JsonPropertyName("id")]
        public string MangaId { get; set; }
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}