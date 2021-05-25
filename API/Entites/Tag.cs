using System.Collections.Generic;

namespace API.Entites
{
    public class Tag
    {
        public string Id { get; set; }
        public IDictionary<string, string> Name { get; set; }
    }
}