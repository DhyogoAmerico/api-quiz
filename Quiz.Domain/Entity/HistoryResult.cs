using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz.Domain.Entity
{
    public class HistoryResult
    {
        public int Id { get; set; }
        public int Fk_id_quiz { get; set; }
        public int Fk_id_user { get; set; }
        public double Punctuation { get; set; }
    }
}