using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MicroServiceMCQ.Application.QuestionTypeManage.Models
{
    public class QuestionTypeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static Expression<Func<Domain.Entities.QuestionType, QuestionTypeDto>> Projection
        {
            get
            {
                return t => new QuestionTypeDto
                {
                    Id = t.Id,
                    Name = t.Name               
                };
            }
        }
    }
}
