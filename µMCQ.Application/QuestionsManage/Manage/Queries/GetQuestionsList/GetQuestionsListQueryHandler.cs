using AutoMapper;
using MediatR;
using MicroServiceMCQ.Persistance;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MicroServiceMCQ.Application.QuestionsManage.Manage.Queries.GetQuestionsList
{
    public class GetQuestionsListQueryHandler : IRequestHandler<GetQuestionsListQuery, QuestionsListViewModel>
    {
        private readonly MicroServiceMCQDbContext _context;
        private readonly IMapper _mapper;

        public GetQuestionsListQueryHandler(MicroServiceMCQDbContext context)
        {

        }

        public Task<QuestionsListViewModel> Handle(GetQuestionsListQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
