using Microsoft.AspNetCore.Mvc;
using BED_Assignment_4_grp4.Models;
using BED_Assignment_4_grp4.Data;


namespace BED_Assignment_4_grp4.Controllers
{
    [Route("classes")]
    [ApiController]

    public class ClassController : Controller
    {
        private readonly MetaService _service;


        public ClassController(MetaService service)
        {
            _service = service;

        }

        [HttpGet("classes")]
        public async Task<IList<Class>> GetClasses()
        {
            return await _service.GetClasses();
        }
    }
}