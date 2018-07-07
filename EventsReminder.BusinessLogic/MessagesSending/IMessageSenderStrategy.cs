using EventsReminder.Model.Models;

namespace EventsReminder.BusinessLogic.MessagesSending
{
    public interface IMessageSenderStrategy
    {
        bool SendMessage(Message notification);
    }
}
