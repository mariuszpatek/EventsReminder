namespace EventsReminder.Model.Models
{
    public class NotificationCategory
    {
        public int NotificationCategoryId { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public Notification Notification { get; set; }
        public int NotificationId { get; set; }
    }
}
