using LX_webapi.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LX_webapi.Controllers
{
    //[EnableCors("any")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Testhrw";
        }
        [HttpGet("{name}-{i}")]
        public string Get2(int i,string name)
        {
            return name+i;
        }
        [HttpPost]
        public string Post(TestPostViewModel model)
        {
            return model.Name + model.I;
        }
        [HttpPut]
        public string Put()
        {
            return "Put";
        }
        [HttpDelete]
        public string Delete()
        {
            return "Delete";
        }
    }
}
