using System.ComponentModel.DataAnnotations;

namespace EventsReminder.Model.ViewModels.Account
{
    public class ConfirmPhoneNumberViewModel
    {
        [Required(ErrorMessage = "Token jest wymagane.")]
        public string Token { get; set; }
    }
}
