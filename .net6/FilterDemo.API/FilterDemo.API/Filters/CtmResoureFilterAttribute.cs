using Microsoft.AspNetCore.Mvc.Filters;

namespace FilterDemo.API.Filters
{
    public class CtmResoureFilterAttribute : Attribute, IResourceFilter
    {
        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            //throw new NotImplementedException();
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            //throw new NotImplementedException();
        }
    }
}
