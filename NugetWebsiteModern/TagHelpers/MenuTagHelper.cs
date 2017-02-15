using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NugetWebsiteModern.TagHelpers
{
	[HtmlTargetElement("a", Attributes= tag)]
	public class MenuTagHelper : TagHelper
    {
		private const string tag = "menu-highlight";

		[HtmlAttributeName(tag)]
		public string ActivationPath { get; set; }

		[HtmlAttributeName("asp-controller")]
		public string Controller { get; set; }

		[ViewContext]
		public ViewContext ViewContext { get; set; }

		public override void Process(TagHelperContext context, TagHelperOutput output)
		{
			string currentController = (string)ViewContext.RouteData.Values["controller"];
			string currentAction = (string)ViewContext.RouteData.Values["action"];

			string currentPage = $"/{currentController}/{currentAction}";

			if (ActivationPath.EndsWith("*"))
			{
				if (currentPage.StartsWith(ActivationPath.TrimEnd('*')))
					AddActiveClass(output);
			}
			else
			{
				if (currentPage == ActivationPath)
					AddActiveClass(output);
			}
		}

		private void AddActiveClass(TagHelperOutput output)
		{
			string currentClass = "";

			if (output.Attributes.ContainsName("class"))
				currentClass = output.Attributes["class"].Value as string;

			currentClass += " active";

			output.Attributes.RemoveAll("class");
			output.Attributes.Add("class", currentClass);
		}
	}
}
