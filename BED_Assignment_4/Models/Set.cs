using System.Text.Json.Serialization;

namespace BED_Assignment_4_grp4.Models
{
    public class Set
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        [JsonPropertyName("collectibleCount")]
        public int CardCount { get; set; }
    }
}
