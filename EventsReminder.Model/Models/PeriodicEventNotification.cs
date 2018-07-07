using EventsReminder.Common.Clock;
using System.Collections.Generic;

namespace EventsReminder.Model.Models
{
    public class PeriodicEventNotification : Notification
    {
        public PeriodicEventNotification()
        {
            DaysOfWeekWhenSendNotification = new HashSet<DaysOfWeekWhenSendNotification>();
        }

        public ICollection<DaysOfWeekWhenSendNotification> DaysOfWeekWhenSendNotification { get; set; }

        public override bool IsMessageReadyToSend()
        {
            if (IfMessageWasSentToday() == true)
                return false;

            foreach (var ahedOfTimeValue in SendNotificationAheadOfTime)
            {
                if (checkIfTodayIsDayForSendMessage(ahedOfTimeValue) && SendingHour <= SystemTime.Now.Hour)
                {
                    return true;
                }
            }

            return false;
        }

        private bool checkIfTodayIsDayForSendMessage(SendNotificationAheadOfTime sendNotificationAheadOfTime)
        {
            var currentDayOfWeekId = (int)SystemTime.Now.DayOfWeek;
            var aheadOfTimeNumberOfDays = sendNotificationAheadOfTime.GetNumberOfDays();

            foreach (var dayOfWeek in DaysOfWeekWhenSendNotification)
            {
                int idOfDayWhenMessageShouldBeSent = dayOfWeek.DayOfWeekId - aheadOfTimeNumberOfDays;
                if (idOfDayWhenMessageShouldBeSent >= 0)
                {
                    if (idOfDayWhenMessageShouldBeSent == currentDayOfWeekId)
                    {
                        return true;
                    }
                }
                else
                {
                    if ((7 + idOfDayWhenMessageShouldBeSent) == currentDayOfWeekId)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
