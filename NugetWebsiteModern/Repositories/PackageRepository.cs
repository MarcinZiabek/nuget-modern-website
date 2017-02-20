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
		public async Task<PackageQueryResult> SearchPackage(string query = "", int skip = 0, int take = 20)
		{
			HttpClient client = new HttpClient();
			var resultString = await client.GetStringAsync($"https://api-v2v3search-0.nuget.org/query?q={query}&skip={skip}&take={take}");
			var result = JsonConvert.DeserializeObject<PackageQueryResult>(resultString);
			return result;
		}
		
		public async Task<PackageDetails> GetPackage(string id)
		{
			HttpClient client = new HttpClient();
			var resultString = await client.GetStringAsync($"https://api.nuget.org/v3/registration0/{id.ToLower()}/index.json");

			JObject json_data = JObject.Parse(resultString);
			var json_versions = json_data["items"];

			if (json_versions.Count() != 1)
			{
				var new_address = json_versions.OrderByDescending(v => v["upper"]).Last()["@id"];
				resultString = await client.GetStringAsync((string)new_address);
				json_versions = JObject.Parse(resultString);
			}
			else
			{
				json_versions = json_versions.Last();

			}

			var package_versions = json_versions["items"].ToObject<List<PackageVersion>>();
			var version = package_versions.Where(v => v.Package.Listed).OrderByDescending(v => v.Package.Version).First();

			var package = version.Package;
			package.CommitTimeStamp = version.CommitTimeStamp;

			// hack to get number of downloads:
			package.TotalDownloads = SearchPackage(id).Result.Data.First().TotalDownloads;

			return await Task.FromResult(package);
		}
	}
}
