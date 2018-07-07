using EventsReminder.Model.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace EventsReminder.DataAccess.Repositories
{
    public class NotificationRepository : INotificationRepository
    {
        private readonly ApplicationDbContext _context;
        public NotificationRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        public void AddNotification(Notification notification)
        {
            _context.Notifications.AddAsync(notification);
        }

        public Notification GetNotification(int notificationId)
        {
            var notification = _context.Notifications
                .Where(n => n.NotificationId == notificationId && n.IsActive == true)
                .Include(n => n.SendNotificationAheadOfTime)
                    .ThenInclude(a => a.AheadOfTime)
                .AsQueryable();

            notification.OfType<PeriodicEventNotification>()
                .Include(n => n.DaysOfWeekWhenSendNotification)
                    .ThenInclude(d => d.DayOfWeek)
                .Load();

            return notification.SingleOrDefault();
        }

        public IEnumerable<Notification> GetAllUsersNotifications(string userId)
        {
            var notifications = _context.Notifications
                .Where(n => n.UserId == userId && n.IsActive == true)
                .Include(n => n.SendNotificationAheadOfTime)
                    .ThenInclude(a => a.AheadOfTime)
                .Include(n => n.NotificationsCategories)
                    .ThenInclude(nc => nc.Category)
                .AsQueryable();

            notifications.OfType<PeriodicEventNotification>()
                .Include(n => n.DaysOfWeekWhenSendNotification)
                    .ThenInclude(d => d.DayOfWeek)
                .Load();

            return notifications.ToList();
        }

        public IEnumerable<Notification> GetAllNotifications()
        {
            var notifications = _context.Notifications
                .Where(n => n.IsActive == true)
                .Include(n => n.SendNotificationAheadOfTime)
                    .ThenInclude(a => a.AheadOfTime)
                .Include(n => n.User)
                .Include(n => n.NotificationsCategories)
                    .ThenInclude(nc => nc.Category)
                .AsQueryable();

            notifications.OfType<PeriodicEventNotification>()
                .Include(n => n.DaysOfWeekWhenSendNotification)
                    .ThenInclude(d => d.DayOfWeek)
                .Load();

            return notifications.ToList();
        }

        public void UpdateNotification(Notification notification)
        {
            _context.Notifications.Update(notification);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
