using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCloud_Entidades
{
    public class ClienteExistenteException : Exception
    {
        public ClienteExistenteException()
            : this("Error de tipo ClienteException..")
        {}

        public ClienteExistenteException(String mensaje)
            : this(mensaje , null)
        {}

        public ClienteExistenteException(String mensaje , Exception ex)
            : base(mensaje,ex)
        { }
    }
}
