using Microsoft.AspNetCore.Mvc.Filters;

namespace AutofacDemo.Filters
{
    public class CtmActionFilterAttribute : Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            //throw new NotImplementedException();
            Console.WriteLine("OnActionExecuted");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            //throw new NotImplementedException();
            Console.WriteLine("OnActionExecuting");
        }
    }
}
