using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.Text.Json.Serialization;

namespace BED_Assignment_4_grp4.Models
{
    public class Meta
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public List<Set> Sets { get; set; }
        public List<Rarity> Rarities { get; set; }
        public List<Class> Classes { get; set; }
        [JsonPropertyName("Types")]
        public List<CardType> CardType { get; set; }
    }
}
