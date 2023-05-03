namespace LX_webapi.Services.IServices
{
    public interface IIocService2
    {
        public ISingletonService SingletonService { get; }
        public IScopedService ScopedService { get; }
        public ITransientService TransientService { get; }
    }
}