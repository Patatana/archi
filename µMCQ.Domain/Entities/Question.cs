using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServiceMCQ.Domain.Entities
{
    public class Question
    {
        public Question()
        {
            Answers = new HashSet<Answer>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int Value { get; set; }
        public int QuestionTypeId { get; set; }
        public virtual QuestionType QuestionType { get; set; }
        public virtual ICollection<Answer>  Answers { get; private set; }

    }
}
