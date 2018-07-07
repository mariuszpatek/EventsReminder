using EventsReminder.BusinessLogic;
using EventsReminder.Common;
using EventsReminder.Model.ViewModels;
using EventsReminder.Web.Validation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EventsReminder.Web.Controllers
{
    [Authorize]
    public class NotificationController : Controller
    {
        private readonly IPopulateService _populateService;
        private readonly INotificationService _notificationService;
        private readonly ICategoryService _categoryService;

        public NotificationController(IPopulateService populateService, INotificationService notificationService, ICategoryService categoryService)
        {
            _populateService = populateService;
            _notificationService = notificationService;
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var notificationsToDisplay = _notificationService.GetAllUserNotificationToDisplay(userId);
            var notificationCategories = notificationsToDisplay?
                .Select(n => n.Categories)?
                .Where(c => c.Count > 0)
                .SelectMany(c => c)
                .Distinct()
                .ToList();

            ViewData["Categories"] = notificationCategories;
            return View(notificationsToDisplay);
        }
        
        public IActionResult Create()
        {
            NotificationViewModel model = new NotificationViewModel();
            model.DaysOfWeek = _populateService.GetDaysOfWeek();
            model.AheadOfTime = _populateService.GetAheadOfTimeValues();
            model.SendingHour = 8;

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(NotificationViewModel model)
        {
            Validator.CheckEventDateForNotification(model?.EventDate, model.NotificationType?.ToString(), ModelState);

            if (!ModelState.IsValid)
            {
                model.DaysOfWeek = _populateService.GetDaysOfWeek();
                model.AheadOfTime = _populateService.GetAheadOfTimeValues();
                return View(model);
            }

            var categoriesTask = _categoryService.GetCategoriesIds(model.Name);
            model.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var categoriesIds = await categoriesTask;
            model.Categories = categoriesIds;
            _notificationService.AddNotification(model);

            return RedirectToAction("Index")
                .WithSuccess("Pomyślnie zapisano powiadomienie");
        }

        public IActionResult Edit(int id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var notification = _notificationService.GetUserNotification(userId, id);
            return View(notification);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(NotificationViewModel model)
        {
            Validator.CheckEventDateForNotification(model?.EventDate, model.NotificationType?.ToString(), ModelState);

            if (!ModelState.IsValid)
            {
                model.DaysOfWeek = _populateService.GetDaysOfWeek();
                model.AheadOfTime = _populateService.GetAheadOfTimeValues();
                return View(model);
            }

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            _notificationService.UpdateNotification(userId, model);

            return RedirectToAction("Index")
                .WithSuccess("Pomyślnie zapisano zmiany"); ;
        }
    }
}
