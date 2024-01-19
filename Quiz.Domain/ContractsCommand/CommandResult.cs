using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz.Domain.ContractsCommand
{
    public class CommandResult<T>
    {
        public bool success { get; set; }
        public T data { get; set; }
        public static CommandResult Send(bool success, T data)
        {
            return new() {
                success,
                data
            };
        }
    }
}