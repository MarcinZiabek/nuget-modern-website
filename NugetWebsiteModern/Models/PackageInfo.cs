using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NugetWebsiteModern.Models
{
    public class PackageInfo
    {
		[JsonProperty("@id")]
		public string DataUrl { get; set; }

		public string Id { get; set; }
		public string Version { get; set; }
		public string Description { get; set; }
		public string Title { get; set; }
		public string Summary { get; set; }
		public string IconUrl { get; set; }
		public string ProjectUrl { get; set; }
		public string LicenseUrl { get; set; }

		public int TotalDownloads { get; set; }
		public string CommitTimeStamp { get; set; }

		public List<string> Authors { get; set; }
		public List<string> Tags { get; set; }
	}
}
