using EventsReminder.Common.Clock;
using EventsReminder.Model.Models;
using NUnit.Framework;
using System;

namespace EventsReminder.UnitTests.MessagesSending
{
    public class HistoricEventNotificationTests: NotificationTests
    {
        private HistoricEventNotification notification;

        [SetUp]
        public void SetUp()
        {
            notification = new HistoricEventNotification
            {
                Name = "Test notification"
            };
        }

        [Test]
        public void IsMessageReadyToSend_Variant1_MethodShouldReturnTrue()
        {
            // Notification Should Be Sent: 15.06.2018
            notification.HistoricEventDate = new DateTime(1993, 6, 15);
            SetAheadOfTimeValuesForNotification(notification, 0); // Ahead Of Time (Number of days): 0
            notification.SendingHour = 8;

            // Current Date: 15.06.2018 15:00
            SystemTime.Set(new DateTime(2018, 6, 15, 15, 0, 0));

            var result = notification.IsMessageReadyToSend();

            Assert.AreEqual(true, result);
        }

        [Test]
        public void IsMessageReadyToSend_Variant2_MethodShouldReturnTrue()
        {
            // Notification Should Be Sent: 15.06.2018
            notification.HistoricEventDate = new DateTime(1993, 6, 15);
            SetAheadOfTimeValuesForNotification(notification, 0); // Ahead Of Time (Number of days): 0
            notification.SendingHour = 8;

            // Current Date: 15.06.2018 16:00
            SystemTime.Set(new DateTime(2018, 6, 15, 16, 0, 0));

            var result = notification.IsMessageReadyToSend();

            Assert.AreEqual(true, result);
        }

        [TestCase(6, 15)]
        [TestCase(6, 14)]
        [TestCase(6, 8)]
        public void IsMessageReadyToSend_Variant3_MethodShouldReturnTrue(int month, int day)
        {
            // Notification Should Be Sent: 15.06.2018, 14, 8
            notification.HistoricEventDate = new DateTime(1993, 6, 15);
            SetAheadOfTimeValuesForNotification(notification, 0, 1, 7);
            notification.SendingHour = 8;

            // Current Date: 15.06.2018 16:00
            SystemTime.Set(new DateTime(2018, month, day, 16, 0, 0));

            var result = notification.IsMessageReadyToSend();

            Assert.AreEqual(true, result);
        }

        [Test]
        public void IsMessageReadyToSend_Variant4_MethodShouldReturnTrue()
        {
            // Notification Should Be Sent: 15.06.2018
            notification.HistoricEventDate = new DateTime(1993, 6, 15);
            SetAheadOfTimeValuesForNotification(notification, 0); // Ahead Of Time (Number of days): 0
            notification.DateOfLastDispatch = new DateTime(2018, 05, 17); // Long time age
            notification.SendingHour = 8;

            // Current Date: 15.06.2018 8:00
            SystemTime.Set(new DateTime(2018, 6, 15, 8, 0, 0));

            var result = notification.IsMessageReadyToSend();

            Assert.AreEqual(true, result);
        }

        [Test]
        public void IsMessageReadyToSend_Variant5_MethodShouldReturnFalse()
        {
            // Notification Should Be Sent: 15.06.2018
            notification.HistoricEventDate = new DateTime(1993, 6, 15);
            SetAheadOfTimeValuesForNotification(notification, 0); // Ahead Of Time (Number of days): 0
            notification.DateOfLastDispatch = new DateTime(2018, 6, 15); // Message was sent today
            notification.SendingHour = 8;

            // Current Date: 15.06.2018 8:00
            SystemTime.Set(new DateTime(2018, 6, 15, 8, 0, 0));

            var result = notification.IsMessageReadyToSend();

            Assert.AreEqual(false, result);
        }

        [Test]
        public void IsMessageReadyToSend_Variant6_MethodShouldReturnFalse()
        {
            // Notification Should Be Sent: 15.06.2018
            notification.HistoricEventDate = new DateTime(1993, 6, 15);
            SetAheadOfTimeValuesForNotification(notification, 0); // Ahead Of Time (Number of days): 0
            notification.SendingHour = 8;

            // Current Date: 15.06.2018 8:00
            SystemTime.Set(new DateTime(2018, 7, 15, 8, 0, 0));

            var result = notification.IsMessageReadyToSend();

            Assert.AreEqual(false, result);
        }

        [Test]
        public void IsMessageReadyToSend_Variant7_MethodShouldReturnFalse()
        {
            // Notification Should Be Sent: 15.06.2018
            notification.HistoricEventDate = new DateTime(1993, 6, 15);
            SetAheadOfTimeValuesForNotification(notification, 3); // Ahead Of Time (Number of days): 3
            notification.SendingHour = 8;

            // Current Date: 15.06.2018 8:00
            SystemTime.Set(new DateTime(2018, 6, 15, 8, 0, 0));

            var result = notification.IsMessageReadyToSend();

            Assert.AreEqual(false, result);
        }
    }
}
