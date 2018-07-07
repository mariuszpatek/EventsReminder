using EventsReminder.Model.Models;
using System.Collections.Generic;

namespace EventsReminder.DataAccess.Repositories
{
    public interface IAheadOfTimeValuesRepository
    {
        IEnumerable<AheadOfTime> GetAllAheadOfTimeValues();
    }
}