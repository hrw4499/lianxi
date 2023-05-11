
using EfCoreDemo.API.Entities;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EfCoreDemo.API.Controllers
{
    [EnableCors("any")]
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {  
        public IKUNContext Context { get; set; }
        public WeatherForecastController(IKUNContext context)
        {
            this.Context = context;
        }

       

        [HttpGet("Get1")]
        public Person Get1()
        {
            //数据获取
            //using IKUNContext context = new IKUNContext(); //前面加using就能自动释放，不加就得手动Dispose

            //var person = context.People.FirstOrDefault(m=>m.PId==1);

            //全局数据取消跟踪
            //Context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

            //局部数据跟踪关闭
            var person = Context.People.AsNoTracking().FirstOrDefault(m => m.PId == 1);            
            person.PAge= 18;
            var asd = Context.People.FirstOrDefault(m => m.PId == 3);
            asd.PGender = "女";
            Context.People.Update(asd);
            Context.SaveChanges();
            return person;

        }
        [HttpGet("Get2")]
        public Person Get2()
        {
            //数据获取
            //using IKUNContext context = new IKUNContext(); //前面加using就能自动释放，不加就得手动Dispose

            //var person = context.People.FirstOrDefault(m=>m.PId==1);

            //全局数据取消跟踪
            Context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

            //局部数据跟踪关闭
            //var person = Context.People.AsNoTracking().FirstOrDefault(m => m.PId == 1);
            //person.PName = "蔡徐坤";
            var asd = Context.People.FirstOrDefault(m => m.PId == 3);
            //asd.PGender = "女";
            //Context.People.Update(asd);
            //Context.SaveChanges();
            return asd;

        }
    }
}