using MicroServiceMCQ.Application.Interfaces;
using MicroServiceMCQ.Application.Notifications;
using System;
using System.Threading.Tasks;

namespace MicroServiceMCQ.Infrastructure
{
    public class NotificationService : INotificationService
    {
        public Task SendAsync(Message message)
        {
            return Task.CompletedTask;
        }
    }
}
