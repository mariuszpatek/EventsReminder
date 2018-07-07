using AutoMapper;
using EventsReminder.Common.Enums;
using EventsReminder.DataAccess.Repositories;
using EventsReminder.Model.Models;
using EventsReminder.Model.ViewModels.Account;
using Microsoft.AspNetCore.Hosting;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EventsReminder.BusinessLogic
{
    public class MessageService : IMessageService
    {
        private readonly IMessageRepository _messageRepository;
        private readonly IHostingEnvironment _hostingEnvironment;

        public MessageService(IMessageRepository messageRepository, IHostingEnvironment hostingEnvironment)
        {
            _messageRepository = messageRepository;
            _hostingEnvironment = hostingEnvironment;
        }
        public Message CreateMessage(Notification notification)
        {
            var message = new Message();
            message.NotificationId = notification.NotificationId;

            if (notification.MessageType == MessageType.Email)
            {
                message.Subject = $"Events Reminder - przypomnienie ({notification.Name})";
                string contentRootPath = _hostingEnvironment.WebRootPath;
                string body = File.ReadAllText(contentRootPath + @"/messagetemplate/ReminderEmailTemplate.html");
                body = body.Replace("{NotificationBody}", notification.Description);
                body = body.Replace("{NotificationName}", notification.Name);
                message.Body = body;
                message.MessageTarget = notification.User.Email;
            }
            else if (notification.MessageType == MessageType.SMS)
            {
                message.Subject = "SMS: " + notification.Name;
                if (notification.Description.Length > 120)
                {
                    message.Body = notification.Description.Substring(0, 120);
                }
                else
                {
                    message.Body = notification.Description;
                }
                message.MessageTarget = notification.User.PhoneNumber;
            }

            return message;
        }

        public IEnumerable<MessageViewModel> GetUserMessages(string userId)
        {
            var messages = _messageRepository.GetAllUserMessages(userId);
            var messagesModel = Mapper.Map<List<MessageViewModel>>(messages);
            return messagesModel?.OrderByDescending(m => m.DateOfDispatch);
        }

        public void AddMessage(Message message)
        {
            _messageRepository.AddMessage(message);
        }

        public void Save()
        {
            _messageRepository.Save();
        }
    }
}
