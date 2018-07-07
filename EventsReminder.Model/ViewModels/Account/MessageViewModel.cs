using EventsReminder.Common.Enums;
using System;

namespace EventsReminder.Model.ViewModels.Account
{
    public class MessageViewModel
    {
        public string Name { get; set; }
        public MessageType MessageType { get; set; }
        public DateTime DateOfDispatch { get; set; }
        public NotificationType NotificationType { get; set; }
        public string MessageTarget { get; set; }
    }
}
