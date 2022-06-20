using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCloud_Entidades 
{
    public class Venta : IComun
    {
        private DateTime fecha;
        private String clienteApellido;
        private String clienteNombre;
        private String dniCliente;
        private Double importeFacturado;

        public Venta() { }

        public Venta(DateTime fecha , String nombre, String apellido, String dni , Double importe)            
        {
            this.Fecha = fecha;
            this.NombreCliente = nombre;
            this.ApellidoCliente = apellido;
            this.DniCliente = dni;
            this.ImporteFinal = importe; 
        }

        public DateTime Fecha
        {
            get { return this.fecha; }
            set { this.fecha = value; }
        }

        public String NombreCliente
        {
            get { return this.clienteNombre; }
            set { this.clienteNombre = value; }
        }

        public String ApellidoCliente
        {
            get { return this.clienteApellido; }
            set { this.clienteApellido = value; }
        }

        public String DniCliente
        {
            get { return this.dniCliente; }
            set { this.dniCliente = value; }
        }

        public Double ImporteFinal
        {
            get { return this.importeFacturado; }
            set { this.importeFacturado = value; }
        }

        /// <summary>
        /// Genera string formato ticket con toda la informacion de la venta
        /// </summary>
        /// <returns></returns>
        public String MostrarDetalle()
        {
            StringBuilder str = new();

            str.AppendLine($"--Fecha: {this.Fecha.Date.ToShortDateString()}\n--Cliente: {this.NombreCliente} {this.ApellidoCliente}\n" +
                $"\n--DNI: {this.DniCliente}--Importe Facturado Final: ${Math.Round(this.ImporteFinal, 2)}");

            return str.ToString();
        }

        /// <summary>
        /// Retorna ticket de la venta, invocando al metodo MostrarDetalle()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {         
            return this.MostrarDetalle();
        }
    }
}
