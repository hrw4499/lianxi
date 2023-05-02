using Microsoft.AspNetCore.Mvc;

namespace LX_webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
       

        [HttpGet]
        public string Get()
        {
            return "hrw";
            
        }
    }
}