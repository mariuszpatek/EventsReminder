namespace EventsReminder.BusinessLogic
{
    public interface ICalendarService
    {
        string GetAllUserNotificationToDisplay(string userId);
    }
}