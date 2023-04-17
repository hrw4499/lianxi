using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LZBigNoodles.controlles
{
    [Route("admin/[controller]/[action]")]
    public class UserController : Controller
    {
        
        public IList<string> Index()
        {
            return new List<string> { "阿松大"," 大苏打","算法","阿萨大大"};
        }
    }
}
