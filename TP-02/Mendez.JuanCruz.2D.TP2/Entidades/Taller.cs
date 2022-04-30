using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public class Taller
    {
        private List<Vehiculo> vehiculos;
        private int espacioDisponible;
        
        public enum ETipo
        {
            Ciclomotor , Sedan, SUV, Todos
        }

        #region "Constructores"
        private Taller()
        {
            this.vehiculos = new List<Vehiculo>();
        }
        public Taller(int espacioDisponible) :this()
        {
            this.espacioDisponible = espacioDisponible;
        }
        #endregion

        #region "Sobre escritura"
        /// <summary>
        /// Muestro el estacionamiento y TODOS los vehículos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Taller.Listar(this, ETipo.Todos);
        }
        #endregion

        #region "Métodos"

        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="taller">Elemento a exponer</param>
        /// <param name="ETipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns></returns>
        public static string Listar(Taller taller, ETipo tipo)
        {
            StringBuilder sb = new StringBuilder(); 
            Int32 tipoAux;
            String aux;
            String aux2;

            if (!(taller is null))
            {
                tipoAux = (Int32)tipo;
                aux = Enum.GetName(typeof(ETipo), tipo).ToLower();
                
                sb.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles", taller.vehiculos.Count, taller.espacioDisponible);
                sb.AppendLine("");

                foreach (Vehiculo v in taller.vehiculos)
                {
                    aux2 = (v.GetType().Name).ToString();
                    if( (aux2.ToLower() == aux) || (aux == "todos"))
                    {
                        sb.AppendLine(v.Mostrar());
                    }
                }
            }
            else
            {
                sb.AppendLine("El taller no fue instanciado..");
            }

            return sb.ToString();
        }
        #endregion

        #region "Operadores"
        /// <summary>
        /// Agregará un elemento a la lista
        /// </summary>
        /// <param name="taller">Objeto donde se agregará el elemento</param>
        /// <param name="vehiculo">Objeto a agregar</param>
        /// <returns></returns>
        public static Taller operator +(Taller taller, Vehiculo vehiculo)
        {
            bool esta = false;
            if(!(taller is null) && !(vehiculo is null))
            {
                foreach (Vehiculo v in taller.vehiculos)
                {
                    if (v == vehiculo)
                    {
                        esta = true;
                        break;
                    }
                }

                if (!esta && taller.vehiculos.Count < taller.espacioDisponible)
                {
                    taller.vehiculos.Add(vehiculo);
                }
            }
                    
            return taller;
        }
        /// <summary>
        /// Quitará un elemento de la lista
        /// </summary>
        /// <param name="taller">Objeto donde se quitará el elemento</param>
        /// <param name="vehiculo">Objeto a quitar</param>
        /// <returns></returns>
        public static Taller operator -(Taller taller, Vehiculo vehiculo)
        {
            Int32 i = 0;
            if (!(taller is null) && !(vehiculo is null))
            {
                foreach (Vehiculo v in taller.vehiculos)
                {
                    if (v == vehiculo)
                    {
                        taller.vehiculos.RemoveAt(i);
                        break;
                    }
                    i++;
                }
            }
            return taller;
        }
        #endregion
    }
}
