using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BookCloud_Entidades
{
    public static class GestionArchivos_Txt
    {
        private static String ruta;

        static GestionArchivos_Txt()
        {
            GestionArchivos_Txt.ruta = AppDomain.CurrentDomain.BaseDirectory;
        }       
        
        /// <summary>
        /// Metodo encargado de volcar el string pasado por parametro a formato .txt dentro del archivo llamado por default: Reclamos_File.txt
        /// </summary>
        /// <param name="data"> Informacion a guaurdar </param>
        public static void Grabar(String data)
        {
            string rutaCompleta = GestionArchivos_Txt.ruta + @"Reclamos_File.txt";

            try 
            {
                if( !(Directory.Exists(GestionArchivos_Txt.ruta)))
                {
                    Directory.CreateDirectory(GestionArchivos_Txt.ruta);
                }

                File.WriteAllText(rutaCompleta, data);
            }
            catch(Exception ex)
            {
                throw new Exception($"Error lanzado en metodo Guardar de la clase GestionArchivos_Txt\narchivo corrupto: " +
                    $"**{GestionArchivos_Txt.ruta}**", ex);
            }
        }            
    }
}
