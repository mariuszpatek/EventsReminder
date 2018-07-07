using EventsReminder.Common;
using EventsReminder.Common.Enums;
using EventsReminder.DataAccess.Repositories;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EventsReminder.BusinessLogic
{
    public class PopulateService : IPopulateService
    {
        private readonly IAheadOfTimeValuesRepository _aheadOfTimeValuesRepository; 
        public PopulateService(IAheadOfTimeValuesRepository aheadOfTimeValuesRepository)
        {
            _aheadOfTimeValuesRepository = aheadOfTimeValuesRepository;
        }

        public List<SelectListItem> GetDaysOfWeek()
        {
            List<SelectListItem> daysOfWeek = new List<SelectListItem>();
            foreach (var value in Enum.GetValues(typeof(DayOfWeekEnum)).OfType<DayOfWeekEnum>().OrderBy(day => day < DayOfWeekEnum.Monday))
            {
                daysOfWeek.Add(new SelectListItem
                {
                    Selected = false,
                    Text = value.GetEnumDisplayName(),
                    Value = ((int)value).ToString()
                });
            }
            return daysOfWeek;
        }

        public List<SelectListItem> GetAheadOfTimeValues()
        {
            var result = _aheadOfTimeValuesRepository
                .GetAllAheadOfTimeValues()
                .OrderBy(a => a.NumberOfDays)
                .Select(a => new SelectListItem
                {
                    Text = a.Name,
                    Value = a.AheadOfTimeId.ToString()
                })
                .ToList();

            return result;
        }
    }
}
