using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {
        public enum EMarca
        {
            Chevrolet, Ford, Renault, Toyota, BMW, Honda, HarleyDavidson
        }
        public enum ETamanio
        {
            Chico, Mediano, Grande
        }

        private string chasis;
        private ConsoleColor color;
        private EMarca marca;      

        public Vehiculo(String chasis, EMarca marca, ConsoleColor color)
        {
            this.chasis = chasis;
            this.marca = marca;
            this.color = color;
        }

        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        protected abstract ETamanio Tamanio { get;}

        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"CHASIS: {this.chasis}\nMARCA: {Enum.GetName(typeof(EMarca) , this.marca)}\n" +
                $"COLOR: {Enum.GetName(typeof(ConsoleColor), this.color)}");
            sb.AppendLine("---------------------\n");
            sb.Append("TAMAÑO : " + this.Tamanio);
            return sb.ToString();
        }

        /// <summary>
        /// Convierte de manera explicita el vehiculo pasado en strig, retornando la informacion de este
        /// </summary>
        /// <param name="p">Vehiculo</param>
        /// <returns>Cadena </returns>
        public static explicit operator String(Vehiculo p)
        {
            String ret = "Vehiculo sin instanciar";
            if(!(p is null))
            {
                ret = p.Mostrar();
            }
            return ret;
        }

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            bool ret = false;
            if(!(v1 is null) && !(v2 is null))
            {
                if(v1.chasis == v2.chasis)
                {
                    ret = true;
                }
            }
            return ret;
        }

        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }
}
