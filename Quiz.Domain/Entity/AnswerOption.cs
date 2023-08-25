using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz.Domain.Entity
{
    public class AnswerOptions
    {
        public int Id { get; set; }
        public string? Answer { get; set; }
        public bool Correct { get; set; }
        public int Fk_id_question { get; set; }
    }
}