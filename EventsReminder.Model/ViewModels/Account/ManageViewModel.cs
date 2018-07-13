using System.ComponentModel.DataAnnotations;

namespace EventsReminder.Model.ViewModels.Account
{
    public class ManageViewModel
    {
        [DataType(DataType.Password)]
        [Display(Name = "Nowe hasło")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Wprowadzone hasła są różne.")]
        [Display(Name = "Potwierdź hasło")]
        public string ConfirmPassword { get; set; }

        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^([+]?([0-9]{9,11}))$", ErrorMessage = "Wprowadzony numer telefonu jest nieprawidłowy.")]
        [Display(Name = "Numer telefonu")]
        public string PhoneNumber { get; set; }

        public bool IsPhoneNumberConfirmed { get; set; }
    }
}
