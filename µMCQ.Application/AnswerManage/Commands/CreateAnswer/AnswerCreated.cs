using MediatR;
using MicroServiceMCQ.Application.Interfaces;
using MicroServiceMCQ.Application.Notifications;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MicroServiceMCQ.Application.AnswerManage.Commands.CreateAnswer
{
    public class AnswerCreated : INotification
    {
        public int Id { get; set; }

        public class AnswerCreatedHandler : INotificationHandler<AnswerCreated>
        {
            private readonly INotificationService _notification;

            public AnswerCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }

            public async Task Handle(AnswerCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());
            }
        }
    }
}
