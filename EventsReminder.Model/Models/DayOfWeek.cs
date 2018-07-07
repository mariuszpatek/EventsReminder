using System.Collections.Generic;

namespace EventsReminder.Model.Models
{
    public class DayOfWeek
    {
        public int DayOfWeekId { get; set; }
        public string Name { get; set; }
        public ICollection<DaysOfWeekWhenSendNotification> DaysOfWeekWhenSendNotification { get; set; }
    }
}
