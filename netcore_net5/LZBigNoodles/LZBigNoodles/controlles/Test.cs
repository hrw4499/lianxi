using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LZBigNoodles.controlles
{

    
    //public class TestController,no.1普通类名加上Controller

    //[Controller]//no.2
    public class Test:Controller//继承Controller类
    {
        public String Index()
        {
            return "test Index";
        }


        public String About()
        {
            return "test About";
        }
    }
}
