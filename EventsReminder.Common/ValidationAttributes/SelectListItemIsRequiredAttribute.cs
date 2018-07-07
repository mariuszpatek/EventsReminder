using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace EventsReminder.Common.ValidationAttributes
{
    public class SelectListItemIsRequiredAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
                return false;

            var listOfSelectListItems = (List<SelectListItem>)value;
            var oneOrMoreValuesAreSelected = listOfSelectListItems.Any(l => l.Selected == true);
            return (oneOrMoreValuesAreSelected);
        }
    }
}
