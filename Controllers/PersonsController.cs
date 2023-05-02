using Microsoft.AspNetCore.Mvc;

namespace SampleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var persons = new[]
            {
                "Savindu",
                "Bandara",
                "Pasi boy",
                "Archana"
            }; 
            return Ok(persons);
        }
    }
}
