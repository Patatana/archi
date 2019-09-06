using MediatR;
using MicroServiceMCQ.Domain.Entities;
using MicroServiceMCQ.Persistance;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MicroServiceMCQ.Application.QuestionTypeManage.Commands.CreateQuestionType
{
    public class CreateQuestionTypeCommand : IRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public class Handler : IRequestHandler<CreateQuestionTypeCommand, Unit>
        {
            private readonly MicroServiceMCQDbContext _context;
            private readonly IMediator _mediator;

            public Handler(MicroServiceMCQDbContext context, IMediator mediator)
            {
                _context = context;
                _mediator = mediator;
            }

           

            public async Task<Unit> Handle(CreateQuestionTypeCommand request, CancellationToken cancellationToken)
            {
                var entity = new QuestionType
                {
                    Id = request.Id,
                    Name = request.Name
                };

                _context.QuestionType.Add(entity);

                await _context.SaveChangesAsync(cancellationToken);

                await _mediator.Publish(new QuestionTypeCreated { Id = entity.Id }, cancellationToken);

                return Unit.Value;
            }
        }
    }
}
