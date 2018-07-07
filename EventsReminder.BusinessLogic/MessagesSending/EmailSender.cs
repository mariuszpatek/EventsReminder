using EventsReminder.Model.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Polly;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;

namespace EventsReminder.BusinessLogic.MessagesSending
{
    public class EmailSender : IMessageSenderStrategy
    {
        private readonly string _smtpName;
        private readonly string _sourceEmailAddress;
        private readonly string _smtpUserName;
        private readonly string _smtpPassword;
        private readonly int _smtpPort;
        private readonly IConfiguration _configuration;
        private readonly ILogger _logger;
        private readonly int maxRetryAttempts = 5;
        private readonly TimeSpan pauseBetweenFailures = TimeSpan.FromSeconds(3);

        public EmailSender(IConfiguration configuration, ILogger logger)
        {
            _configuration = configuration;
            _logger = logger;
            _smtpName = _configuration["Data:Messages:Emails:SmtpName"];
            _sourceEmailAddress = _configuration["Data:Messages:Emails:SourceEmailAddress"];
            _smtpUserName = _configuration["Data:Messages:Emails:SmtpUserName"];
            _smtpPassword = _configuration["Data:Messages:Emails:SmtpPassword"];
            _smtpPort = int.Parse(_configuration["Data:Messages:Emails:SmtpPort"]);
        }

        public bool SendMessage(Message message)
        {
            try
            {
                var mail = CreateMailMessage(message.MessageTarget, message.Subject,message.Body);

                var resultOfRetry = Policy.Handle<SmtpException>()
                    .WaitAndRetry(maxRetryAttempts
                        , i => pauseBetweenFailures
                        , (ex, t) => _logger.LogError("Smtp error occured: " + ex.ToString() + $" Waiting {t.Seconds} seconds before retryning. "))
                    .ExecuteAndCapture(() => SendEmail(mail)).Outcome;

                if (resultOfRetry == OutcomeType.Failure)
                    return false;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                return false;
            }

            return true;
        }

        private void SendEmail(MailMessage mail)
        {
            using (var smtpClient = new SmtpClient(_smtpName, _smtpPort))
            {
                smtpClient.Timeout = 5000;
                smtpClient.Credentials = new NetworkCredential(_smtpUserName, _smtpPassword);
                //smtpClient.EnableSsl = true;

                smtpClient.Send(mail);
            }
        }

        private MailMessage CreateMailMessage(string toEmailAddress, string subject, string body, List<Attachment> attachments = null)
        {
            attachments = attachments ?? new List<Attachment>();
            var mail = new MailMessage
            {
                IsBodyHtml = true,
                From = new MailAddress(_sourceEmailAddress)
            };
            mail.To.Add(toEmailAddress);
            mail.Subject = subject;
            mail.Body = body ?? "";
            foreach (var attachment in attachments)
                mail.Attachments.Add(attachment);

            return mail;
        }
    }
}
