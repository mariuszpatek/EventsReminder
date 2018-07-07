using EventsReminder.BusinessLogic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace EventsReminder.Web.Controllers
{
    [Authorize]
    public class CalendarController : Controller
    {
        private readonly ICalendarService _calendarService;

        public CalendarController(ICalendarService calendarService)
        {
            _calendarService = calendarService;
        }

        public IActionResult Index()
        {           
            return View();
        }

        public JsonResult CalendarEvents()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var notrifications = _calendarService.GetAllUserNotificationToDisplay(userId);
            return Json(notrifications);
        }
    }
}