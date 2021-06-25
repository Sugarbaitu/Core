using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEmpty.Controllers
{
    [Controller]
    public class Test : Controller
    {
        public string Index()
        {
            return "hello from Test";
        }


        public string About()
        {
            return "string Test";
        }


        public ActionResult Contact()
        {
            return View();
        }
    }
}
