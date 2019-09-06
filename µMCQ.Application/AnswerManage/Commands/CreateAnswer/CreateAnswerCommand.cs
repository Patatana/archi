using MediatR;
using MicroServiceMCQ.Domain.Entities;
using MicroServiceMCQ.Persistance;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MicroServiceMCQ.Application.AnswerManage.Commands.CreateAnswer
{
    public class CreateAnswerCommand : IRequest
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool Correct { get; set; }

        public class Handler : IRequestHandler<CreateAnswerCommand, Unit>
        {
            private readonly MicroServiceMCQDbContext _context;
            private readonly IMediator _mediator;

            public Handler(MicroServiceMCQDbContext context, IMediator mediator)
            {
                _context = context;
                _mediator = mediator;
            }

           

            public async Task<Unit> Handle(CreateAnswerCommand request, CancellationToken cancellationToken)
            {
                var entity = new Answer
                {
                    Id = request.Id,
                    Text = request.Text,
                    Correct = request.Correct
                };

                _context.Answer.Add(entity);

                await _context.SaveChangesAsync(cancellationToken);

                await _mediator.Publish(new AnswerCreated { Id = entity.Id }, cancellationToken);

                return Unit.Value;
            }
        }
    }
}
