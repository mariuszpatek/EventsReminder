using EventsReminder.DataAccess;
using EventsReminder.DataAccess.Repositories;
using EventsReminder.Model.Models;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EventsReminder.UnitTests.Repositories
{
    [TestFixture]
    public class NotificationRepositoryTests
    {
        private INotificationRepository _notificationRepository;
        private ApplicationDbContext _context;

        [SetUp]
        public void SetUp()
        {
            DbContextOptions<ApplicationDbContext> options;
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
            builder.UseInMemoryDatabase(Guid.NewGuid().ToString());
            options = builder.Options;
            _context = new ApplicationDbContext(options);
            _context.Database.EnsureDeleted();
            _context.Database.EnsureCreated();
            _notificationRepository = new NotificationRepository(_context);
        }

        [Test]
        public void AddNotification_PassOneTimeEventNotification_ShouldSaveThisNotification()
        {
            var notification = new OneTimeEventNotification
            {
                Name = "Test name",
                Description = "Test description",
                SendingHour = 8
            };

            _notificationRepository.AddNotification(notification);
            _notificationRepository.Save();

            var result = _context.Notifications.Count();

            Assert.AreEqual(1, result);
        }

        [Test]
        public void AddNotification_PassHistoricEventNotification_ShouldSaveThisNotification()
        {
            var notification = new HistoricEventNotification
            {
                Name = "Test name",
                Description = "Test description",
                SendingHour = 8
            };

            _notificationRepository.AddNotification(notification);
            _notificationRepository.Save();

            var result = _context.Notifications.Count();

            Assert.AreEqual(1, result);
        }

        [Test]
        public void AddNotification_PassPeriodicEventNotification_ShouldSaveThisNotification()
        {
            var notification = new PeriodicEventNotification
            {
                Name = "Test name",
                Description = "Test description",
                SendingHour = 8
            };

            _notificationRepository.AddNotification(notification);
            _notificationRepository.Save();

            var result = _context.Notifications.Count();

            Assert.AreEqual(1, result);
        }

        [Test]
        public void AddNotification_PassOneTimeEventNotificationWithFutureDateProperty_ShouldSaveThisProperty()
        {
            DateTime futureDate = DateTime.Now.AddDays(3);
            var notification = new OneTimeEventNotification
            {
                Name = "Test name",
                Description = "Test description",
                SendingHour = 8,
                FutureEventDate = futureDate,
                IsActive = true
            };

            _notificationRepository.AddNotification(notification);
            _notificationRepository.Save();

            var result = _notificationRepository.GetNotification(notification.NotificationId) as OneTimeEventNotification;

            Assert.AreEqual(futureDate, result.FutureEventDate);
        }

        [Test]
        public void AddNotification_PassHistoricEventNotificationWithHistoricDateProperty_ShouldSaveThisProperty()
        {
            DateTime pastDate = DateTime.Now.AddDays(-3);
            var notification = new HistoricEventNotification
            {
                Name = "Test name",
                Description = "Test description",
                SendingHour = 8,
                HistoricEventDate = pastDate,
                IsActive = true
            };

            _notificationRepository.AddNotification(notification);
            _notificationRepository.Save();

            var result = _notificationRepository.GetNotification(notification.NotificationId) as HistoricEventNotification;

            Assert.AreEqual(pastDate, result.HistoricEventDate);
        }

        [Test]
        public void AddNotification_PassPeriodicEventNotificationWithDaysOfWeekProperty_ShouldSaveThisProperty()
        {
            var days = new List<DaysOfWeekWhenSendNotification>()
            {
                new DaysOfWeekWhenSendNotification { DayOfWeekId = 1 },
                new DaysOfWeekWhenSendNotification { DayOfWeekId = 6 }
            };
            var notification = new PeriodicEventNotification
            {
                Name = "Test name",
                Description = "Test description",
                SendingHour = 8,
                DaysOfWeekWhenSendNotification = days,
                IsActive = true
            };

            _notificationRepository.AddNotification(notification);
            _notificationRepository.Save();

            var result = _notificationRepository.GetNotification(notification.NotificationId) as PeriodicEventNotification;

            Assert.AreEqual(days.Count, result.DaysOfWeekWhenSendNotification.Count);
        }

        [Test]
        public void GetAllUsersNotifications_PassUserWhichHasActiveNotifications_ShouldReturnAllActiveNotifications()
        {
            var notifications = new List<Notification>()
            {
                new OneTimeEventNotification { Name = "Test notification nr. 1", UserId = "ValidUserId", IsActive = true },
                new HistoricEventNotification { Name = "Test notification nr. 2", UserId = "DiffrentUser", IsActive = true },
                new OneTimeEventNotification { Name = "Test notification nr. 3", UserId = "DiffrentUser", IsActive = true },
                new PeriodicEventNotification { Name = "Test notification nr. 4", UserId = "DiffrentUser", IsActive = true },
                new OneTimeEventNotification { Name = "Test notification nr. 5", UserId = "DiffrentUser", IsActive = false },
                new HistoricEventNotification { Name = "Test notification nr. 6", UserId = "ValidUserId", IsActive = true },
                new PeriodicEventNotification { Name = "Test notification nr. 7", UserId = "ValidUserId", IsActive = false},
            };
            _context.AddRange(notifications);
            _context.SaveChanges();

            var result = _notificationRepository.GetAllUsersNotifications("ValidUserId");

            Assert.AreEqual(2, result.Count());
        }
    }
}
