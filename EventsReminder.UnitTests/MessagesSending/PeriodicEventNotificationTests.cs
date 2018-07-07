using EventsReminder.Common.Clock;
using EventsReminder.Model.Models;
using NUnit.Framework;
using System;

namespace EventsReminder.UnitTests.MessagesSending
{
    [TestFixture]
    public class PeriodicEventNotificationTests : NotificationTests
    {
        private PeriodicEventNotification notification;

        [SetUp]
        public void SetUp()
        {
            notification = new PeriodicEventNotification
            {
                Name = "Test notification"
            };
        }

        [Test]
        public void IsMessageReadyToSend_Variant1_MethodShouldReturnTrue()
        {

            // Notification Should Be Sent: Sunday 14:00
            SetDaysOfWeekForNotification(notification, 0); // Day of week: Sunday
            SetAheadOfTimeValuesForNotification(notification, 0); // Ahead Of Time (Number of days): 0
            notification.SendingHour = 14;

            // Current Date: Sunday 15:00
            SystemTime.Set(new DateTime(2018, 6, 10, 15, 0, 0));

            var result = notification.IsMessageReadyToSend();

            Assert.AreEqual(true, result);
        }

        [Test]
        public void IsMessageReadyToSend_Variant2_MethodShouldReturnTrue()
        {

            // Notification Should Be Sent: Sunday 15:00
            SetDaysOfWeekForNotification(notification, 0); // Day of week: Sunday
            SetAheadOfTimeValuesForNotification(notification, 0); // Ahead Of Time (Number of days): 0
            notification.SendingHour = 15;

            // Current Date: Sunday 15:00
            SystemTime.Set(new DateTime(2018, 6, 10, 15, 0, 0));

            var result = notification.IsMessageReadyToSend();

            Assert.AreEqual(true, result);
        }

        [Test]
        public void IsMessageReadyToSend_Variant3_MethodShouldReturnTrue()
        {

            // Notification Should Be Sent: Sunday, Monday, Friday 15:00
            SetDaysOfWeekForNotification(notification, 0, 1, 5); // Day of week: Sunday, Moday, Friday
            SetAheadOfTimeValuesForNotification(notification, 0); // Ahead Of Time (Number of days): 0
            notification.SendingHour = 15;

            // Current Date: Monday 15:00
            SystemTime.Set(new DateTime(2018, 6, 4, 15, 0, 0));

            var result = notification.IsMessageReadyToSend();

            Assert.AreEqual(true, result);
        }

        [Test]
        public void IsMessageReadyToSend_Variant4_MethodShouldReturnTrue()
        {

            // Notification Should Be Sent: Friday 15:00
            SetDaysOfWeekForNotification(notification, 2); // Day of week: Tuesday 
            SetAheadOfTimeValuesForNotification(notification, 4); // Ahead Of Time (Number of days): 4
            notification.SendingHour = 15;

            // Current Date: Friday 15:00
            SystemTime.Set(new DateTime(2018, 6, 1, 15, 0, 0));

            var result = notification.IsMessageReadyToSend();

            Assert.AreEqual(true, result);
        }

        [Test]
        public void IsMessageReadyToSend_Variant5_MethodShouldReturnTrue()
        {

            // Notification Should Be Sent: Friday 15:00
            SetDaysOfWeekForNotification(notification, 2); // Day of week: Tuesday 
            SetAheadOfTimeValuesForNotification(notification, 4); // Ahead Of Time (Number of days): 4
            notification.SendingHour = 15;

            // Current Date: Friday 15:00
            SystemTime.Set(new DateTime(2018, 6, 1, 15, 0, 0));

            var result = notification.IsMessageReadyToSend();

            Assert.AreEqual(true, result);
        }


        [Test]
        public void IsMessageReadyToSend_Variant6_MethodShouldReturnTrue()
        {

            // Notification Should Be Sent: Sunday, Monday, Saturday, Tuesday, Friaday   15:00
            SetDaysOfWeekForNotification(notification, 0, 1); // Day of week: Sunday, Monday, Saturday 
            SetAheadOfTimeValuesForNotification(notification, 0, 1, 2); // Ahead Of Time (Number of days): 0, 1, 2
            notification.SendingHour = 15;

            // Current Date: Friday 15:00
            SystemTime.Set(new DateTime(2018, 6, 1, 15, 0, 0));

            var result = notification.IsMessageReadyToSend();

            Assert.AreEqual(true, result);
        }

