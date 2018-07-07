using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.DependencyInjection;

namespace EventsReminder.Common
{
    public class AlertDecoratorResult : ActionResult
    { 
        public AlertDecoratorResult(IActionResult innerResult, bool success, string message)
        {
            ToastMessage.Success = success;
            ToastMessage.Message = message;
            BaseResult = innerResult;
        }

        public ToastMessage ToastMessage { get; set; } = new ToastMessage();
        public IActionResult BaseResult { get; private set; }

        public override void ExecuteResult(ActionContext context)
        {
            var factory = context.HttpContext.RequestServices.GetService<ITempDataDictionaryFactory>();
            var tempData = factory.GetTempData(context.HttpContext);
            tempData.Put("ToastMessage", ToastMessage);

            BaseResult.ExecuteResultAsync(context);
        }
    }
}
