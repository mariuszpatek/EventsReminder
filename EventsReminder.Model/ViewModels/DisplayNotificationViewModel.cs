using System;
using System.Collections.Generic;

namespace EventsReminder.Model.ViewModels
{
    public class DisplayNotificationViewModel
    {
        public int NotificationId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string NotificationTypeName { get; set; }
        public string MessageTypeName { get; set; }
        public DateTime? EventDate { get; set; }
        public List<string> DaysOfWeek { get; set; }
        public List<string> AheadOfTimeValues { get; set; }
        public List<string> Categories { get; set; }
        public byte SendingHour { get; set; }
    }
}
