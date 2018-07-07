using System.Collections.Generic;

namespace EventsReminder.Model.DTOs
{
    public class DispatchNotificationResult
    {
        public DispatchNotificationResult()
        {
            sentNotifications = new List<NotificationDto>();
            notSentNotifications = new List<NotificationDto>();
        }

        public List<NotificationDto> sentNotifications { get; set; }
        public List<NotificationDto> notSentNotifications { get; set; }
        public string Message { get; set; }
    }
}