        [Test]
        public void IsMessageReadyToSend_Variant7_MethodShouldReturnFalse()
        {

            // Notification Should Be Sent: Friday 16:00
            SetDaysOfWeekForNotification(notification, 2); // Day of week: Tuesday 
            SetAheadOfTimeValuesForNotification(notification, 4); // Ahead Of Time (Number of days): 4
            notification.SendingHour = 16;

            // Current Date: Friday 15:00
            SystemTime.Set(new DateTime(2018, 6, 1, 15, 0, 0));

            var result = notification.IsMessageReadyToSend();

            Assert.AreEqual(false, result);
        }

        [Test]
        public void IsMessageReadyToSend_Variant8_MethodShouldReturnFalse()
        {

            // Notification Should Be Sent: Friday 15:00
            SetDaysOfWeekForNotification(notification, 2); // Day of week: Tuesday 
            SetAheadOfTimeValuesForNotification(notification, 4); // Ahead Of Time (Number of days): 4
            notification.SendingHour = 15;

            // Current Date: Monday 15:00
            SystemTime.Set(new DateTime(2018, 6, 4, 15, 0, 0));

            var result = notification.IsMessageReadyToSend();

            Assert.AreEqual(false, result);
        }


        [Test]
        public void IsMessageReadyToSend_Variant9_MethodShouldReturnFalse()
        {

            // Notification Should Be Sent: Sunday, Monday, Friday 15:00
            SetDaysOfWeekForNotification(notification, 0, 1, 5); // Day of week: Sunday, Moday, Friday
            SetAheadOfTimeValuesForNotification(notification, 0); // Ahead Of Time (Number of days): 0
            notification.SendingHour = 15;

            // Current Date: Wednesday 15:00
            SystemTime.Set(new DateTime(2018, 6, 6, 15, 0, 0));

            var result = notification.IsMessageReadyToSend();

            Assert.AreEqual(false, result);
        }

        [Test]
        public void IsMessageReadyToSend_Variant10_MethodShouldReturnFalse()
        {

            // Notification Should Be Sent: Sunday 15:00 - Message has been already sent
            SetDaysOfWeekForNotification(notification, 0); // Day of week: Sunday
            SetAheadOfTimeValuesForNotification(notification, 0); // Ahead Of Time (Number of days): 0
            notification.SendingHour = 15;
            notification.DateOfLastDispatch = new DateTime(2018, 6, 10, 15, 0, 0);

            // Current Date: Sunday 15:00
            SystemTime.Set(new DateTime(2018, 6, 10, 15, 0, 0));

            var result = notification.IsMessageReadyToSend();

            Assert.AreEqual(false, result);
        }

        [Test]
        public void IsMessageReadyToSend_Variant11_MethodShouldReturnTrue()
        {

            // Notification Should Be Sent: Sunday 15:00 - Message was sent earlier
            SetDaysOfWeekForNotification(notification, 0); // Day of week: Sunday
            SetAheadOfTimeValuesForNotification(notification, 0); // Ahead Of Time (Number of days): 0
            notification.SendingHour = 15;
            notification.DateOfLastDispatch = new DateTime(2018, 6, 9, 15, 0, 0);

            // Current Date: Sunday 15:00
            SystemTime.Set(new DateTime(2018, 6, 10, 15, 0, 0));

            var result = notification.IsMessageReadyToSend();

            Assert.AreEqual(true, result);
        }

        [Test]
        public void IsMessageReadyToSend_Variant12_MethodShouldReturnFalse()
        {

            // Notification Should Be Sent: Sunday 15:00 - Message was sent earlier
            SetDaysOfWeekForNotification(notification, 0); // Day of week: Sunday
            SetAheadOfTimeValuesForNotification(notification, 0); // Ahead Of Time (Number of days): 0
            notification.SendingHour = 15;
            notification.DateOfLastDispatch = new DateTime(2018, 6, 9, 15, 0, 0);

            // Current Date: Sunday 14:59:59
            SystemTime.Set(new DateTime(2018, 6, 10, 14, 59, 59));

            var result = notification.IsMessageReadyToSend();

            Assert.AreEqual(false, result);
        }


