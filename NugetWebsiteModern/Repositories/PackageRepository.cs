using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NugetWebsiteModern.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace NugetWebsiteModern.Repositories
{
    public class PackageRepository : IPackageRepository
    {
		// page variable does not work (API broken?)
		public async Task<PackageQueryResult> GetPackages(string query = "", int page = 0)
		{
			HttpClient client = new HttpClient();
			var resultString = await client.GetStringAsync($"https://api-v2v3search-0.nuget.org/query?q={query}&page={page}");
			var result = JsonConvert.DeserializeObject<PackageQueryResult>(resultString);
			return result;
		}
		
		public async Task<PackageDetails> GetPackage(string id)
		{
			HttpClient client = new HttpClient();
			var resultString = await client.GetStringAsync($"https://api.nuget.org/v3/registration0/{id.ToLower()}/index.json");

			JObject json_data = JObject.Parse(resultString);
			var json_versions = json_data["items"][0];

			var package_versions = json_versions["items"].ToObject<List<PackageVersion>>();
			var version = package_versions.Where(v => v.Package.Listed).OrderByDescending(v => v.Package.Version).First();

			/*PackageVersion version = new PackageVersion();

			// hack to get package (API changes over packages)
			try
			{
				
				
			}
			catch
			{
				version = json_versions.ToObject<PackageVersion>();
			}*/

			var package = version.Package;
			package.CommitTimeStamp = version.CommitTimeStamp;

			// hack to get number of downloads:
			package.TotalDownloads = GetPackages(id).Result.Data.First().TotalDownloads;

			return await Task.FromResult(package);
		}
	}
}
