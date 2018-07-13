namespace EventsReminder.BusinessLogic
{
    public interface ISmsService
    {
        bool SendSms(string body, string phoneNumber);
    }
}