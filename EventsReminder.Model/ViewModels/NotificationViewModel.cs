using EventsReminder.Common.Enums;
using EventsReminder.Common.ValidationAttributes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace EventsReminder.Model.ViewModels
{
    public class NotificationViewModel
    {
        public int NotificationId { get; set; }

        [Display(Name = "Nazwa powiadomienia")]
        [Required(ErrorMessage = "Pole: Nazwa powiadomienia jest wymagane.")]
        [StringLength(maximumLength: 255, ErrorMessage = "Nazwa nie może zawierać więcej niż 255 znaków.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Pole: Treść powiadomienia jest wymagane.")]
        [StringLength(maximumLength: 2000)]
        [Display(Name = "Treść powiadomienia")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Pole: Typ powiadomienia jest wymagane.")]
        [Display(Name = "Typ powiadomienia")]
        public NotificationType? NotificationType { get; set; }

        [Display(Name = "Dzień tygodnia")]
        public List<SelectListItem> DaysOfWeek { get; set; }

        [Display(Name = "Data wydarzenia")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [RequiredIf("NotificationType", Common.Enums.NotificationType.HistoricEvent, Common.Enums.NotificationType.OneTimeEvent, ErrorMessage = "Pole: Data wydarzenia jest wymagane.")]
        public DateTime? EventDate { get; set; }

        [Display(Name = "Wyślij przypomnienie")]
        [SelectListItemIsRequired(ErrorMessage = "Pole: Wyślij przypomnienie jest wymagane.")]
        public List<SelectListItem> AheadOfTime { get; set; }

        [Display(Name = "Sposób wysłania")]
        [Required(ErrorMessage = "Pole: Sposób wysłania jest wymagane.")]
        [Remote("ValidateMessageTypeForUser", controller: "Account")]
        public MessageType? MessageType { get; set; }

        [Required(ErrorMessage = "Pole: Godzina wysłania jest wymagane.")]
        [Display(Name = "Godzina wysłania")]
        public byte SendingHour { get; set; }

        public IEnumerable<int> Categories { get; set; }

        public string UserId { get; set; }

        public IEnumerable<int> GetSelectedAheadOfTimeValuesIDs()
        {
            return AheadOfTime
                    .Where(a => a.Selected == true)
                    .Select(n => int.Parse(n.Value))
                    .ToList();
        }

        public IEnumerable<int> GetSelectedDaysOfWeekIDs()
        {
            return DaysOfWeek
                    .Where(a => a.Selected == true)
                    .Select(n => int.Parse(n.Value))
                    .ToList();
        }

        public void SetAheadOfTimeValuesAsSelected(IEnumerable<int> aheadOfTimeValuesIds)
        {
            if (aheadOfTimeValuesIds == null)
                return;

            AheadOfTime
                .Where(a => aheadOfTimeValuesIds.Contains(int.Parse(a.Value)))
                .ToList()
                .ForEach(a => a.Selected = true);
        }

        public void SetDaysOfWeekAsSelected(IEnumerable<int> daysOfWeekIds)
        {
            if (daysOfWeekIds == null)
                return;

            DaysOfWeek
                .Where(a => daysOfWeekIds.Contains(int.Parse(a.Value)))
                .ToList()
                .ForEach(a => a.Selected = true);
        }
    }
}
