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

		public IActionResult Download()
		{
			return View();
		}

		public IActionResult Error()
        {
            return View();
		}
	}
}
