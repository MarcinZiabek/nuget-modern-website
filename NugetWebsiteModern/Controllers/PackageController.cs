using Microsoft.AspNetCore.Mvc;
using NugetWebsiteModern.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NugetWebsiteModern.Controllers
{
    public class PackageController : Controller
    {
		private IPackageRepository PackageRepository { get; set; }

		private const int PackagePageSize = 20;

		public PackageController(IPackageRepository packageRepository)
		{
			PackageRepository = packageRepository;
		}

		public IActionResult List([FromQuery] string query = "", [FromQuery] int page = 0)
		{
			var packages = PackageRepository.SearchPackage(query, skip: PackagePageSize*page, take: PackagePageSize).Result;

			ViewData["Query"] = query;
			ViewData["Page"] = page;
			ViewData["Packages"] = packages.Data;
			ViewData["Results"] = packages.TotalHits;

			return View();
		}

		public IActionResult Show(string id)
		{
			ViewData["ID"] = id;

			ViewData["Package"] = PackageRepository.GetPackage(id).Result;


			return View();
		}
	}
}
