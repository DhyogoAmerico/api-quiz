using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz.Domain.ContractsCommand
{
    public class CommandResult
    {
        public bool success { get; set; }
        public dynamic data { get; set; }
        public static CommandResult Send(bool success, dynamic data)
        {
            return new() {
                success = success,
                data = data
            };
        }
    }
}