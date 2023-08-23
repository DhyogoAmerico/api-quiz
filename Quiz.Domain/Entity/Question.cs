using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz.Domain.Entity
{
    public class Questions
    {
        public int Id { get; set; }
        public string? Question { get; set; }
        public int Fk_id_quiz { get; set; }
    }
}