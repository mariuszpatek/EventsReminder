using EventsReminder.DataAccess.Repositories;
using EventsReminder.Model.Models;
using System;

namespace EventsReminder.BusinessLogic
{
    public class GlobalEventService : IGlobalEventService
    {
        private readonly IGlobalEventRepository _eventsRepository;

        public GlobalEventService(IGlobalEventRepository eventsRepository)
        {
            _eventsRepository = eventsRepository;
        }

        public GlobalEvent GetBlobalEventByDate(DateTime dateTime)
        {
            dateTime = new DateTime(2016, dateTime.Month,dateTime.Day); // 2016 is the year that all events have in database
            var eventToReturn = _eventsRepository.GetGlobalEventByDate(dateTime);
            var eventsLines = eventToReturn.Content.Split(Environment.NewLine);
            for (int i = 0; i < eventsLines.Length; i++)
            {
                if (!String.IsNullOrWhiteSpace(eventsLines[i]))
                {
                    eventsLines[i] = "<li>" + eventsLines[i] + "</li>";
                }          
            }
            eventToReturn.Content = String.Join(" ", eventsLines);
            eventToReturn.Content = eventToReturn.Content.Replace(Environment.NewLine, "<br/>");
            return eventToReturn;
        }
    }
}
