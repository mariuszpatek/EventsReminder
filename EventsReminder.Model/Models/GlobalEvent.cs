using System;

namespace EventsReminder.Model.Models
{
    public class GlobalEvent
    {
        public int GlobalEventId { get; set; }
        public string Content { get; set; }
        public DateTime DateTime { get; set; }
    }
}
