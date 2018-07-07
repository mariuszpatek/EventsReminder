using System;
using EventsReminder.Model.Models;

namespace EventsReminder.BusinessLogic
{
    public interface IGlobalEventService
    {
        GlobalEvent GetBlobalEventByDate(DateTime dateTime);
    }
}