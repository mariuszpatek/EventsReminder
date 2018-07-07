using Microsoft.AspNetCore.Razor.TagHelpers;

namespace EventsReminder.Web.TagHelpers
{
    [HtmlTargetElement("select", Attributes = "hours-picker")]
    public class HoursPickerTagHelper : TagHelper
    {
        public byte SelectedValue { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {          
            for (int i = 0; i <= 23; i++)
            {
                if (SelectedValue == i)
                {
                    output.Content.AppendHtml($"<option selected value='{i}'>{i}:00</option>");
                }
                else
                {
                    output.Content.AppendHtml($"<option value='{i}'>{i}:00</option>");
                }
            }
        }
    }
}
