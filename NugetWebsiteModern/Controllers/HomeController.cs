using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NugetWebsiteModern.Repositories;

namespace NugetWebsiteModern.Controllers
{
    public class HomeController : Controller
    {
		private IStatisticsRepository StatisticsRepositiory;

		public HomeController(IStatisticsRepository statisticsRepositiory)
		{
			StatisticsRepositiory = statisticsRepositiory;
		}

        public IActionResult Index()
        {
			ViewData["Statistics"] = StatisticsRepositiory.GetStatistics().Result;

            return View();
        }

		public IActionResult Packages([FromQuery] string query="", [FromQuery] int page=0)
        {
			var packages = StatisticsRepositiory.GetPackages(query, page).Result;

			ViewData["Query"] = query;
			ViewData["Page"] = page;
			ViewData["Packages"] = packages.Data;
			ViewData["Results"] = packages.TotalHits;

			return View();
        }

		public IActionResult Package(string id)
		{
			ViewData["ID"] = id;

			ViewData["Package"] = StatisticsRepositiory.GetPackage(id).Result;


			return View();
		}

		public IActionResult Statistics()
        {
            ViewData["Message"] = "Here will be some awesome charts.";

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
