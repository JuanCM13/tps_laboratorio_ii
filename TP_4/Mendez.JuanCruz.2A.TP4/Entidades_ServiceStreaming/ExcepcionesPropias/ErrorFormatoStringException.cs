using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCloud_Entidades
{
    public class ErrorFormatoStringException : Exception
    {
        public ErrorFormatoStringException()
            : this("Error, Formato de caracteres incorrectos!")
        { }

        public ErrorFormatoStringException(String msje)
            : this(msje, null)
        { }

        public ErrorFormatoStringException(String msje, Exception inner)
            : base(msje, inner)
        { }
    }
}
