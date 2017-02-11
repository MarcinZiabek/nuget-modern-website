using NugetWebsiteModern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NugetWebsiteModern.Repositories
{
    interface IDistributionsRepository
    {
		Task<List<DistributionCategory>> GetDistributions();
	}
}
