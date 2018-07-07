namespace EventsReminder.Model.Models
{
    public class DaysOfWeekWhenSendNotification
    {
        public int DaysOfWeekWhenSendNotificationId { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public int DayOfWeekId { get; set; }
        public PeriodicEventNotification Notification { get; set; }
        public int NotificationId { get; set; }
    }
}
