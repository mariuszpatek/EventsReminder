using EventsReminder.Model.Models;
using System.Collections.Generic;
using System.Linq;

namespace EventsReminder.DataAccess.Repositories
{
    public class AheadOfTimeValuesRepository : IAheadOfTimeValuesRepository
    {
        private readonly ApplicationDbContext _context;
        public AheadOfTimeValuesRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<AheadOfTime> GetAllAheadOfTimeValues()
        {
            return _context.AheadOfTime.ToList();
        }
    }
}
