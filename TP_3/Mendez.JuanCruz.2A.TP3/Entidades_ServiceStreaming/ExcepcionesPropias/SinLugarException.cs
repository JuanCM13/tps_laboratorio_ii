using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCloud_Entidades
{
    public class SinLugarException : Exception
    {
        public SinLugarException()
            :this("Se ha alcanzado el limite del listado/coleccion..")
        { }

        public SinLugarException(String mensaje)
            :this(mensaje , null)
        { }

        public SinLugarException(String mensaje , Exception inner)
            :base(mensaje,inner)
        { }
    }
}
