using System.ComponentModel.DataAnnotations;

namespace EventsReminder.Model.ViewModels.Account
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Adres e-mail jest wymagany.")]
        [UIHint("Email")]
        [Display(Name = "Adres e-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Hasło jest wymagane.")]
        [UIHint("Password")]
        [Display(Name = "Hasło")]
        public string Password { get; set; }

        [Display(Name = "Pamiętaj mnie?")]
        public bool RememberMe { get; set; }
    }
}
