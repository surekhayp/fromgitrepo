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
    }
}