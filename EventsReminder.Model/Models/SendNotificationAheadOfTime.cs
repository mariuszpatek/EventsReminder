namespace EventsReminder.Model.Models
{
    public class SendNotificationAheadOfTime
    {
        public int SendNotificationAheadOfTimeId { get; set; }
        public int NotificationId { get; set; }
        public int AheadOfTimeId { get; set; }
        public Notification Notification { get; set; }
        public AheadOfTime AheadOfTime { get; set; }

        public int GetNumberOfDays()
        {
            return AheadOfTime.NumberOfDays;
        }
    }
}
