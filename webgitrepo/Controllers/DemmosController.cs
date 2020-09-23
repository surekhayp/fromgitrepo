using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace webgitrepo.Controllers
{
    public class DemmosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            List<string> langs = new List<string>() {"Python","Go","Ruby","TS","CS","Java" };

            return View(langs);
        }
        
        public IActionResult Samples()
        {
            return View();
        }

    }
}
