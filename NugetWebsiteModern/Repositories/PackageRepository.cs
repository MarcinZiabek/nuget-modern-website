using Newtonsoft.Json;
using NugetWebsiteModern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace NugetWebsiteModern.Repositories
{
    public class PackageRepository : IPackageRepository
    {
		public async Task<PackageList> GetPackages(string query = "", int page = 0)
		{
			HttpClient client = new HttpClient();
			var resultString = await client.GetStringAsync($"https://api-v2v3search-0.nuget.org/query?q={query}&page={page}");
			var result = JsonConvert.DeserializeObject<PackageList>(resultString);
			return result;
		}

		public async Task<Package> GetPackage(string id)
		{
			var packages = GetPackages(id).Result.Data;
			var package = packages.SingleOrDefault(p => p.Id == id);
			return await Task.FromResult(package);
		}
	}
}
