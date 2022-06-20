using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCloud_Entidades
{
    public class Premium : Cliente_BookCloud
    {
        private static Int32 cantidadLimite;
        private static Int32 porcentajeDescuento;

        static Premium()
        {
            Premium.cantidadLimite = 20;
            Premium.porcentajeDescuento = 15;
        }                                                    

        public Premium()
        {
        }

        public Premium(String dni, String nombre, String apellido, DateTime fecha, ENacionalidad nac, String mail, String numTelefono)
            : base(dni, nombre, apellido, fecha, nac, mail, numTelefono, Premium.cantidadLimite)
        { }

        /// <summary>
        /// Calcula el precio total del carrito, teniendo en cuenta el descuento de cliente Premium
        /// </summary>
        /// <returns></returns>
        protected override double FacturarCarrito()
        {
            return (base.FacturarCarrito() - (base.FacturarCarrito() * Premium.porcentajeDescuento) / 100);            
        }

        /// <summary>
        /// Muestra detalle completo del cliente e informa el porcentaje de descuento por cliente premium
        /// </summary>
        /// <returns></returns>
        public override string MostrarDetalle()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"{base.MostrarDetalle()}Descuento premium: {Premium.porcentajeDescuento}%");

            return str.ToString();
        }
    }
}
