using EventsReminder.Model.Models;
using System.Collections.Generic;

namespace EventsReminder.DataAccess.Repositories
{
    public interface IMessageRepository
    {
        void AddMessage(Message message);
        void Save();
        IEnumerable<Message> GetAllUserMessages(string userId);
    }
}