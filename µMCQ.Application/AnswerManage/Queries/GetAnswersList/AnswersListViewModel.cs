using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServiceMCQ.Application.AnswerManage.Queries.GetAnswersList
{
    public class AnswersListViewModel
    {
        public IList<AnswerLookupModel> Answers { get; set; }
    }
}
