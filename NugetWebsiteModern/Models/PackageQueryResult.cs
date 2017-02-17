using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NugetWebsiteModern.Models
{
    public class PackageQueryResult
    {
		public int TotalHits { get; set; }
		public List<PackageOverview> Data { get; set; }
    }
}
