using AutoMapper;
using EventsReminder.Model.DTOs;
using EventsReminder.Model.Models;
using EventsReminder.Model.ViewModels;
using EventsReminder.Model.ViewModels.Account;
using System.Linq;

namespace EventsReminder.Web
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Message, MessageViewModel>()
                .ForMember(x => x.DateOfDispatch, opt => opt.MapFrom(m => m.DateOfSending))
                .ForMember(x => x.MessageType, opt => opt.MapFrom(m => m.Notification.MessageType))
                .ForMember(x => x.Name, opt => opt.MapFrom(m => m.Notification.Name))
                .ForMember(x => x.MessageTarget, opt => opt.MapFrom(m => m.MessageTarget))
                .ForMember(x => x.NotificationType, opt => opt.MapFrom(m => m.Notification.NotificationType))
                .ForAllOtherMembers(opts => opts.Ignore());

            CreateMap<NotificationViewModel, Notification>()
                .Include<NotificationViewModel, PeriodicEventNotification>()
                .Include<NotificationViewModel, OneTimeEventNotification>()
                .Include<NotificationViewModel, HistoricEventNotification>()
                .ForMember(x => x.SendNotificationAheadOfTime, opt => opt.Ignore())
                .ForMember(x => x.Messages, opt => opt.Ignore())
                .ForMember(x => x.DateOfLastDispatch, opt => opt.Ignore())
                .ForMember(x => x.SendingHour, opt => opt.MapFrom(m => m.SendingHour))
                .ReverseMap();

            CreateMap<Notification, NotificationDto>()
                .ForMember(x => x.UserId, opt => opt.MapFrom(m => m.UserId))
                .ForMember(x => x.MessageType, opt => opt.MapFrom(m => m.MessageType.ToString()))
                .ForMember(x => x.Name, opt => opt.MapFrom(m => m.Name))
                .ForMember(x => x.NotificationId, opt => opt.MapFrom(m => m.NotificationId))
                .ForAllOtherMembers(opts => opts.Ignore());

            CreateMap<Notification, CalendarViewModel>()
                .Include<OneTimeEventNotification, CalendarViewModel>()
                .Include<HistoricEventNotification, CalendarViewModel>()
                .ForMember(x => x.Id, opt => opt.MapFrom(m => m.NotificationId))
                .ForMember(x => x.Name, opt => opt.MapFrom(m => m.Name))
                .ForMember(x => x.NotificationType, opt => opt.MapFrom(m => m.NotificationType.ToString()))
                .ForAllOtherMembers(opts => opts.Ignore());

            CreateMap<OneTimeEventNotification, CalendarViewModel>()
                 .ForMember(x => x.Date, opt => opt.MapFrom(m => m.FutureEventDate.ToString("yyyy-MM-dd")))
                 .ReverseMap();

            CreateMap<HistoricEventNotification, CalendarViewModel>()
                 .ForMember(x => x.Date, opt => opt.MapFrom(m => m.HistoricEventDate.ToString("yyyy-MM-dd")))
                 .ReverseMap();

            CreateMap<NotificationViewModel, OneTimeEventNotification>()
                .ForMember(x => x.FutureEventDate, opt => opt.MapFrom(m => m.EventDate))
                .ReverseMap();

            CreateMap<NotificationViewModel, HistoricEventNotification>()
                 .ForMember(x => x.HistoricEventDate, opt => opt.MapFrom(m => m.EventDate))
                 .ReverseMap();

            CreateMap<NotificationViewModel, PeriodicEventNotification>()
                 .ForMember(x => x.DaysOfWeekWhenSendNotification, opt => opt.Ignore())
                 .ReverseMap();

            CreateMap<Notification, DisplayNotificationViewModel>()
                .Include<PeriodicEventNotification, DisplayNotificationViewModel>()
                .Include<OneTimeEventNotification, DisplayNotificationViewModel>()
                .Include<HistoricEventNotification, DisplayNotificationViewModel>()
                .ForMember(dest => dest.AheadOfTimeValues, opt =>
                    opt.MapFrom(src => src.SendNotificationAheadOfTime
                        .Select(d => d.AheadOfTime.Name)))
                .ForMember(dest => dest.SendingHour, opt =>
                    opt.MapFrom(src => src.SendingHour))
                .ForMember(dest => dest.MessageTypeName, opt =>
                    opt.MapFrom(src => src.MessageType.ToString()))
                .ForMember(dest => dest.NotificationTypeName, opt => 
                    opt.MapFrom(src => src.NotificationType.ToString()))
                .ForMember(dest => dest.Categories, opt => 
                    opt.MapFrom(src => src.NotificationsCategories
                        .Select(d => d.Category.Name)));

            CreateMap<OneTimeEventNotification, DisplayNotificationViewModel>()
                .ForMember(dest => dest.EventDate, opt => opt.MapFrom(src => src.FutureEventDate));

            CreateMap<HistoricEventNotification, DisplayNotificationViewModel>()
                 .ForMember(x => x.EventDate, opt => opt.MapFrom(m => m.HistoricEventDate));

            CreateMap<PeriodicEventNotification, DisplayNotificationViewModel>()
                 .ForMember(dest => dest.DaysOfWeek, opt =>
                   opt.MapFrom(src => src.DaysOfWeekWhenSendNotification
                       .Select(d => d.DayOfWeek.Name)));
        }
    }
}
