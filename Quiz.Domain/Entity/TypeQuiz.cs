using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz.Domain.Entity
{
    public class TypeQuiz
    {
        public int Id { get; set; }
        public string? Type { get; set; }
        public string? Level { get; set; }
    }
}