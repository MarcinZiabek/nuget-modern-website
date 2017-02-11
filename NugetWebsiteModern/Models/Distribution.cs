using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NugetWebsiteModern.Models
{
	public class Distribution
	{
		public string Name { get; set; }
		public Uri Link { get; set; }
	}

	public class DistributionCategory
    {
		public string Name { get; set; }
		public List<Distribution> Distributions { get; set; }
	}
}
