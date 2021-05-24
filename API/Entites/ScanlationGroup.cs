using System;

namespace API.Entites
{
    public class ScanlationGroup
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public User Leader { get; set; } = new User();
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}