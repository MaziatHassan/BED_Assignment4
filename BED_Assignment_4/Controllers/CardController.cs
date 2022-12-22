using Microsoft.AspNetCore.Mvc;
using BED_Assignment_4_grp4.Models;
using BED_Assignment_4_grp4.Data;
using MongoDB.Driver;
using Microsoft.AspNetCore.Cors.Infrastructure;

namespace BED_Assignment_4_grp4.Controllers;

[Route("cards")]
[ApiController]
public class CardController : Controller
{

    private readonly CardService _service;
    public CardController(CardService service)
    {
        _service = service;
    }

    [HttpGet("cards")]

    public async Task<IList<Card>> GetAsync(int? typeid = null, int? setid = null, int? classid = null, int? rarityid = null, string? artist = null, int? page = null)
    {
        return await _service.Search(setid, classid, rarityid, typeid, artist, page);
    }

}
