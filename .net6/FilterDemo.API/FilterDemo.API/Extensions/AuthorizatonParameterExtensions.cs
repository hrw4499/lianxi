using Microsoft.AspNetCore.Http;
using System.Runtime.CompilerServices;

namespace FilterDemo.API.Extensions
{
    public static class AuthorizatonParameterExtensions
    {
        public static Dictionary<string,Object> GetParameter(this string value)
        {
            var param = value.Replace("?", "");
            var parameters = param.Split("&");
            Dictionary<string, object> dicparams = new();
            foreach (var item in parameters)
            {
                var res = item.Split("=");
                dicparams.Add(res[0].Trim(), res[1].Trim());
            }
            return dicparams;
        }
    }
}
