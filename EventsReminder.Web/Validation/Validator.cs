using EventsReminder.Common.Clock;
using EventsReminder.Common.Enums;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;

namespace EventsReminder.Web.Validation
{
    public static class Validator
    {
        public static void CheckEventDateForNotification(DateTime? eventDate, string notificationTypeName , ModelStateDictionary modelState)
        {
            if (notificationTypeName == NotificationType.HistoricEvent.ToString())
            {
                if (eventDate > SystemTime.Now)
                {
                    modelState.AddModelError("", "Wybrana data powinna być datą minioną.");
                }
            }

            if (notificationTypeName == NotificationType.OneTimeEvent.ToString())
            {
                if (eventDate <= SystemTime.Now)
                {
                    modelState.AddModelError("", "Wybrana data powinna być datą przyszłą.");
                }
            }
        }
    }
}
