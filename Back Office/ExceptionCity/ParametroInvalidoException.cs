﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionCity
{
    public class ParametroInvalidoException : ExceptionsCity
    {
        public ParametroInvalidoException()
            : base()
        { }

        public ParametroInvalidoException(string message)
            : base(message)
        {
        }

        public ParametroInvalidoException(string message, Exception inner)
            : base(message, inner)
        {
        }

        public ParametroInvalidoException(string codigo, string message, Exception inner)
            : base(codigo, message, inner)
        {
        }
    }
}
