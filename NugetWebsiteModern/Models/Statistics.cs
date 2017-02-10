using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NugetWebsiteModern.Models
{
    public class Statistics
    {
		public int UniquePackages { get; set; }
		public int TotalPackages { get; set; }
		public int Downloads { get; set; }
	}
}
