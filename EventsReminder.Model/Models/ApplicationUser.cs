using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace EventsReminder.Model.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            Notifications = new HashSet<Notification>();
        }
        public ICollection<Notification> Notifications { get; set; }
    }
}
