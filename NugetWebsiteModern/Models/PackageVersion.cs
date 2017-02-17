using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NugetWebsiteModern.Models
{
    public class PackageVersion
    {
		public string CommitId { get; set; }
		public DateTime CommitTimeStamp { get; set; }
		public string File { get; set; }

		[JsonProperty("catalogEntry")]
		public PackageDetails Package { get; set; }
	}
}
