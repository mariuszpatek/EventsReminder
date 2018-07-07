using EventsReminder.Common.Clock;
using EventsReminder.DataAccess.Repositories;
using EventsReminder.Model.Models;
using EventsReminder.Web.Controllers.Api;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace EventsReminder.UnitTests.Api
{
    public class NotificationControllerTests
    {
        private Mock<INotificationRepository> _moqNotificationRepository;
        private Mock<IConfiguration> _moqConfiguration;
        private Mock<ILoggerFactory> _moqLoggerFactory;
        private NotificationController _notificationController;

        [SetUp]
        public void SetUp()
        {
            _moqNotificationRepository = new Mock<INotificationRepository>();
            _moqConfiguration = new Mock<IConfiguration>();
            _moqLoggerFactory = new Mock<ILoggerFactory>();

        //    _notificationController = new NotificationController(_moqNotificationRepository.Object, _moqConfiguration.Object, _moqLoggerFactory.Object);
        }


        [Test]
        public void MarkNotificationAsInactive_PassExistingNotificationId_ShouldSetInactiveParametrToFalse()
        {
            var eventDate = new DateTime(2018, 6, 17, 10, 00, 00);
            SystemTime.Set(eventDate);
            _moqNotificationRepository
                .Setup(m => m.GetAllNotifications())
                .Returns(new List<Notification>
                {
                    new OneTimeEventNotification { Name = "Test 1",
                        FutureEventDate = eventDate,
                        IsActive = true,
                        MessageType = Common.Enums.MessageType.Email,
                        NotificationType = Common.Enums.NotificationType.OneTimeEvent,
                        SendingHour = 10,
                        SendNotificationAheadOfTime = new List<SendNotificationAheadOfTime> { new SendNotificationAheadOfTime { AheadOfTime = new AheadOfTime { NumberOfDays = 0 } } }
                    }
                });


            IActionResult actionResult = _notificationController.SendNotificatonsToUsers();


        }
    }
}
