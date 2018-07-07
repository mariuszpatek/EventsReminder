using System;
using EventsReminder.Model.Models;

namespace EventsReminder.DataAccess.Repositories
{
    public interface IGlobalEventRepository
    {
        GlobalEvent GetGlobalEventByDate(DateTime dateTime);
    }
}