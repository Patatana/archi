using MicroServiceMCQ.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MicroServiceMCQ.Application.QuestionTypeManage.Models
{
    public class QuestionTypeDetailDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static Expression<Func<QuestionType, QuestionTypeDetailDto>> Projection
        {
            get
            {
                return questionType => new QuestionTypeDetailDto
                {
                    Id = questionType.Id,
                    Name = questionType.Name
                };
            }
        }
    }
}
