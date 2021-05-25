using System;
using System.Collections.Generic;

namespace API.Entites
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<Bio> Bio { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

    public class Bio
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}