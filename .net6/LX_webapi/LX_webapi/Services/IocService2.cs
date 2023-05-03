using LX_webapi.Services.IServices;

namespace LX_webapi.Services
{
    public class IocService2: IIocService2
    {
        public IocService2(ISingletonService singletonService, IScopedService scopedService, ITransientService transientService)
        {
            SingletonService = singletonService;
            ScopedService = scopedService;
            TransientService = transientService;
        }

        public ISingletonService SingletonService { get; }
        public IScopedService ScopedService { get; }
        public ITransientService TransientService { get; }
    }
}
