using LX_webapi.Models;
using Microsoft.AspNetCore.Mvc;

namespace LX_webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {  

        [HttpGet]
        public ActionResult<TestPostViewModel> Get()
        {
            return Ok(new TestPostViewModel { I = 1, Name = "hrw" });
            
        }
    }
}