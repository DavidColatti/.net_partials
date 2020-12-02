using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace telerik_asp_core.Controllers
{
    public class DavidController : Controller
    {
        public string info = "Type your message, coming from the controller";
        public IActionResult Index()
        {
            ViewBag.Info = info;

            return View();
        }
    }
}
