using EventsReminder.BusinessLogic;
using EventsReminder.DataAccess.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace EventsReminder.Web.Controllers.Api
{
    [Route("api/notification")]
    public class NotificationController : Controller
    {
        private readonly INotificationService _notificationService;
        private readonly INotificationRepository _notificationRespository;
        public static readonly object LockObject = new object();


        public NotificationController(INotificationService notificationService, INotificationRepository notificationRespository)
        {
            _notificationService = notificationService;
            _notificationRespository = notificationRespository;
        }

        [HttpDelete("{id}")]
        [Authorize]
        public IActionResult Delete(int id)
        {
            var notification = _notificationRespository.GetNotification(id);
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (notification == null || userId != notification.UserId)
            {
                return NotFound();
            }

            notification.IsActive = false;
            _notificationRespository.Save();

            return NoContent();
        }

        [HttpPost]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Route("triggerDispatch")]
        public IActionResult SendNotificatonsToUsers()
        {
            lock (LockObject)
            {
                var respone = _notificationService.SendNotificatonsToUsers();

                if (respone.notSentNotifications.Count == 0)
                    return Ok(respone);

                return StatusCode(StatusCodes.Status500InternalServerError, respone);
            }
        }
    }
}
