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
		private IDistributionsRepository DistributionRepository;

		public HomeController(
			IStatisticsRepository statisticsRepositiory,
			IDistributionsRepository distributionRepository)
		{
			StatisticsRepositiory = statisticsRepositiory;
			DistributionRepository = distributionRepository;
		}

        public IActionResult Index()
        {
			ViewData["Statistics"] = StatisticsRepositiory.GetStatistics().Result;
            return View();
        }

		public IActionResult Download()
		{
			ViewData["Distributions"] = DistributionRepository.GetDistributions().Result;
			return View();
		}

		public IActionResult Error()
        {
            return View();
		}
	}
}
