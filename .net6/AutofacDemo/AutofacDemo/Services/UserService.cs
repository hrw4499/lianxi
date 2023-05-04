using AutofacDemo.Services.IService;

namespace AutofacDemo.Services
{
    public class UserService:IUserService
    {
        public string GetUserName()
        {
            return "hrw";
        }

        
    }
}
