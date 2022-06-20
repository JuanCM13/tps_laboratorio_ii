using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCloud_Entidades
{
    public class SqlTypeExcepcion : Exception
    {
        public SqlTypeExcepcion()
            : this("Error con la base de datos de tipo Sql..")
        { }

        public SqlTypeExcepcion(String mensaje)
            : this(mensaje, null)
        { }

        public SqlTypeExcepcion(String mensaje, Exception inner)
            : base(mensaje, inner)
        { }
    }
}
