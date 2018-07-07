using EventsReminder.Model.DTOs;
using EventsReminder.Model.ViewModels;
using System.Collections.Generic;

namespace EventsReminder.BusinessLogic
{
    public interface INotificationService
    {
        void AddNotification(NotificationViewModel notification);
        IEnumerable<DisplayNotificationViewModel> GetAllUserNotificationToDisplay(string userId);
        NotificationViewModel GetUserNotification(string userId, int notificationId);
        void UpdateNotification(string userId, NotificationViewModel notification);
        DispatchNotificationResult SendNotificatonsToUsers();
    }
}