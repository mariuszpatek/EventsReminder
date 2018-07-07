using EventsReminder.Common.Clock;
using System;

namespace EventsReminder.Model.Models
{
    public class HistoricEventNotification : Notification
    {
        public DateTime HistoricEventDate { get; set; }

        public override bool IsMessageReadyToSend()
        {
            if (IfMessageWasSentToday() == true)
                return false;

            var anniversaryDate = new DateTime(SystemTime.Now.Year, HistoricEventDate.Month, HistoricEventDate.Day);

            foreach (var aheadOfTimeValue in SendNotificationAheadOfTime)
            {
                var dateWhenMessageShouldBeSent = anniversaryDate.AddDays(-aheadOfTimeValue.GetNumberOfDays()).Date;
                if (dateWhenMessageShouldBeSent == SystemTime.Now.Date && SendingHour <= SystemTime.Now.Hour)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
