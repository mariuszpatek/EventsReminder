using System.ComponentModel.DataAnnotations;

namespace EventsReminder.Common.Enums
{
    public enum DayOfWeekEnum
    {
        [Display(Name = "Niedziela")]
        Sunday = 0,
        [Display(Name = "Poniedziałek")]
        Monday = 1,
        [Display(Name = "Wtorek")]
        Tuesday = 2,
        [Display(Name = "Środa")]
        Wednesday = 3,
        [Display(Name = "Czwartek")]
        Thursday = 4,
        [Display(Name = "Piątek")]
        Friday = 5,
        [Display(Name = "Sobota")]
        Saturday = 6
    }
}
