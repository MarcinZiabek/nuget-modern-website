using NugetWebsiteModern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NugetWebsiteModern.Repositories
{
	public interface IPackageRepository
    {
		Task<PackageQueryResult> SearchPackage(string query = "", int skip = 0, int take = 20);
		Task<PackageDetails> GetPackage(string id);
	}
}
