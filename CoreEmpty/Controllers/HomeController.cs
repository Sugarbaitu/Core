using CoreEmpty.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEmpty.Controllers
{
    //[Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        private INoodleRepository _noodleRepository;


        public HomeController(INoodleRepository noodleRepository)
        {
            _noodleRepository = noodleRepository;
        }

        public IActionResult Index()
        {
            var noodels = _noodleRepository.GetAllNoodles();
            return View(noodels);
        }


        public string About()
        {
            return "string about";
        }
    }
}
