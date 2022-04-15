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
        /// Convierte valor binario a decimal siempre y cuando el string pasado por parametro este compuestos por 1 o 0s
        /// </summary>
        /// <param name="binario">String que almacena la cadena de 1 y 0s</param>
        /// <returns> String con resultado de la conversion, de no ser posible transformarlo, leyenda de error </returns>
        public String BinarioDecimal(String binario)
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
                str.Append("Valor inválido");
            }

            return str.ToString();
        }

        /// <summary>
        /// Convierte valor decimal a binario siempre que sea mayor a -1 y que sea entero. 
        /// </summary>
        /// <param name="numero"> valor a convertir </param>
        /// <returns> String con el binario, sino leyenda de error </returns>
        public String DecimalBinario(double numero)
        {
            String resultado = "";
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
        /// Convierte el valor pasado por string a binario, siempre y cuando el string pueda convertirse a double
        /// </summary>
        /// <param name="strNumero">String que almacena el valor a convertir</param>
        /// <returns>El valor en binario en string, sino string con leyenda de error</returns>
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
        /// Resta el operando1 por el operando2 siempre y cuando ambos no sean null
        /// </summary>
        /// <param name="o1">Operando1</param>
        /// <param name="o2">Operando2</param>
        /// <returns>Devuelve el resultado de ser posible la cuenta, sinopor default 0</returns>
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
        /// Suma el operando1 por el operando2 siempre y cuando ambos no sean null
        /// </summary>
        /// <param name="o1">Operando1</param>
        /// <param name="o2">Operando2</param>
        /// <returns>Devuelve el resultado de ser posible la cuenta, sinopor default 0</returns>
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
        /// Multiplica el operando1 por el operando2 siempre y cuando ambos no sean null
        /// </summary>
        /// <param name="o1">Operando1</param>
        /// <param name="o2">Operando2</param>
        /// <returns>Devuelve el resultado de ser posible la cuenta, sinopor default 0</returns>
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
        /// Divide el operando1 por el operando2 siempre y cuando ambos no sean null y el operando2 sea distinto de 0
        /// </summary>
        /// <param name="o1">Operando1</param>
        /// <param name="o2">Operando2</param>
        /// <returns>Devuelve el resultado de ser posible la cuenta, sino el valor minimo de un double</returns>
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
