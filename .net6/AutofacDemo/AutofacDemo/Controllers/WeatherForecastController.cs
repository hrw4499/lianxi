using AutofacDemo.Filters;
using AutofacDemo.Services;
using AutofacDemo.Services.IService;
using Microsoft.AspNetCore.Mvc;

namespace AutofacDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IIocService iocService;
        public ITestService<WeatherForecast> BaseService { get; }
        public WeatherForecastController(IIocService iocService,ITestService<WeatherForecast> baseService)
        {
            this.iocService = iocService;
            this.BaseService = baseService;
        }

        

        [HttpGet(Name = "GetWeatherForecast")]
        [CtmActionFilter]
        public String Get()
        {
            var b=Check();
            if (b) 
            {
                return ToCar();
            }
            else 
            {
                return "���ʸ��ϳ�";
            }
            
        }
        private string ToCar()
        {
            return "�ϳ�";
        }
        private bool Check()
        {
            return true;
        }
    }
}