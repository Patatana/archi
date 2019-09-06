using MicroServiceMCQ.Application.Notifications;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroServiceMCQ.Application.Interfaces
{
    public interface INotificationService
    {
        Task SendAsync(Message message);
    }
}
