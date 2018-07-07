using System.Collections.Generic;

namespace EventsReminder.Model.Models
{
    public class AheadOfTime
    {
        public AheadOfTime()
        {
            SendNotificationAheadOfTime = new HashSet<SendNotificationAheadOfTime>();
        }
        public int AheadOfTimeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int NumberOfDays { get; set; }
        public ICollection<SendNotificationAheadOfTime> SendNotificationAheadOfTime { get; set; }
    }
}
