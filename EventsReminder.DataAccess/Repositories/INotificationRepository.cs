using EventsReminder.Model.Models;
using System.Collections.Generic;

namespace EventsReminder.DataAccess.Repositories
{
    public interface INotificationRepository
    {
        void AddNotification(Notification notification);
        IEnumerable<Notification> GetAllUsersNotifications(string userId);
        Notification GetNotification(int notificationId);
        void UpdateNotification(Notification notification);
        IEnumerable<Notification> GetAllNotifications();
        void Save();
    }
}