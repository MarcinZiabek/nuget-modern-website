using NugetWebsiteModern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NugetWebsiteModern.Repositories
{
	public class DistributionsRepository : IDistributionsRepository
	{
		public Task<List<DistributionCategory>> GetDistributions()
		{
			var result = new List<DistributionCategory>();

			result.Add(new DistributionCategory
			{
				Name = "Packages for the Visual Studio",
				Distributions = new List<Distribution>()
				{
					new Distribution()
					{
						Name = "Visual Studio 2013",
						Version = "2.12.0",
						Link = "https://dist.nuget.org/visualstudio-2013-vsix/v2.12.0/NuGet.Tools.vsix"
					},

					new Distribution()
					{
						Name = "Visual Studio 2015",
						Version = "3.5.0",
						Link = "https://dist.nuget.org/visualstudio-2015-vsix/latest/NuGet.Tools.vsix"
					},

					new Distribution()
					{
						Name = "Visual Studio 2017",
						Version = "4.x",
						Link = ""
					}
				}
			});

			result.Add(new DistributionCategory
			{
				Name = "Nuget for the Windows Commandline",
				Distributions = new List<Distribution>()
				{
					new Distribution()
					{
						Name = "Stable",
						Version = "3.5.0",
						Link = "https://dist.nuget.org/win-x86-commandline/latest/nuget.exe"
					},

					new Distribution()
					{
						Name = "Release candidate",
						Version = "4.0.0-rc4",
						Link = "https://dist.nuget.org/win-x86-commandline/v4.0.0-rc4/nuget.exe"
					},

					new Distribution()
					{
						Name = "Nightly",
						Version = "4.0.x",
						Link = "https://dist.nuget.org/visualstudio-2015-vsix/latest/NuGet.Tools.vsix"
					}
				}
			});

			return Task.FromResult(result);
		}
	}
}
