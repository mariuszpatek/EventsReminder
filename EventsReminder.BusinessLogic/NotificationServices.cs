using AutoMapper;
using EventsReminder.BusinessLogic.MessagesSending;
using EventsReminder.Common.Clock;
using EventsReminder.Common.Enums;
using EventsReminder.DataAccess.Repositories;
using EventsReminder.Model.DTOs;
using EventsReminder.Model.Models;
using EventsReminder.Model.ViewModels;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EventsReminder.BusinessLogic
{
    public class NotificationService : INotificationService
    {
        private readonly INotificationRepository _notificationRepository;
        private readonly IPopulateService _populateService;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        private readonly ILogger _logger;
        private readonly IMessageService _messageService;
        private readonly ISmsService _smsService;


        public NotificationService(INotificationRepository notificationRepository, 
            IMapper mapper, 
            IPopulateService populateService, 
            IConfiguration configuration,
            ILoggerFactory loggerFactory,
            IMessageService messageService,
            ISmsService smsService)
        {
            _populateService = populateService;
            _notificationRepository = notificationRepository;
            _mapper = mapper;
            _configuration = configuration;
            _logger = loggerFactory.CreateLogger("NotificationsService");
            _messageService = messageService;
            _smsService = smsService;
        }

        public void AddNotification(NotificationViewModel notification)
        {
            Notification notificationToAdd;
            if (notification.NotificationType == NotificationType.HistoricEvent)
            {
                notificationToAdd = _mapper.Map<HistoricEventNotification>(notification);
            }
            else if (notification.NotificationType == NotificationType.OneTimeEvent)
            {
                notificationToAdd = _mapper.Map<OneTimeEventNotification>(notification);
            }
            else
            {
                notificationToAdd = _mapper.Map<PeriodicEventNotification>(notification) as PeriodicEventNotification;
                AssignDaysOfWeekForNotification(notification, notificationToAdd);
            }

            AssignAheadOfTimeValuesForNotification(notification, notificationToAdd);
            AssignCategoriesForNotification(notification, notificationToAdd);

            _notificationRepository.AddNotification(notificationToAdd);
            _notificationRepository.Save();
        }

        public IEnumerable<DisplayNotificationViewModel> GetAllUserNotificationToDisplay(string userId)
        {
            var notifications = _notificationRepository.GetAllUsersNotifications(userId);
            var result = Mapper.Map<List<DisplayNotificationViewModel>>(notifications);
            return result;
        }

        public NotificationViewModel GetUserNotification(string userId, int notificationId)
        {
            var notification = _notificationRepository.GetNotification(notificationId);

            if (notification == null)
                throw new InvalidOperationException();

            if (notification.UserId != userId)
                throw new UnauthorizedAccessException();

            var result = _mapper.Map<NotificationViewModel>(notification);
            result.AheadOfTime = _populateService.GetAheadOfTimeValues();
            result.DaysOfWeek = _populateService.GetDaysOfWeek();
            result.SetAheadOfTimeValuesAsSelected(notification.SendNotificationAheadOfTime.Select(a => a.AheadOfTimeId));
            result.SetDaysOfWeekAsSelected((notification as PeriodicEventNotification)?.DaysOfWeekWhenSendNotification.Select(d => d.DayOfWeekId));

            return result;
        }

        public void UpdateNotification(string userId, NotificationViewModel notification)
        {
            var notificationToUpdate = _notificationRepository.GetNotification(notification.NotificationId);

            if (notificationToUpdate.UserId != userId)
                throw new UnauthorizedAccessException();

            notificationToUpdate.Name = notification.Name;
            notificationToUpdate.Description = notification.Description;
            notificationToUpdate.MessageType = notification.MessageType ?? notificationToUpdate.MessageType;
            notificationToUpdate.SendingHour = notification.SendingHour;

            if (notificationToUpdate.NotificationType == NotificationType.PeriodicEvent)
            {
                (notificationToUpdate as PeriodicEventNotification).DaysOfWeekWhenSendNotification.Clear();
                AssignDaysOfWeekForNotification(notification, notificationToUpdate);
            }
            else if (notificationToUpdate.NotificationType == NotificationType.HistoricEvent)
            {
                (notificationToUpdate as HistoricEventNotification).HistoricEventDate = notification.EventDate ?? (notificationToUpdate as HistoricEventNotification).HistoricEventDate;
            }
            else
            {
                (notificationToUpdate as OneTimeEventNotification).FutureEventDate = notification.EventDate ?? (notificationToUpdate as OneTimeEventNotification).FutureEventDate;
            }

            notificationToUpdate.SendNotificationAheadOfTime.Clear();
            AssignAheadOfTimeValuesForNotification(notification, notificationToUpdate);

            _notificationRepository.UpdateNotification(notificationToUpdate);
            _notificationRepository.Save();
        }

        public DispatchNotificationResult SendNotificatonsToUsers()
        {
            var allNotifications = _notificationRepository.GetAllNotifications();
            var notificationsToSend = allNotifications.Where(n => n.IsMessageReadyToSend() == true);
            
            var response = SendNotificationsAndSetDispatchDate(notificationsToSend);

            return response;
        }

        private DispatchNotificationResult SendNotificationsAndSetDispatchDate(IEnumerable<Notification> notifications)
        {
            var factory = new SenderFactory(_configuration, _logger, _smsService);
            var respone = new DispatchNotificationResult();

            foreach (var notification in notifications)
            {
                var message = _messageService.CreateMessage(notification);
                var sender = new MessageSender(factory.CreateSenderObject(notification.MessageType), message); 
                var result = sender.Send();
                if (result)
                {
                    var dateOfDisptach = SystemTime.Now;
                    notification.DateOfLastDispatch = dateOfDisptach;
                    respone.sentNotifications.Add(Mapper.Map<NotificationDto>(notification));
                    message.DateOfSending = dateOfDisptach;
                    _messageService.AddMessage(message);
                    continue;
                }
                respone.notSentNotifications.Add(Mapper.Map<NotificationDto>(notification));
            }

            _notificationRepository.Save();

            return respone;
        }

        private static void AssignDaysOfWeekForNotification(NotificationViewModel notification, Notification notificationToEdit)
        {
            notification.GetSelectedDaysOfWeekIDs().ToList()
                .ForEach(d =>
                    (notificationToEdit as PeriodicEventNotification)
                    .DaysOfWeekWhenSendNotification
                    .Add(new DaysOfWeekWhenSendNotification { DayOfWeekId = d }));
        }

        private static void AssignAheadOfTimeValuesForNotification(NotificationViewModel notification, Notification notificationToEdit)
        {
            notification.GetSelectedAheadOfTimeValuesIDs().ToList()
                .ForEach(d =>
                    notificationToEdit
                    .SendNotificationAheadOfTime
                    .Add(new SendNotificationAheadOfTime { AheadOfTimeId = d }));
        }

        private static void AssignCategoriesForNotification(NotificationViewModel notification, Notification notificationToEdit)
        {
            notification.Categories.ToList()
                .ForEach(c =>
                     notificationToEdit
                    .NotificationsCategories
                    .Add(new NotificationCategory { CategoryId = c }));
        }
    }
}
