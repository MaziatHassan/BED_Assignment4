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



}
