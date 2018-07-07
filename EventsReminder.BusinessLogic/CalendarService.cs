using AutoMapper;
using EventsReminder.Common.Clock;
using EventsReminder.Common.Enums;
using EventsReminder.DataAccess.Repositories;
using EventsReminder.Model.Models;
using EventsReminder.Model.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EventsReminder.BusinessLogic
{
    public class CalendarService : ICalendarService
    {
        private readonly INotificationRepository _notificationRepository;
        private readonly IMapper _mapper;

        public CalendarService(INotificationRepository notificationRepository, IMapper mapper)
        {
            _notificationRepository = notificationRepository;
            _mapper = mapper;
        }

        public string GetAllUserNotificationToDisplay(string userId)
        {
            var notifications = _notificationRepository.GetAllUsersNotifications(userId)
                .Where(n => n.NotificationType != NotificationType.PeriodicEvent);

            foreach (var notification in notifications)
            {
                if (notification is OneTimeEventNotification)
                {
                    var onetimeEvent = (notification as OneTimeEventNotification);
                    onetimeEvent.FutureEventDate = new DateTime(SystemTime.Now.Year, onetimeEvent.FutureEventDate.Month, onetimeEvent.FutureEventDate.Day);
                }
                if (notification is HistoricEventNotification)
                {
                    var historicEvent = (notification as HistoricEventNotification);
                    historicEvent.HistoricEventDate = new DateTime(SystemTime.Now.Year, historicEvent.HistoricEventDate.Month, historicEvent.HistoricEventDate.Day);
                }
            }

            var result = Mapper.Map<List<CalendarViewModel>>(notifications);
            return JsonConvert.SerializeObject(result);
        }
    }
}
