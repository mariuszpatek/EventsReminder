using System.ComponentModel.DataAnnotations;

namespace EventsReminder.Common.Enums
{
    public enum MessageType
    {
        [Display(Name = "E-mail")]
        Email = 0,
        [Display(Name = "SMS")]
        SMS = 1
    }
}
