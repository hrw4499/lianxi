using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvctest.Controllers
{
    public class RouteDemoController : Controller
    {
        // GET: RouteDemo
        public ActionResult Index()
        {
            return View();
        }

        public int Data(DateTime dt) 
        {
            return ( dt - DateTime.Now).Days;
        }
    }
}