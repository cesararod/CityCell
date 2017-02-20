using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionCity
{
    public class ExceptionCcConBD : ExceptionsCity
    {
        public ExceptionCcConBD(): base()
        {}
        
        public ExceptionCcConBD(string message)
            : base(message)
        {}

        public ExceptionCcConBD(string message, Exception inner)
            : base(message, inner)
        {}

        public ExceptionCcConBD(string codigo, string message, Exception inner)
            : base(codigo, message, inner)
        {}
    }
}
