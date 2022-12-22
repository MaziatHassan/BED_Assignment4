using Microsoft.AspNetCore.Mvc;
using BED_Assignment_4_grp4.Models;
using BED_Assignment_4_grp4.Data;


namespace BED_Assignment_4_grp4.Controllers
[Route("rarities")]
[ApiController]
public class RarityController : Controller
{
    private readonly MetaService _service;

    public RarityController(MetaService service)
    {
        _service = service;
    }

    [HttpGet("rarities")]
    public async Task<IList<Rarity>> GetAllRarities()
    {

        return await _service.GetRarities();
    }
}


