using EventsReminder.Model.Models;

namespace EventsReminder.BusinessLogic.MessagesSending
{
    public class MessageSender
    {
        private IMessageSenderStrategy _sender;
        private Message _notification;
        public MessageSender(IMessageSenderStrategy sender, Message notification)
        {
            _sender = sender;
            _notification = notification;
        }

        public bool Send()
        {
            var result = _sender.SendMessage(_notification);
            return result;
        }
    }
}
