using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NugetWebsiteModern.Models
{
	public class PackageOverview
	{
		[JsonProperty("@id")]
		public string DataUrl { get; set; }

		public string Id { get; set; }
		public string Version { get; set; }
		public string Title { get; set; }
		public string IconUrl { get; set; }

		public int TotalDownloads { get; set; }
	}
}
