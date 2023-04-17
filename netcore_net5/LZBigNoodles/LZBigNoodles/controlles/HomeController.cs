using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LZBigNoodles.controlles
{
    
    public class HomeController : Controller
    {
        
        public String Index()
        {
            return "Index";
        }

        
        public String About()
        {
            return "About";
        }

       

    }
}
