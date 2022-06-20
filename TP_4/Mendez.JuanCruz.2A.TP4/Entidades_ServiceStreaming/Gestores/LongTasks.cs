using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCloud_Entidades
{
    public static class LongTasks
    {

        /// <summary>
        /// Hace un request de la lista de clientes, al archivo, trabaja de manera asincronica,
        /// Posee un delay de 6 segundos para simular retraso en traida de datos
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Cliente_BookCloud>> Traer_Clientes()
        {
            List<Cliente_BookCloud> clientes = await Task.Run(() => 
                                {
                                    System.Threading.Thread.Sleep(6000);
                                return new Serializado_Xml<List<Cliente_BookCloud>>().Deserializar("Clientes_File"); 
                                });
            return clientes;
        }

        /// <summary>
        /// Hace un request de la lista de publicaciones, al archivo, trabaja de manera asincronica
        /// No tiene delay, ya que asumo el escenario donde el listado de publicaciones al ser mas acotado que los
        /// demas listados, no demora nada en cargar...
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Publicacion>> Traer_Publicaciones()
        {
            List<Publicacion> publicaciones = await Task.Run(() =>
            {
                return new Serializado_Xml<List<Publicacion>>().Deserializar("Publicaciones_File");
            });

            return publicaciones;
        }

        /// <summary>
        /// Hace un request de la lista de ventas, al archivo, trabaja de manera asincronica,
        /// Posee un delay de 4 segundos para simular retraso en traida de datos
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Venta>> Traer_Ventas()
        {
            List<Venta> ventas = await Task.Run(() =>
            {
                System.Threading.Thread.Sleep(4000);
                return new Serializado_Json<List<Venta>>().Deserializar("Ventas_File");
            });

            return ventas;
        }

    }
}
