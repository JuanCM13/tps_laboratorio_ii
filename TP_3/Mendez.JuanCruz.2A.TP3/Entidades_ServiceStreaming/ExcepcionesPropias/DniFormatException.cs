using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCloud_Entidades
{
    public class DniFormatException : Exception
    {
        public DniFormatException()
            :this("Error, Formato de dni incorrecto, solo se admiten 8 numeros!")
        {}

        public DniFormatException(String msje)
            :this(msje , null)
        {}

        public DniFormatException(String msje, Exception inner)
            :base(msje , inner)
        {}
    }
}
