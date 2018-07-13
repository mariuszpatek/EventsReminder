using EventsReminder.Common.Enums;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;

namespace EventsReminder.BusinessLogic.MessagesSending
{
    public class SenderFactory
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger _logger;
        private readonly ISmsService _smsService;

        public SenderFactory(IConfiguration configuration, ILogger logger, ISmsService smsService)
        {
            _configuration = configuration;
            _logger = logger;
            _smsService = smsService;
        }
        public IMessageSenderStrategy CreateSenderObject(MessageType messageType)
        {
            IMessageSenderStrategy sender = null;
            switch (messageType)
            {
                case MessageType.Email:
                    sender = new EmailSender(_configuration, _logger);
                    break;
                case MessageType.SMS:
                    sender = new SmsSender(_smsService, _logger);
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Not implemented message type");
            }
            return sender;
        }
    }
}
