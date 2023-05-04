using AutofacDemo.Services.IService;

namespace AutofacDemo.Services
{
    public class IocService: IIocService
    {
        public IUserService userService { get; set; }
        //public IocService(IUserService userService) 
        //{

        //}
    }
}
