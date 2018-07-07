using EventsReminder.Model.Models;
using System;
using System.Linq;

namespace EventsReminder.DataAccess.Repositories
{
    public class GlobalEventRepository : IGlobalEventRepository
    {
        private readonly ApplicationDbContext _context;
        public GlobalEventRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public GlobalEvent GetGlobalEventByDate(DateTime dateTime) => _context.GlobalEvents.FirstOrDefault(e => e.DateTime.Date == dateTime.Date);
    }
}
