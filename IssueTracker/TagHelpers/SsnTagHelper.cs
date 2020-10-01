using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace IssueTracker.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("pgr-ssn")]
    public class SsnTagHelper : TagHelper
    {
        public string MaskCharacter { get; set; } = "X";
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {

            var childContent = await output.GetChildContentAsync();
            var content = childContent.GetContent().Trim();
            var lastFour = content.Substring(content.Length - 4);
            output.Content.SetHtmlContent($"{MaskCharacter}{MaskCharacter}{MaskCharacter}-{MaskCharacter}{MaskCharacter}-{lastFour}");
        }
    }
}
