using MicroServiceMCQ.Application.QuestionManage.Manage.Queries.GetQuestionsList;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServiceMCQ.Application.QuestionsManage.Manage.Queries.GetQuestionsList
{
    public class QuestionsListViewModel
    {
        public IList<QuestionLookupModel> QuestionTypes { get; set; }
    }
}
