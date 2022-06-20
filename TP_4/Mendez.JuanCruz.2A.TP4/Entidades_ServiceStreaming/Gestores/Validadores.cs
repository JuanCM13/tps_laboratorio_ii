using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCloud_Entidades
{
    public class Validadores
    {
        /// <summary>
        /// Valida que la cadena recibida solo este compuesta por letras o espacios en blanco
        /// </summary>
        /// <param name="data">Cadena a validar</param>
        /// <returns></returns>
        public static bool Validar_SoloLetras(String data)
        {
            bool ret = false;
            if (!String.IsNullOrWhiteSpace(data))
            {
                ret = true;

                data.Trim();
                foreach (Char item in data)
                {
                    if (!Char.IsLetter(item) && !Char.IsWhiteSpace(item))
                    {
                        ret = false;
                        break;
                    }
                }
            }
            return ret;
        }

        /// <summary>
        /// Genera numero random en el rango pasado por parametros
        /// </summary>
        /// <param name="d1">Minimo</param>
        /// <param name="d2">Maximo</param>
        /// <returns></returns>
        public static Int32 GenerarRandom_Int(Int32 d1 , Int32 d2)
        {
            Random aux = new();
            return aux.Next(d1, d2);
        }

        /// <summary>
        /// Convierte las primeras letras despues de un espacio en blanco a mayuscula (da formato de nombre y apellido)
        /// </summary>
        /// <param name="texto">Cadena a transformar</param>
        /// <returns></returns>
        public static String DarFormatoNombre_Apellido(String texto)
        {
            String aux = String.Empty;
            bool guia;
            bool fueEspacioEnBlanco;

            if (!(texto is null))
            {
                guia = true;
                fueEspacioEnBlanco = false;
                foreach (Char item in texto)
                {
                    if (guia == true || fueEspacioEnBlanco)
                    {
                        aux += Char.ToUpper(item);
                        fueEspacioEnBlanco = false;
                        guia = false;
                    }

                    if (Char.IsWhiteSpace(item))
                    {
                        fueEspacioEnBlanco = true;
                    }
                }
            }
            return aux;
        }

        /// <summary>
        /// Valida que la cadena recibida este compuesta solamente por numeros
        /// </summary>
        /// <param name="data">Cadena a validar</param>
        /// <returns></returns>
        public static bool Validar_SonNumeros(String data)
        {
            bool ret = false;

            if(!(data is null) && data.Length > 0)
            {
                ret = true;
                foreach(Char item in data)
                {
                    if(!Char.IsNumber(item))
                    {
                        ret = false;
                        break;
                    }
                }
            }
            return ret;
        }

        /// <summary>
        /// Valida que la cadena recibida, este compuesta solo por numeros y 8 digitos (Formato dni argentino)
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static bool Validar_EsDni(String data)
        {
            bool ret = false;
            if(!(data is null) && Validadores.Validar_SonNumeros(data))
            {
                ret = true;
                if(data.Length != 8)
                {
                    ret = false;
                }
            }
            return ret;
        }
    }
}
