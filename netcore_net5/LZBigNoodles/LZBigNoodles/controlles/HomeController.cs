using LZBigNoodles.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LZBigNoodles.controlles
{
    public class HomeController : Controller
    {
        private INoodleRepository _noodleRepository;

        public HomeController(INoodleRepository noodleRepository)
        {
            _noodleRepository = noodleRepository;
        }
        public IActionResult Index()
        {
            var noodles = _noodleRepository.GetAllNoodles();
            return View(noodles);
        }


        public String About()
        {
            return "About";
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}
