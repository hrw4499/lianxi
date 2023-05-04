using FilterDemo.API.Consts;
using FilterDemo.API.Extensions;
using FilterDemo.API.Models;
using Microsoft.AspNetCore.Mvc.Filters;

namespace FilterDemo.API.Filters
{
    public class CtmAuthorizationFilterAttribute : Attribute,IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var queryString=context.HttpContext.Request.QueryString;
            var dicParams = queryString.Value.GetParameter();
            var hasValue = dicParams.TryGetValue(AuthConst.USERID, out object value);
            if (hasValue)
            {
                int userId = Convert.ToInt32(value);
                var actions = Actions.GetActionByUserId(userId);
                var actionName = context.RouteData.Values["action"].ToString();
                var ControllerName = context.RouteData.Values["controller"].ToString();
                if (!actions.Any(m => m.ActionName == actionName && m.ControllerName == ControllerName))
                {
                    throw new Exception("没有权限");
                }
            }
            else 
            {
                throw new Exception("未拿到用户权限");
            }
            //throw new NotImplementedException();
        }
    }
}
