using System.ComponentModel.DataAnnotations;

namespace EventsReminder.Common.Enums
{
    public enum NotificationType
    {
        [Display(Name = "Dla wydarzeń z przeszłości", Description = "np. urodziny, rocznice")]
        HistoricEvent = 1,
        [Display(Name = "Okresowe", Description = "np. cykliczne lekcje angielskiego")]
        PeriodicEvent = 2,
        [Display(Name = "Jednorazowe", Description = "np. wizyta u fryzjera")]
        OneTimeEvent = 3,
    }
}
