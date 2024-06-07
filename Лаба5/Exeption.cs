using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба5
{
    public class StringTooShortException : Exception
    {
        public StringTooShortException(string? message) : base(message)
        {
        }
    }
}
