using MongoDB.Bson;
using MongoDB.Driver;
using System.Text.Json;
using BED_Assignment_4_grp4.Models;
using BED_Assignment_4_grp4.Data;

namespace BED_Assignment_4_grp4.Data;
public class CardService
{
    private readonly IMongoCollection<Card> _cardCollection;

    string[] Jsonfilstier2 = { "cards.json" };
    public CardService(MongoService service)
    {
        _cardCollection = service.Client.GetDatabase("BED_Assignment_4_grp4").GetCollection<Card>("cards");
        SeedCardData();
    }

    public async void SeedCardData()
    {


        using (var file = new StreamReader(Jsonfilstier2[0]))
        {
            var card = JsonSerializer.Deserialize<List<Card>>(file.ReadToEnd(), new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            await _cardCollection.InsertManyAsync(card);
        }

    }
    public async Task<IList<Card>> Search(int? setid = null, int? classid = null, int? rarityid = null, int? typeid = null, string? artist = null, int? page = null)
    {
        var builder = Builders<Card>.Filter;
        var filter = builder.Empty;

        if (classid != null)
        {
            filter &= builder.Eq(x => x.ClassId, classid);
        }

        if (typeid != null)
        {
            filter &= builder.Eq(x => x.TypeId, typeid);
        }

        if (rarityid != null)
        {
            filter &= builder.Eq(x => x.RarityId, rarityid);
        }

        if (setid != null)
        {
            filter &= builder.Eq(x => x.SetId, setid);
        }
        if (artist?.Length > 0)
        {
            filter &= builder.Regex(x => x.Artist, new BsonRegularExpression($"/{artist}/i"));
        }
        var Size = 100;
        var result = _cardCollection.Find<Card>(filter);
        var count = await result.CountDocumentsAsync();
        if (page != null)
        {
            if (await result.CountDocumentsAsync() >= Size)
            {
                result = result.Skip(page * Size).Limit(Size);
            }
        }

        return await _cardCollection.Find(filter).ToListAsync();
    }



}


