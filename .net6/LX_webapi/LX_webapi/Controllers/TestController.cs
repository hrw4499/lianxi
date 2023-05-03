using LX_webapi.Models;
using LX_webapi.Services.IServices;
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
        public IUserService UserService { get; }
        public IIocService1 IocService1 { get; }
        public IIocService2 IocService2 { get; }

        public TestController(IIocService1 iocService1,IIocService2 iocService2) 
        {
            
            IocService1 = iocService1;
            this.IocService2 = iocService2;
            iocService1.ScopedService.Plus();
            iocService2.ScopedService.Plus();
        }
        [HttpGet]
        public string Get()
        {
            
            return UserService.GetUserName();
        }
        
        [HttpPost]
        public string Post(TestPostViewModel model)
        {
            return model.Name + model.I;
        }
        [HttpPut]
        public void Put(int id,TestPostEditViewModel model)
        {
            
        }
        [HttpDelete]
        public void Delete(int id)
        {
            
        }
    }
}
