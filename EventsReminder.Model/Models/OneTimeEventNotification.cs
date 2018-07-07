using EventsReminder.Common.Clock;
using System;

namespace EventsReminder.Model.Models
{
    public class OneTimeEventNotification : Notification
    {
        public DateTime FutureEventDate { get; set; }

        public override bool IsMessageReadyToSend()
        {
            if (IfMessageWasSentToday() == true)
                return false;

            foreach (var ahedOfTime in SendNotificationAheadOfTime)
            {
                var dateWhenMessageShouldBeSent = FutureEventDate.AddDays(-ahedOfTime.GetNumberOfDays()).Date;
                if (dateWhenMessageShouldBeSent == SystemTime.Now.Date && SendingHour <= SystemTime.Now.Hour)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
