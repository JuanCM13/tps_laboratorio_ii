using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCloud_Entidades
{
    public class DateTimeException : Exception
    {
        public DateTimeException()
            : this("Error, fecha fuera de rango!")
        { }

        public DateTimeException(String msje)
            : this(msje, null)
        { }

        public DateTimeException(String msje, Exception inner)
            : base(msje, inner)
        { }
    }
}
