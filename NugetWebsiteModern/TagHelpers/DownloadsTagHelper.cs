using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace NugetWebsiteModern.TagHelpers
{
    public class DownloadsTagHelper : TagHelper
    {
		public int Number { get; set; }

		public override void Process(TagHelperContext context, TagHelperOutput output)
		{
			output.TagName = "span";
			output.TagMode = TagMode.StartTagAndEndTag;

			string stringFormat = "#,#";

			if (Number > 1000 * 1000)
				stringFormat = "#,##0,, M";

			else if (Number > 1000)
				stringFormat = "#,##0, K";

			var content = Number.ToString(stringFormat);
			output.Content.SetContent(content);
		}
	}
}