        [Test]
        public void IsMessageReadyToSend_Variant13_MethodShouldReturnFalse()
        {

            // Notification Should Be Sent: Sunday 15:00 - Message was sent earlier
            SetDaysOfWeekForNotification(notification, 0); // Day of week: Sunday
            SetAheadOfTimeValuesForNotification(notification, 0); // Ahead Of Time (Number of days): 0
            notification.SendingHour = 15;
            notification.DateOfLastDispatch = new DateTime(2018, 6, 9, 15, 0, 0);

            // Current Date: Thursday 15:00:00
            SystemTime.Set(new DateTime(2018, 6, 14, 15, 00, 00));

            var result = notification.IsMessageReadyToSend();

            Assert.AreEqual(false, result);
        }

        [Test]
        public void IsMessageReadyToSend_Variant14_MethodShouldReturnTrue()
        {

            // Notification Should Be Sent: All days of week - Message was sent earlier
            SetDaysOfWeekForNotification(notification, 0, 1, 2, 3, 4, 5, 6); // Day of week: Sunday
            SetAheadOfTimeValuesForNotification(notification, 0); // Ahead Of Time (Number of days): 0
            notification.SendingHour = 15;
            notification.DateOfLastDispatch = new DateTime(2018, 6, 9, 15, 0, 0);

            // Current Date: Thursday 15:00:00
            SystemTime.Set(new DateTime(2018, 6, 14, 15, 00, 00));

            var result = notification.IsMessageReadyToSend();

            Assert.AreEqual(true, result);
        }


        [Test]
        public void IsMessageReadyToSend_Variant15_MethodShouldReturnTrue()
        {

            // Notification Should Be Sent: All days of week - Message was sent earlier
            SetDaysOfWeekForNotification(notification, 0, 1, 2, 3, 4, 5, 6); // Day of week: Sunday
            SetAheadOfTimeValuesForNotification(notification, 0, 1, 2, 3, 4, 5, 6, 7, 20, 10); // Ahead Of Time (Number of days): duplicated days
            notification.SendingHour = 15;
            notification.DateOfLastDispatch = new DateTime(2018, 6, 9, 15, 0, 0);

            // Current Date: Thursday 15:00:00
            SystemTime.Set(new DateTime(2018, 6, 14, 15, 00, 00));

            var result = notification.IsMessageReadyToSend();

            Assert.AreEqual(true, result);
        }

        [Test]
        public void IsMessageReadyToSend_Variant16_MethodShouldReturnFalse()
        {

            // Notification Should Be Sent: All days of week - Message has been already sent
            SetDaysOfWeekForNotification(notification, 0, 1, 2, 3, 4, 5, 6); // Day of week: Sunday
            SetAheadOfTimeValuesForNotification(notification, 0, 1, 2, 3, 4, 5, 6, 7, 20, 10); // Ahead Of Time (Number of days): duplicated days
            notification.SendingHour = 15;
            notification.DateOfLastDispatch = new DateTime(2018, 6, 14, 15, 0, 0);

            // Current Date: Thursday 15:00:00
            SystemTime.Set(new DateTime(2018, 6, 14, 15, 00, 00));

            var result = notification.IsMessageReadyToSend();

            Assert.AreEqual(false, result);
        }

        [Test]
        public void IsMessageReadyToSend_Variant17_MethodShouldReturnTrue()
        {

            // Notification Should Be Sent: Saturday - Message was sent earlier
            SetDaysOfWeekForNotification(notification, 6); // Day of week: Saturday
            SetAheadOfTimeValuesForNotification(notification, 0); // Ahead Of Time (Number of days): 0
            notification.SendingHour = 15;
            notification.DateOfLastDispatch = new DateTime(2018, 6, 10, 15, 0, 0);

            // Current Date: Saturday 15:00:00
            SystemTime.Set(new DateTime(2018, 6, 16, 15, 00, 00));

            var result = notification.IsMessageReadyToSend();

            Assert.AreEqual(true, result);
        }
    }
}
