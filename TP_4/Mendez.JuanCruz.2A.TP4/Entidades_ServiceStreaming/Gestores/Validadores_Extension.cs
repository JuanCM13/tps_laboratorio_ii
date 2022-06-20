using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCloud_Entidades
{
    public static class Validadores_Extension
    {
        /// <summary>
        /// Metodo de extension de la clase Validadores, Calcula la edad, a partir del dateTime recibido por parametro
        /// </summary>
        /// <param name="fecha">Fecha a calcular</param>
        /// <returns></returns>
        public static Int32 CalcularEdad(this Validadores validador , DateTime fecha)
        {
            Int32 edad = (int)((DateTime.Now - fecha).TotalDays / 365.242199);

            if (edad < 1 || edad > 120)
            {
                edad = -1;
            }
            return edad;
        }
    }
}
