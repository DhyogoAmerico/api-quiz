using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz.Domain.DataType
{
    public class Email
    {
        private string? _email_;
        public string? _email
        {
            get { return _email_; }
            set { _email_ = value; }
        }

        public Email(string? email)
        {
            _email = email;
        }
    }
}