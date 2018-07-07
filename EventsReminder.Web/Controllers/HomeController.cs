using EventsReminder.BusinessLogic;
using EventsReminder.Common.Clock;
using Microsoft.AspNetCore.Mvc;
using System;

namespace EventsReminder.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGlobalEventService _eventService;

        public HomeController(IGlobalEventService eventService)
        {
            _eventService = eventService;
        }

        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
                return View(_eventService.GetBlobalEventByDate(SystemTime.Now.Date));

            return View();
        }
    }
}