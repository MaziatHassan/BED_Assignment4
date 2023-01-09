using MongoDB.Driver;
using System.Text.Json;
using BED_Assignment_4_grp4.Models;

namespace BED_Assignment_4_grp4.Data
{ /*
    public class MongoService
    
    {
        private const string connectionString = "mongodb://localhost:27017";
        private const string databaseName = "BED4";

        private MongoClient client;
        private IMongoDatabase db;

       
        public IMongoCollection<T> ConnectToMongo<T>(in string collection)
        {
            client = new MongoClient(connectionString);
            db = client.GetDatabase(databaseName);
            return db.GetCollection<T>(collection);
        }

        public MongoClient GetClient()
        {
            return client;
        }

        public IMongoDatabase GetDatabase()
        {
            return db;
        }
    }*/



    public class MongoService
    {

        private readonly MongoClient _client;

        public MongoService()
        {
            _client = new MongoClient("mongodb://root:example@localhost:27017");
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
