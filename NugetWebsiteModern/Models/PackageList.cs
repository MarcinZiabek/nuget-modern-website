using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NugetWebsiteModern.Models
{
    public class PackageList
    {
		public int TotalHits { get; set; }
		public List<Package> Data { get; set; }
    }
}
