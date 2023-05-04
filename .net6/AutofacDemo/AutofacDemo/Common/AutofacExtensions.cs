using Autofac;
using AutofacDemo.Services.IService;
using AutofacDemo.Services;
using System.Runtime.CompilerServices;

namespace AutofacDemo.Common
{
    public static class AutofacExtensions
    {
        public static void AddAutofacDemoApiModule(this ContainerBuilder builder)
        {
            ITestService<int> u = new TestService<int>();
            var a = typeof(TestService<>).IsAssignableTo(typeof(ITestService<>));
            builder.RegisterGeneric(typeof(TestService<>)).As(typeof(ITestService<>));
            builder.RegisterType<UserService>().As<IUserService>();
            builder.RegisterType<IocService>().As<IIocService>().PropertiesAutowired();
        }
    }
}
