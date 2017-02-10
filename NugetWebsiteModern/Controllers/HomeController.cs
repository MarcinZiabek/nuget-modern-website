using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NugetWebsiteModern.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Packages()
        {
            ViewData["Message"] = "Here will be the lists of available packages.";

            return View();
        }

        public IActionResult Statistics()
        {
            ViewData["Message"] = "Here will be some awesome charts.";

            return View();
        }

		public IActionResult Documentation()
		{
			ViewData["Message"] = "What about a little bit of documentation?";

			return View();
		}

		public IActionResult Download()
		{
			ViewData["Message"] = "Let's download some useful content!";

			return View();
		}

		public IActionResult Blog()
		{
			ViewData["Message"] = "Yesterday, I have done really good stuff...";

			return View();
		}

		public IActionResult Error()
        {
            return View();
		}
	}
}
