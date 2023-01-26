using MongoDB.Driver;
using System.Text.Json;
using BED_Assignment_4_grp4.Models;

namespace BED_Assignment_4_grp4.Data
{ 

    public class MongoService
    {

        private readonly MongoClient _client;

        public MongoService()
        {
            _client = new MongoClient("mongodb://localhost:27017");
        }
        public MongoClient Client
        {
            get
            {
                return _client;
            }
        }

    }
}
