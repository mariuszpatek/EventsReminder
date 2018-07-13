using EventsReminder.BusinessLogic.MessagesSending;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace EventsReminder.BusinessLogic
{
    public class SmsService: ISmsService
    {
        private readonly IConfiguration _configuration;

        public SmsService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public bool SendSms(string body, string phoneNumber)
        {
            var sms = new List<Sms>()
            {
                new Sms
                {
                    device_id = int.Parse(_configuration["Data:SmsGatway:DeviceId"]),
                    message = body, phone_number = phoneNumber
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
                    return false;
                }
            }
        }
    }
}
