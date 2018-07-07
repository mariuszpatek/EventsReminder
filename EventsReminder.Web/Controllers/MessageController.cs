using EventsReminder.BusinessLogic;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace EventsReminder.Web.Controllers
{
    public class MessageController : Controller
    {
        private readonly IMessageService _messageService;
        public MessageController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public IActionResult Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var messages = _messageService.GetUserMessages(userId);
            return View(messages);
        }
    }
}