using Microsoft.AspNetCore.Mvc;
using BED_Assignment_4_grp4.Models;
using BED_Assignment_4_grp4.Data;



namespace BED_Assignment_4_grp4.Controllers;

[Route("sets")]
[ApiController]
public class SetController : ControllerBase
{
    private readonly MetaService _service;

    public SetController(MetaService service)
    {
        _service = service;
    }
    [HttpGet("sets")]
    public async Task<IList<Set>> GetSets()
    {
        return await _service.GetSets();
    }

}
