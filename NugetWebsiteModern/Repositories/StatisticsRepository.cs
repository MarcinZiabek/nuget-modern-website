using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

using Newtonsoft.Json;
using NugetWebsiteModern.Models;

namespace NugetWebsiteModern.Repositories
{
    public class StatisticsRepository : IStatisticsRepository
    {
		public async Task<Statistics> GetStatistics()
		{
			HttpClient client = new HttpClient();
			var resultString = await client.GetStringAsync("https://api.nuget.org/v3/stats0/totals.json");
			var result = JsonConvert.DeserializeObject<Statistics>(resultString);
			return result;
		}

		public async Task<PackageList> GetPackages()
		{
			HttpClient client = new HttpClient();
			var resultString = await client.GetStringAsync("https://api-v2v3search-0.nuget.org/query");
			var result = JsonConvert.DeserializeObject<PackageList>(resultString);
			return result;
		}
	}
}
