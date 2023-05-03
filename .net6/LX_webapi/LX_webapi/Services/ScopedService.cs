using LX_webapi.Services.IServices;

namespace LX_webapi.Services
{
    public class ScopedService: IScopedService
    {
        public int count { get; set; }
        public ScopedService()
        {
            
        }
        public void Plus()
        {
            count++;
        }
    }
}
