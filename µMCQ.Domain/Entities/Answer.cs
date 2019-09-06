using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServiceMCQ.Domain.Entities
{
    public class Answer
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool Correct { get; set; }
        public int QuestionId { get; set; }
        public virtual Question Question { get; set; }
    }
}
