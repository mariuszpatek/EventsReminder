using System;

namespace EventsReminder.Model.Models
{
    public class Message
    {
        public int MessageId { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime? DateOfSending { get; set; }
        public Notification Notification { get; set; }
        public int NotificationId { get; set; }
        public string MessageTarget { get; set; }
    }
}
