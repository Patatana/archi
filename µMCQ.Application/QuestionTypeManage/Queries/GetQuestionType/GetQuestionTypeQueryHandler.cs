using MediatR;
using MicroServiceMCQ.Application.QuestionTypeManage.Models;
using MicroServiceMCQ.Domain.Entities;
using MicroServiceMCQ.Persistance;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MicroServiceMCQ.Application.QuestionTypeManage.Queries.GetQuestionType
{
    public class GetQuestionTypeQueryHandler : IRequestHandler<GetQuestionTypeQuery, QuestionTypeDetailDto>
    {
        private readonly MicroServiceMCQDbContext _context;


        public GetQuestionTypeQueryHandler(MicroServiceMCQDbContext context)
        {
            _context = context;

        }

        public Task<QuestionTypeDetailDto> Handle(GetQuestionTypeQuery request, CancellationToken cancellationToken)
        {
            var entity = _context.QuestionType.Select(QuestionTypeDetailDto.Projection).Where(t => t.Id == request.Id).FirstOrDefaultAsync();

            //if (entity == null)
            //{
            //    throw new NotFoundException(nameof(QuestionType), request.Id);
            //}

            return entity;
        }
    }
}
