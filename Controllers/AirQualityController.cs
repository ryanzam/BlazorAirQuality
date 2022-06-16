using Microsoft.AspNetCore.Mvc;

namespace BlazorAirQuality.Controllers
{
    [ApiController]
    [Route("api/aq")]
    public class AirQualityController : ControllerBase
    {
        [HttpGet]

        public IActionResult Index()
        {
            return Ok("Test");
        }
    }
}
