using AutofacDemo.Services.IService;

namespace AutofacDemo.Services
{
    public class TestService<T> : ITestService<T>
    {
        public string GetTName()
        {
            return typeof(T).Name;
        }
    }
}
