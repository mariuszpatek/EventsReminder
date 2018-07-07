using System.Collections.Generic;

namespace EventsReminder.Model.Models
{
    public class Category
    {
        public Category()
        {
            NotificationsCategories = new HashSet<NotificationCategory>();
        }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public ICollection<NotificationCategory> NotificationsCategories { get; set; }
    }
}
