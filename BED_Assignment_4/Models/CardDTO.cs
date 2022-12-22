﻿using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace BED_Assignment_4_grp4.Models
{
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
}
