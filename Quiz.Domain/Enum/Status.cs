using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz.Domain.Enum
{
    public class Status
    {
        public static string Active => "A";
        public static string Excluded => "E";
        public static string Inactive => "I";
    }
}