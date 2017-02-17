using NugetWebsiteModern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NugetWebsiteModern.Repositories
{
	public interface IPackageRepository
    {
		Task<PackageList> GetPackages(string query = "", int page = 0);
		Task<PackageInfo> GetPackage(string id);
	}
}
