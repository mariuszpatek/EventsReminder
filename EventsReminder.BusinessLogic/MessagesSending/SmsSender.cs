using EventsReminder.Model.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace EventsReminder.BusinessLogic.MessagesSending
{
    public class SmsSender : IMessageSenderStrategy
    {
        private readonly ISmsService _smsService;
        private readonly ILogger _logger;

        public SmsSender(ISmsService smsService, ILogger logger)
        {
            _logger = logger;
            _smsService = smsService;
        }

        public bool SendMessage(Message message)
        {
            if (string.IsNullOrEmpty(message.MessageTarget))
            {
                _logger.LogError($"Fail to send SMS. User haven't entered his number. Notification Id: {message.NotificationId}");
                return false;
            }

            try
            {
                var result = _smsService.SendSms(message.Body, message.MessageTarget);
                if (!result)
                {
                    _logger.LogError($"Error during send SMS to: {message.MessageTarget}");
                }

                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                return false;
            }
        }
    }

    public class Sms
    {
        public string phone_number { get; set; }
        public string message { get; set; }
        public int device_id { get; set; }
    }
}
