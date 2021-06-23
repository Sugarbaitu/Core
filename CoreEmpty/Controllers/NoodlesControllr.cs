using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEmpty.Controllers
{
    [Route("admin/[controller]/[action]")]
    public class NoodlesController : Controller
    {
        [HttpPost]
        public IList<string> Index(int id,IFormCollection formCollection)
        {
            return new List<string> { id + "", "面条", "饼", "豆" };
        }
    }
}
