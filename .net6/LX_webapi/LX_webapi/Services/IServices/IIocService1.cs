namespace LX_webapi.Services.IServices
{
    public interface IIocService1
    {
        public ISingletonService SingletonService { get; }
        public IScopedService ScopedService { get; }
        public ITransientService TransientService { get; }
    }
}