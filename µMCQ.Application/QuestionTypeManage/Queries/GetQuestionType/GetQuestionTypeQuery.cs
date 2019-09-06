using MediatR;
using MicroServiceMCQ.Application.QuestionTypeManage.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServiceMCQ.Application.QuestionTypeManage.Queries.GetQuestionType
{
    public class GetQuestionTypeQuery : IRequest<QuestionTypeDetailDto>
    {
        public int Id { get; set; }
    }
}
