	using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NugetWebsiteModern.Models
{
    public class PackageDetails
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
		public string PackageContent { get; set; }
		public int TotalDownloads { get; set; }
		public bool Listed { get; set; }
		public DateTime CommitTimeStamp { get; set; }
		public string Authors { get; set; }
		public List<string> Tags { get; set; }
	}
}
