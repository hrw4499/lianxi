using LX_webapi.Services.IServices;

namespace LX_webapi.Services
{
    public class UserService : IUserService
    {
        public string GetUserName()
        {
            return "username";
        }
    }
}
