using CoreEmpty.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreEmpty.ViewModels;
namespace CoreEmpty.Controllers
{
    //[Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        private INoodleRepository _noodleRepository;
        private IFeedbackRepository _feedbackRepository;

        public HomeController(INoodleRepository noodleRepository, IFeedbackRepository feedbackRepository)
        {

            _noodleRepository = noodleRepository;
            _feedbackRepository = feedbackRepository;
        }

        public IActionResult Index()
        {
            //var noodels = _noodleRepository.GetAllNoodles();
            var viewModel = new HomeViewModel()
            {
                Feedbacks = _feedbackRepository.GetAllFeedbacks().ToList(),
                Noodles = _noodleRepository.GetAllNoodles().ToList(),
            };
            return View(viewModel);
        }




        public string About()
        {
            return "string about";
        }
    }
}
