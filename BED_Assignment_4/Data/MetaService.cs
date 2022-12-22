using MongoDB.Bson;
using MongoDB.Driver;
using BED_Assignment_4_grp4.Models;
//using BED_Assignment_4_grp4.Resources;
using System.Text.Json;
using BED_Assignment_4_grp4.Data;


namespace BED_Assignment_4_grp4.Data
{

    public class MetaService
    {
        private readonly IMongoCollection<Meta> _collection;
        private readonly IMongoCollection<Set> _SetCollection;
        private readonly IMongoCollection<Class> _ClassCollection;
        private readonly IMongoCollection<CardType> _TypeCollection;
        private readonly IMongoCollection<Rarity> _RaritiesCollection;
        private readonly MongoService _service;
        string[] Jsonfilstier = { "metadata.json" };
        public MetaService(MongoService service)
        {
            _collection = service.Client.GetDatabase("BED_Assignment_4_grp4").GetCollection<Meta>("meta");
            _SetCollection = service.Client.GetDatabase("BED_Assignment_4_grp4").GetCollection<Set>("sets");
            _ClassCollection = service.Client.GetDatabase("BED_Assignment_4_grp4").GetCollection<Class>("classes");
            _TypeCollection = service.Client.GetDatabase("BED_Assignment_4_grp4").GetCollection<CardType>("types");
            _RaritiesCollection = service.Client.GetDatabase("BED_Assignment_4_grp4").GetCollection<Rarity>("rarities");
            _service = service;
            SeedMetaData();

        }


        public async Task<IList<Set>> GetSets()
        {

            return await _SetCollection.Find<Set>(Builders<Set>.Filter.Empty).ToListAsync();
        }

        public async Task<IList<Class>> GetClasses()
        {

            return await _ClassCollection.Find<Class>(Builders<Class>.Filter.Empty).ToListAsync();
        }

        public async Task<IList<Rarity>> GetRarities()
        {

            return await _RaritiesCollection.Find<Rarity>(Builders<Rarity>.Filter.Empty).ToListAsync();
        }

        public async Task<IList<CardType>> GetTypes()
        {

            return await _TypeCollection.Find<CardType>(Builders<CardType>.Filter.Empty).ToListAsync();
        }



        public async void SeedMetaData()
        {



            using (var file = new StreamReader(Jsonfilstier[0]))
            {
                var Hearthstone = JsonSerializer.Deserialize<Hearthstone>(file.ReadToEnd(), new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                }
                );


                await _TypeCollection.InsertManyAsync(Hearthstone.Types);
                await _RaritiesCollection.InsertManyAsync(Hearthstone.Rarities);
                await _SetCollection.InsertManyAsync(Hearthstone.Sets);
                await _ClassCollection.InsertManyAsync(Hearthstone.Classes);
            }

        }


    }
}
