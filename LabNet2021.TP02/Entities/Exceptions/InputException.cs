using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    class InputException : Exception
    {
        public InputException() : base() { }

        public InputException(string message) : base(message) { }

        public InputException(string message, Exception inner) : base(message, inner) { }
    }
}
