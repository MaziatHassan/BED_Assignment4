using System.Text.Json.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BED_Assignment_4_grp4.Models
{
    public class Hearthstone
    {
        public List<Set> Sets { get; set; }

        public List<Rarity> Rarities { get; set; }

        public List<Class> Classes { get; set; }

        public List<CardType> Types { get; set; }

        public List<Card> Cards { get; set; }

    }

    public class Card
    {
        [BsonId]
        public int Id { get; set; }
        public string Name { get; set; }
        public int ClassId { get; set; }

        [JsonPropertyName("cardTypeId")]
        public int TypeId { get; set; }

        [JsonPropertyName("cardSetId")]
        public int SetId { get; set; }

        public int? SpellSchoolId { get; set; }
        public int RarityId { get; set; }
        public int? Health { get; set; }
        public int? Attack { get; set; }
        public int ManaCost { get; set; }

        [JsonPropertyName("artistName")]
        public string Artist { get; set; }
        public string Text { get; set; }
        public string FlavorText { get; set; }
    }

    public class CardDTO
    {
        [BsonId]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }

        public string Type { get; set; }

        public string Set { get; set; }

        public int? SpellSchoolId { get; set; }
        public string Rarity { get; set; }
        public int? Health { get; set; }
        public int? Attack { get; set; }
        public int ManaCost { get; set; }

        [JsonPropertyName("artistName")]
        public string Artist { get; set; }
        public string Text { get; set; }
        public string FlavorText { get; set; }
    }

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

    public class Set
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        [JsonPropertyName("collectibleCount")]
        public int CardCount { get; set; }
    }


    public class CardType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Class
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Rarity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }


}
