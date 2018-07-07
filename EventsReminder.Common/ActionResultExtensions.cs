using Microsoft.AspNetCore.Mvc;

namespace EventsReminder.Common
{
    public static class ActionResultExtensions 
    {
        public static IActionResult WithError(this IActionResult result, string message)
        {
            return new AlertDecoratorResult(result, false, message);
        }

        public static IActionResult WithSuccess(this IActionResult result, string message)
        {
            return new AlertDecoratorResult(result, true, message);
        }
    }
}
