using Microsoft.AspNetCore.Mvc;

namespace EventsReminder.Web.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Index()
        {
            return View("Error");
        }
    }
}