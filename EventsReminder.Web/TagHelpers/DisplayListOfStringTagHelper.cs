using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;

namespace EventsReminder.Web.TagHelpers
{
    [HtmlTargetElement("display-as-comma-separated-list")]
    public class DisplayListOfStringTagHelper : TagHelper
    {
        public List<string> InputList { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "span";
            if (InputList != null)
            {
                int j = 1;
                foreach (var item in InputList)
                {
                    output.Content.Append(item);
                    if (j < InputList.Count)
                    {
                        output.Content.Append(", ");
                    }
                    j++;
                }
            }
        }
    }
}
