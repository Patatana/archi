using MediatR;
using MicroServiceMCQ.Application.Interfaces;
using MicroServiceMCQ.Application.Notifications;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MicroServiceMCQ.Application.QuestionsManage.Manage.Commands.CreateQuestion
{
    public class QuestionCreated : INotification
    {
        public int Id { get; set; }

        public class QuestionCreatedHandler : INotificationHandler<QuestionCreated>
        {
            private readonly INotificationService _notification;

            public QuestionCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }

            public async Task Handle(QuestionCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());
            }
        }
    }
}
