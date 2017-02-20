using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace azure_webapp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var webMsg = System.Environment.MachineName; 
            ViewData["WebMsg"] = webMsg;
            ViewData["Message"] = DateTime.UtcNow.ToString("O");
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
