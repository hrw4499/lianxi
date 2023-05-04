namespace AutofacDemo.Services.IService
{
    public interface IIocService
    {
        public IUserService userService { get; set; }
    }
}