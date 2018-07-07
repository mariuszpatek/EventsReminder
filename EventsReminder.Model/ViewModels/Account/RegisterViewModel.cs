using System.ComponentModel.DataAnnotations;

namespace EventsReminder.Model.ViewModels.Account
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Adres e-mail jest wymagany.")]
        [EmailAddress]
        [Display(Name = "Adres e-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Hasło jest wymagane.")]
        [DataType(DataType.Password)]
        [Display(Name = "Hasło")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Wprowadzone hasła są różne.")]
        [Display(Name = "Potwierdź hasło")]
        public string ConfirmPassword { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Numer telefonu")]
        public string PhoneNumber { get; set; }
    }
}
