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
        private readonly IConfiguration _configuration;
        private readonly ILogger _logger;

        public SmsSender(IConfiguration configuration, ILogger logger)
        {
            _logger = logger;
            _configuration = configuration;
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
                var sms = new List<Sms>()
                {
                    new Sms
                    {
                        device_id = int.Parse(_configuration["Data:SmsGatway:DeviceId"]),
                        message = message.Body, phone_number = message.MessageTarget
                    }
                };
                var content = new StringContent(JsonConvert.SerializeObject(sms), Encoding.UTF8, "application/json");
                using (var httpClient = new HttpClient())
                {
                    httpClient.DefaultRequestHeaders.Add("Authorization", _configuration["Data:SmsGatway:Authorization"]);
                    var result = httpClient.PostAsync(_configuration["Data:SmsGatway:Endpoint"], content).Result;

                    if (result.IsSuccessStatusCode)
                    {
                        return true;
                    }
                    else
                    {
                        var test = result.Content.ReadAsStringAsync().Result;
                        _logger.LogError($"Error during send SMS: {result.Content.ReadAsStringAsync().Result}");
                        return false;
                    }
                }
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
