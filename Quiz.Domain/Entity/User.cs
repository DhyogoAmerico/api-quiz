using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Quiz.Domain.DataType;

namespace Quiz.Domain.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Email? Email { get; set; }
        public string? Password { get; set; }
        public string? Phone { get; set; }
    }
}