using System;
using System.Text;

namespace Entidades
{
    public class Operando
    {
        //fields
        private double numero;

        //constr
        public Operando() : this("0")
        {
        }

        public Operando(String strNumero)
        {
            this.Numero = strNumero;
        }

        public Operando(double numero) : this(numero.ToString())
        {
        }

        //props
        private String Numero
        {
            set { this.numero = this.ValidarOperando(value); }
        }

        //methods

        /// <summary>
        /// Valida que la cadena sea de tipo double (solo numeros)
        /// </summary>
        /// <param name="strNumero"> cadena donde se aloja el dato a validar </param>
        /// <returns>El numero validado o si no se pudo validar 0</returns>
        private double ValidarOperando(String strNumero)
        {
            double ret;
            if (!(Double.TryParse(strNumero, out ret)))
            {
                ret = 0;
            }
            return ret;
        }

        /// <summary>
        /// Valida que la cadena que aloja al dato, sea de tipo binario (solo 0s o 1s)
        /// </summary>
        /// <param name="binario"> cadena donde se aloja el binario </param>
        /// <returns> </returns>
        private bool EsBinario(String binario)
        {
            bool ret = true;

            foreach (char c in binario)
            {
                if (c != '0' && c != '1')
                {
                    ret = false;
                    break;
                }
            }
            return ret;
        }

        /// <summary>
        /// Convierte de ser posible, el string pasado por parametro a decimal
        /// </summary>
        /// <param name="binario"> Cadena que contiene el binario </param>
        /// <returns>String con resultado o leyenda de error</returns>
        public string BinarioDecimal(String binario)
        {
            StringBuilder str = new StringBuilder();
            double acum = 0;
            Int32 guia = 0;
            double num;

            if (this.EsBinario(binario))
            {
                for (int i = binario.Length - 1; i >= 0; i--)
                {
                    num = double.Parse(binario[i].ToString());
                    acum += num * Math.Pow(2, guia);
                    guia++;
                }
                str.Append($"{acum}");
            }
            else
            {
                str.Append("Valor Invalido");
            }

            return str.ToString();
        }

        /// <summary>
        /// Convierte de ser posible, el numero pasado por parametro a binario
        /// </summary>
        /// <param name="binario"> Numero double a convertir </param>
        /// <returns>String con resultado o leyenda de error</returns>
        public String DecimalBinario(double numero)
        {
            //int auxNum = (int)Math.Abs(numero); preguntar si hay que convertir a absoluto el num, o si mandan 
            String resultado = "";          //negativo o decimal le tiramos error...
            int guia;
            char[] auxArray;
            int auxNum;
            StringBuilder str = new StringBuilder();

            if (int.TryParse(numero.ToString(), out auxNum) && auxNum > -1)
            {
                guia = auxNum;
                do
                {
                    resultado += guia % 2;
                    guia = guia / 2;

                } while (guia > 0);

                auxArray = resultado.ToCharArray();
                Array.Reverse(auxArray);

                str.Append(new String(auxArray));
            }
            else
            {
                str.Append("Valor inválido");
            }

            return str.ToString();
        }

        /// <summary>
        /// Convierte de ser posible, el numero pasado por parametro en una cadena a binario
        /// </summary>
        /// <param name="binario"> String que contiene double a convertir </param>
        /// <returns>String con resultado o leyenda de error</returns>
        public String DecimalBinario(String strNumero)
        {
            double auxN;
            String ret = "";

            if (double.TryParse(strNumero, out auxN))
            {
                ret = this.DecimalBinario(auxN);
            }
            else
            {
                ret = "Valor inválido";
            }
            return ret;
        }

        //operators overload

        /// <summary>
        /// Sobrecarga del operador -, resta el numero del operador 1 con el del operador 2
        /// </summary>
        /// <param name="o1">operador 1</param>
        /// <param name="o2">operador 2</param>
        /// <returns>resultado double, de recibir operandos nullos, retorna 0</returns>
        public static double operator -(Operando o1, Operando o2)
        {
            double result = 0;
            if (o1 != null && o2 != null)
            {
                result = o1.numero - o2.numero;
            }
            return result;
        }

        /// <summary>
        /// Sobrecarga del operador +, suma el numero del operador 1 con el del operador 2
        /// </summary>
        /// <param name="o1">operador 1</param>
        /// <param name="o2">operador 2</param>
        /// <returns>resultado double, de recibir operandos nullos, retorna 0</returns>
        public static double operator +(Operando o1, Operando o2)
        {
            double result = 0;
            if (o1 != null && o2 != null)
            {
                result = o1.numero + o2.numero;
            }
            return result;
        }

        /// <summary>
        /// Sobrecarga del operador *, multiplica el numero del operador 1 con el del operador 2
        /// </summary>
        /// <param name="o1">operador 1</param>
        /// <param name="o2">operador 2</param>
        /// <returns>resultado double, de recibir operandos nullos, retorna 0</returns>
        public static double operator *(Operando o1, Operando o2)
        {
            double result = 0;
            if (o1 != null && o2 != null)
            {
                result = o1.numero * o2.numero;
            }
            return result;
        }

        /// <summary>
        /// Sobrecarga del operador /, divide el numero del operador 1 con el del operador 2, siempre
        /// y cuando sea distinto de cero
        /// </summary>
        /// <param name="o1">operador 1</param>
        /// <param name="o2">operador 2</param>
        /// <returns>resultado double, de recibir operandos nullos o el segundo operador sea 0 retorna el
        /// valor minimo de un double</returns>
        public static double operator /(Operando o1, Operando o2)
        {
            double result = double.MinValue;
            if (o1 != null && o2 != null && o2.numero != 0)
            {
                result = o1.numero / o2.numero;
            }
            return result;
        }
    }
}
