using EventsReminder.Common;
using EventsReminder.Common.Enums;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;

namespace EventsReminder.Web.TagHelpers
{
    [HtmlTargetElement("div", Attributes = "radio-notificationType")]
    public class RadioNotificationTypeTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            TagHelperAttribute checkedValue;
            context.AllAttributes.TryGetAttribute("checked-value", out checkedValue);
            foreach (var value in Enum.GetValues(typeof(NotificationType)))
            {
                output.Content.AppendHtml($"<div style='padding-left: 0' class='form-check'>");
                output.Content.AppendHtml($"<label class='form-check-label pointer'>");
                output.Content.AppendHtml($"<input class='pointer'");
                if (checkedValue?.Value?.ToString() == value.ToString())
                {
                    output.Content.AppendHtml(" checked");
                }
                output.Content.AppendHtml($" name='{nameof(NotificationType)}' type='radio' class='form-check-input' value={value} />");
                output.Content.AppendHtml($" {((NotificationType)value).GetEnumDisplayName()}");
                output.Content.AppendHtml($"</label>");
                output.Content.AppendHtml($" <small class='form-text text-muted'>{((NotificationType)value).GetEnumDisplayDescription()}</small>");
                output.Content.AppendHtml($"</div>");
            }
        }
    }
}
