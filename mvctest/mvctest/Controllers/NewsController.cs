using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvctest.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        IList<string> NewTitlelist = new List<string>();
        int count = new Random().Next(3,5);
        public ActionResult Index()
        {
            for (int i=0;i<count;i++) 
            {
                NewTitlelist.Add("真虾头");
                NewTitlelist.Add("纯鹿人");
                NewTitlelist.Add("真无语");
                NewTitlelist.Add("鸡你太美");
                NewTitlelist.Add("amagi");
            }
            return View(NewTitlelist);
        }
    }
}