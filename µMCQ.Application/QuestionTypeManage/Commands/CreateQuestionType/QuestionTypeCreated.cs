using MediatR;
using MicroServiceMCQ.Application.Interfaces;
using MicroServiceMCQ.Application.Notifications;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MicroServiceMCQ.Application.QuestionTypeManage.Commands.CreateQuestionType
{
    public class QuestionTypeCreated : INotification
    {
        public int Id { get; set; }

        public class QuestionTypeCreatedHandler : INotificationHandler<QuestionTypeCreated>
        {
            private readonly INotificationService _notification;

            public QuestionTypeCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }

            public async Task Handle(QuestionTypeCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());
            }
        }
    }
}
