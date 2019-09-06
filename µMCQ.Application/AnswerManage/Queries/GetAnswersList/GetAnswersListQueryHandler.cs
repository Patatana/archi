using AutoMapper;
using MediatR;
using MicroServiceMCQ.Persistance;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MicroServiceMCQ.Application.AnswerManage.Queries.GetAnswersList
{
    public class GetAnswersListQueryHandler : IRequestHandler<GetAnswersListQuery, AnswersListViewModel>
    {
        private readonly MicroServiceMCQDbContext _context;
        private readonly IMapper _mapper;

        public GetAnswersListQueryHandler(MicroServiceMCQDbContext context)
        {

        }

        public Task<AnswersListViewModel> Handle(GetAnswersListQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
