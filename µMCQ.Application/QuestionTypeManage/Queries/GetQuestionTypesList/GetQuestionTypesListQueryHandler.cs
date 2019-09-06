using AutoMapper;
using MediatR;
using MicroServiceMCQ.Application.QuestionTypeManage.Models;
using MicroServiceMCQ.Persistance;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MicroServiceMCQ.Application.QuestionTypeManage.Queries.GetQuestionTypesList
{
    public class GetQuestionTypesListQueryHandler : IRequestHandler<GetQuestionTypesListQuery, List<QuestionTypeDto>>
    {
        private readonly MicroServiceMCQDbContext _context;
        

        public GetQuestionTypesListQueryHandler(MicroServiceMCQDbContext context)
        {
            _context = context;
         
        }

        public Task<List<QuestionTypeDto>> Handle(GetQuestionTypesListQuery request, CancellationToken cancellationToken)
        {
            return _context.QuestionType.Select(QuestionTypeDto.Projection).ToListAsync();
        }
    }
}
