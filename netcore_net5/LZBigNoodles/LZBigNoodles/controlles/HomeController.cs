using LZBigNoodles.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LZBigNoodles.ViewModels;

namespace LZBigNoodles.controlles
{
    public class HomeController : Controller
    {
        private INoodleRepository _noodleRepository;
        private IFeedbackRepository _feedbackRepository;

        public HomeController(INoodleRepository noodleRepository,IFeedbackRepository feedbackRepository )
        {
            _noodleRepository = noodleRepository;
            _feedbackRepository = feedbackRepository;
        }
        public IActionResult Index()
        {
            //var noodles = _noodleRepository.GetAllNoodles();
            var ViewModel = new HomeViewModel {
                Feedbacks = _feedbackRepository.GETALLFeedbacks().ToList(),
                Noodles= _noodleRepository.GetAllNoodles().ToList()
            };
            return View(ViewModel);
        }


        public String About()
        {
            return "About";
        }

        public ActionResult Contact()
        {
            return View();
        }

        public IActionResult Detail(int id)
        {
            return View(_noodleRepository.GetNoodleById(id));
        }
    }
}
