using MediatR;
using MicroServiceMCQ.Application.QuestionTypeManage.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServiceMCQ.Application.QuestionTypeManage.Queries.GetQuestionTypesList
{
    public class GetQuestionTypesListQuery : IRequest<List<QuestionTypeDto>>
    {
    }
}
