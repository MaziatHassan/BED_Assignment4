using Microsoft.AspNetCore.Mvc;
using BED_Assignment_4_grp4.Models;
using BED_Assignment_4_grp4.Data;


namespace BED_Assignment_4_grp4.Controllers;

[Route("types")]
[ApiController]
public class TypeController : ControllerBase
{
    private readonly MetaService _service;

    public TypeController(MetaService service)
    {
        _service = service;
    }
    [HttpGet("types")]
    public async Task<IList<CardType>> GetAllTypes()
    {
        return await _service.GetTypes();
    }
}
