using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCloud_Entidades
{
    public class Regular : Cliente_BookCloud
    {
        private static Int32 cantidadLimite;

        public Regular()
        { }

        static Regular()
        {
            Regular.cantidadLimite = 10; 
        }

        public Regular(String dni, String nombre, String apellido, DateTime fecha, ENacionalidad nac , String mail, String numTelefono)
            :base(dni,nombre,apellido,fecha,nac,mail,numTelefono,Regular.cantidadLimite)
        {}
    }
}
