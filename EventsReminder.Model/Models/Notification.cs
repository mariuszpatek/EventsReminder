using EventsReminder.Common.Clock;
using EventsReminder.Common.Enums;
using System;
using System.Collections.Generic;

namespace EventsReminder.Model.Models
{
    public abstract class Notification
    {
        public Notification()
        {
            Messages = new HashSet<Message>();
            SendNotificationAheadOfTime = new HashSet<SendNotificationAheadOfTime>();
            NotificationsCategories = new HashSet<NotificationCategory>();
        }
        public int NotificationId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime? DateOfLastDispatch { get; set; } 

        public byte SendingHour { get; set; } 

        public bool? IsActive { get; set; }

        public ICollection<Message> Messages { get; set; }

        public ApplicationUser User { get; set; }

        public string UserId { get; set; }

        public NotificationType NotificationType { get; set; }

        public MessageType MessageType { get; set; }

        public ICollection<SendNotificationAheadOfTime> SendNotificationAheadOfTime { get; set; }

        public ICollection<NotificationCategory> NotificationsCategories { get; set; }

        public abstract bool IsMessageReadyToSend();

        protected virtual bool IfMessageWasSentToday()
        {
            if (!DateOfLastDispatch.HasValue)
            {
                return false;
            }
            else
            {
                return DateOfLastDispatch.Value.Date == SystemTime.Now.Date;
            }
        }
    }
}
