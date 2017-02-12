using NugetWebsiteModern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NugetWebsiteModern.Repositories
{
    public interface IStatisticsRepository
    {
		Task<Statistics> GetStatistics();
		Task<PackageList> GetPackages(string query = "", int page = 0);
		Task<Package> GetPackage(string id);
	}
}
