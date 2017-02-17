using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NugetWebsiteModern.Models
{
	public class PackageVersions
	{
		public class Container
		{
			public class SubContainer
			{
				public string CommitId { get; set; }
				public string CommitTimeStamp { get; set; }

				[JsonProperty("items")]
				public List<PackageVersion> Versions { get; set; }
			}

			[JsonProperty("items")]
			public List<SubContainer> Data { get; set; }
		}


		[JsonProperty("items")]
		public List<Container> Data { get; set; }

		public List<PackageVersion> GetVersions() => Data.First().Data.First().Versions;
		public PackageVersion GetLatestVersion() => 
			GetVersions().OrderByDescending(v => v.Package.Version).First();
	}
}
