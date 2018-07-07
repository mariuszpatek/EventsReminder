using System;

namespace EventsReminder.Common
{
    [Serializable]
    public class ToastMessage
    {
        public string Message { get; set; }
        public bool Success { get; set; }
    }
}
