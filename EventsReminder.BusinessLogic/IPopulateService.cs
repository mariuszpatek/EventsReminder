using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EventsReminder.BusinessLogic
{
    public interface IPopulateService
    {
        List<SelectListItem> GetAheadOfTimeValues();
        List<SelectListItem> GetDaysOfWeek();
    }
}