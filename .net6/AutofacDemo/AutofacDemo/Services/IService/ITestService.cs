namespace AutofacDemo.Services.IService
{
    public interface ITestService<T> : ITestService
    {
        string GetTName();
    }

    public interface ITestService
    {
        string GetTName();
    }
}
