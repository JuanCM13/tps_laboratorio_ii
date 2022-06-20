using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace BookCloud_Entidades
{
    public class Serializado_Json<T> : ISerializados<T>
    {
        private String ruta;
        
        public Serializado_Json()
        {
            this.ruta = AppDomain.CurrentDomain.BaseDirectory;
        }

        /// <summary>
        /// Metodo encargado de Serializar la informacion pasada por parametro generico, a el archivo de formato .json con nombre pasado por parametro
        /// </summary>
        /// <param name="tipoT">Objeto a serializar</param>
        /// <param name="nombreParaArchivo">Nombre del archivo a crear o actualizar</param>
        public void Serializar(T tipoT, String nombreParaArchivo)
        {
            String rutaCompleta = this.ruta + nombreParaArchivo;

            try
            {
                if( !Directory.Exists(this.ruta))
                {
                    Directory.CreateDirectory(this.ruta);
                }

                File.WriteAllText(rutaCompleta, JsonSerializer.Serialize(tipoT));
            }
            catch(Exception ex)
            {
                throw new Exception($"Error lanzado en metodo Serializar de la clase Serializado_Json\narchivo corrupto: " +
                                    $"**{this.ruta}**", ex);
            }
        }

        /// <summary>
        /// Metodo encargado de deserializar informacion de un archivo a un tipo generico especificado por el user, la data se extrae del archivo pedido por
        /// parametro del tipo json, si no llega a encontrarse tira excepcion.
        /// </summary>
        /// <param name="nombreArchivo">Archivo de donde extraer informacion</param>
        /// <returns></returns>
        public T Deserializar(String nombreArchivo)
        {
            string archivo = string.Empty;
            T auxT = default;
            String[] archivosGuardadosEnCarpetaDeRuta;


            try
            {
                if(Directory.Exists(this.ruta))
                {
                    archivosGuardadosEnCarpetaDeRuta = Directory.GetFiles(this.ruta);
                    foreach(String item in archivosGuardadosEnCarpetaDeRuta)
                    {
                        if(item.Contains(nombreArchivo))
                        {
                            archivo = item;
                            break;
                        }
                    }

                    if( !String.IsNullOrEmpty(archivo))
                    {
                        auxT = JsonSerializer.Deserialize<T>(File.ReadAllText(archivo) , new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                    }
                }
                return auxT;
            }
            catch(Exception ex)
            {
                throw new Exception($"Error lanzado en metodo Deserializar de la clase Serializado_Json\narchivo corrupto: " +
                                    $"**{this.ruta}**", ex);
            }
        }

    }
}
