using System;

namespace EventsReminder.Common.Clock
{
    public class SystemTime
    {
        private static DateTime _date;

        public static void Set(DateTime custom)
        {
            _date = custom;
        }

        public static void Reset()
        {
            _date = DateTime.MinValue;
        }

        public static DateTime Now
        {
            get
            {
                if (_date != DateTime.MinValue)
                {
                    return _date;
                }
                var timeZone = TimeZoneInfo.FindSystemTimeZoneById("Central European Standard Time");

                return TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, timeZone.Id);
            }
        }
    }
}
