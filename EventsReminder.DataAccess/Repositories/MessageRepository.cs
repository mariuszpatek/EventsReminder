using EventsReminder.Model.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace EventsReminder.DataAccess.Repositories
{
    public class MessageRepository : IMessageRepository
    {
        private readonly ApplicationDbContext _context;
        public MessageRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        public void AddMessage(Message message)
        {
            _context.Messages.Add(message);
        }

        public IEnumerable<Message> GetAllUserMessages(string userId)
        {
            return _context.Notifications
                .Where(n => n.UserId == userId)
                    .Include(n => n.Messages)
                .SelectMany(n => n.Messages)
                    .Include(m => m.Notification)
                .ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
