using EventsReminder.Model.Models;
using EventsReminder.Model.ViewModels.Account;
using System.Collections.Generic;

namespace EventsReminder.BusinessLogic
{
    public interface IMessageService
    {
        Message CreateMessage(Notification notification);
        void AddMessage(Message message);
        void Save();
        IEnumerable<MessageViewModel> GetUserMessages(string userId);
    }
}