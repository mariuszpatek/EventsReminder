using EventsReminder.Common.Clock;
using EventsReminder.Model.Models;
using NUnit.Framework;

namespace EventsReminder.UnitTests.MessagesSending
{
    public class NotificationTests
    {
        [TearDown]
        protected void TearDown()
        {
            SystemTime.Reset();
        }

        protected void SetAheadOfTimeValuesForNotification(Model.Models.Notification notification, params int[] numberOfDaysValues )
        {
            int i = 0;
            foreach (var numberOfDays in numberOfDaysValues)
            {
                notification
                    .SendNotificationAheadOfTime
                    .Add
                    (
                        new SendNotificationAheadOfTime
                        {
                            AheadOfTime = new AheadOfTime { NumberOfDays = numberOfDays },
                            AheadOfTimeId = i,
                            NotificationId = notification.NotificationId
                        }
                    );
                i++;
            }
        }

        protected void SetDaysOfWeekForNotification(Model.Models.Notification notification, params int[] daysOfWeekIds)
        {
            foreach (var id in daysOfWeekIds)
            {
                (notification as PeriodicEventNotification)
                    .DaysOfWeekWhenSendNotification
                    .Add
                    (
                        new DaysOfWeekWhenSendNotification
                        {
                            DayOfWeekId = id,
                            NotificationId = notification.NotificationId
                        }
                    );
            }
        }
    }
}
