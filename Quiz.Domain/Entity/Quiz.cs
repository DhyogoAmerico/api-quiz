using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz.Domain.Entity
{
    public class Quiz
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Fk_id_type_quiz { get; set; }
    }
}