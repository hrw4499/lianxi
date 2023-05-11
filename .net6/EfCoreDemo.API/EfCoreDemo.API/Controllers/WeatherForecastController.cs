
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
            //���ݻ�ȡ
            //using IKUNContext context = new IKUNContext(); //ǰ���using�����Զ��ͷţ����Ӿ͵��ֶ�Dispose

            //var person = context.People.FirstOrDefault(m=>m.PId==1);

            //ȫ������ȡ������
            //Context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

            //�ֲ����ݸ��ٹر�
            var person = Context.People.AsNoTracking().FirstOrDefault(m => m.PId == 1);            
            person.PAge= 18;
            var asd = Context.People.FirstOrDefault(m => m.PId == 3);
            asd.PGender = "Ů";
            Context.People.Update(asd);
            Context.SaveChanges();
            return person;

        }
        [HttpGet("Get2")]
        public Person Get2()
        {
            //���ݻ�ȡ
            //using IKUNContext context = new IKUNContext(); //ǰ���using�����Զ��ͷţ����Ӿ͵��ֶ�Dispose

            //var person = context.People.FirstOrDefault(m=>m.PId==1);

            //ȫ������ȡ������
            Context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

            //�ֲ����ݸ��ٹر�
            //var person = Context.People.AsNoTracking().FirstOrDefault(m => m.PId == 1);
            //person.PName = "������";
            var asd = Context.People.FirstOrDefault(m => m.PId == 3);
            //asd.PGender = "Ů";
            //Context.People.Update(asd);
            //Context.SaveChanges();
            return asd;

        }
    }
}