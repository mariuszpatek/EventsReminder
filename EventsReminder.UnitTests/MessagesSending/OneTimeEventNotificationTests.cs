using EventsReminder.Common.Clock;
using EventsReminder.Model.Models;
using NUnit.Framework;
using System;

namespace EventsReminder.UnitTests.MessagesSending
{
    public class OneTimeEventNotificationTests : NotificationTests
    {
        private OneTimeEventNotification notification;

        [SetUp]
        public void SetUp()
        {
            notification = new OneTimeEventNotification
            {
                Name = "Test notification"
            };
        }

        [Test]
        public void IsMessageReadyToSend_Variant1_MethodShouldReturnTrue()
        {
            // Notification Should Be Sent: 15.06.2018 15:00
            notification.FutureEventDate = new DateTime(2018, 6, 15);
            SetAheadOfTimeValuesForNotification(notification, 0); // Ahead Of Time (Number of days): 0
            notification.SendingHour = 15;

            // Current Date: 15.06.2018 15:00
            SystemTime.Set(new DateTime(2018, 6, 15, 15, 0, 0));

            var result = notification.IsMessageReadyToSend();

            Assert.AreEqual(true, result);
        }

        [Test]
        public void IsMessageReadyToSend_Variant2_MethodShouldReturnTrue()
        {
            // Notification Should Be Sent: 15.06.2018 15:00
            notification.FutureEventDate = new DateTime(2018, 6, 15);
            SetAheadOfTimeValuesForNotification(notification, 0); // Ahead Of Time (Number of days): 0
            notification.SendingHour = 15;

            // Current Date: 15.06.2018 16:00
            SystemTime.Set(new DateTime(2018, 6, 15, 16, 0, 0));

            var result = notification.IsMessageReadyToSend();

            Assert.AreEqual(true, result);
        }

        [Test]
        public void IsMessageReadyToSend_Variant3_MethodShouldReturnTrue()
        {
            // Notification Should Be Sent: 15.06.2018 15:00
            notification.FutureEventDate = new DateTime(2018, 6, 16);
            SetAheadOfTimeValuesForNotification(notification, 1); // Ahead Of Time (Number of days): 1
            notification.SendingHour = 15;

            // Current Date: 15.06.2018 15:00
            SystemTime.Set(new DateTime(2018, 6, 15, 15, 0, 0));

            var result = notification.IsMessageReadyToSend();

            Assert.AreEqual(true, result);
        }

        [TestCase(6, 9, 15)]
        [TestCase(6, 15, 15)]
        [TestCase(6, 16, 15)]
        public void IsMessageReadyToSend_Variant4_MethodShouldReturnTrue(int month, int day, int hour)
        {
            // Notification Should Be Sent: 9.06.2018 15:00, 15.06.2018 15:00, 16.06.2018 15:00
            notification.FutureEventDate = new DateTime(2018, 6, 16);
            SetAheadOfTimeValuesForNotification(notification, 0, 1, 7); // Ahead Of Time (Number of days): 0, 1, 7
            notification.SendingHour = 15;

            // Current Date: 15.06.2018 15:00
            SystemTime.Set(new DateTime(2018, month, day, hour, 0, 0));

            var result = notification.IsMessageReadyToSend();

            Assert.AreEqual(true, result);
        }

        [Test]
        public void IsMessageReadyToSend_Variant5_MethodShouldReturnFalse()
        {
            // Notification Should Be Sent: 15.06.2018 15:00 - Message has been already sent
            notification.FutureEventDate = new DateTime(2018, 6, 16);
            SetAheadOfTimeValuesForNotification(notification, 1); // Ahead Of Time (Number of days): 1
            notification.SendingHour = 15;
            notification.DateOfLastDispatch = new DateTime(2018, 6, 15);

            // Current Date: 15.06.2018 15:00
            SystemTime.Set(new DateTime(2018, 6, 15, 15, 0, 0));

            var result = notification.IsMessageReadyToSend();

            Assert.AreEqual(false, result);
        }

        [Test]
        public void IsMessageReadyToSend_Variant5_MethodShouldReturnTrue()
        {
            // Notification Should Be Sent: 15.06.2018 15:00 - Message has been long time ago
            notification.FutureEventDate = new DateTime(2018, 6, 16);
            SetAheadOfTimeValuesForNotification(notification, 1); // Ahead Of Time (Number of days): 1
            notification.SendingHour = 15;
            notification.DateOfLastDispatch = new DateTime(2017, 6, 15);

            // Current Date: 15.06.2018 15:00
            SystemTime.Set(new DateTime(2018, 6, 15, 15, 0, 0));

            var result = notification.IsMessageReadyToSend();

            Assert.AreEqual(true, result);
        }

        [Test]
        public void IsMessageReadyToSend_Variant6_MethodShouldReturnFalse()
        {
            // Notification Should Be Sent: 15.06.2018 15:00 
            notification.FutureEventDate = new DateTime(2018, 6, 16);
            SetAheadOfTimeValuesForNotification(notification, 1); // Ahead Of Time (Number of days): 1
            notification.SendingHour = 15;


            // Current Date: 15.06.2018 14:00
            SystemTime.Set(new DateTime(2018, 6, 15, 14, 0, 0));

            var result = notification.IsMessageReadyToSend();

            Assert.AreEqual(false, result);
        }

        [Test]
        public void IsMessageReadyToSend_Variant7_MethodShouldReturnFalse()
        {
            // Notification Should Be Sent: 15.06.2018 15:00 
            notification.FutureEventDate = new DateTime(2018, 6, 16);
            SetAheadOfTimeValuesForNotification(notification, 1); // Ahead Of Time (Number of days): 1
            notification.SendingHour = 15;


            // Current Date: 15.06.2018 15:00
            SystemTime.Set(new DateTime(2018, 6, 14, 15, 0, 0));

            var result = notification.IsMessageReadyToSend();

            Assert.AreEqual(false, result);
        }

        [Test]
        public void IsMessageReadyToSend_Variant8_MethodShouldReturnFalse()
        {
            // Notification Should Be Sent: 15.06.2018 15:00 
            notification.FutureEventDate = new DateTime(2018, 6, 16);
            SetAheadOfTimeValuesForNotification(notification, 1); // Ahead Of Time (Number of days): 1
            notification.SendingHour = 15;


            // Current Date: 16.06.2018 15:00
            SystemTime.Set(new DateTime(2018, 6, 16, 15, 0, 0));

            var result = notification.IsMessageReadyToSend();

            Assert.AreEqual(false, result);
        }
    }
}
