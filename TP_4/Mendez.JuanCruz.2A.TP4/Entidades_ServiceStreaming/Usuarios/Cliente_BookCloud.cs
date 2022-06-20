using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BookCloud_Entidades
{
    [XmlInclude(typeof(Regular))]
    [XmlInclude(typeof(Premium))]
    public abstract class Cliente_BookCloud : Usuario
    {
        private Carrito<Publicacion> carrito;
        private String mailContacto;
        private String numTelefono;

        public Cliente_BookCloud()
        {}

        public Cliente_BookCloud(String dni, String nombre, String apellido, DateTime fecha, ENacionalidad nac, String mail, String numero, Int32 limite)
            : base(dni, nombre, apellido, fecha, nac)
        {
            this.CarritoCompras = new(limite);
            this.MailContacto = mail;
            this.NumTelefono = numero;
        }

        public String NumTelefono
        {
            get { return this.numTelefono; }
            set
            {
                if (Validadores.Validar_SonNumeros(value))
                {
                    this.numTelefono = value; 
                }
                else
                {
                    throw new FormatException("Error, el telefono solo puede estar compuesto por numeros..");
                }
            }
        }
 
        public String MailContacto
        {
            get { return this.mailContacto; }
            set { this.mailContacto = value;  }
        }

        public Carrito<Publicacion> CarritoCompras
        {
            get { return this.carrito; }
            set 
            {
                this.carrito = new Carrito<Publicacion>(value.LimiteCompras);
            }
        }

        public Double PrecioTotalCarrito
        {
            get { return this.FacturarCarrito(); }
        }

        /// <summary>
        /// Metodo encargado de generar de calcular precio total del carrito
        /// </summary>
        /// <returns></returns>
        protected virtual Double FacturarCarrito()
        {
            Double ret = 0;
            if(this.carrito.CantidadProductos > 0)
            {
                foreach(Publicacion item in this.carrito.Productos)
                {
                    ret += item.Precio;
                }
            }
            return Math.Round(ret,2);
        }

        /// <summary>
        /// Retorna string con toda la informacion del cliente y su listado de productos
        /// </summary>
        /// <returns></returns>
        public override string MostrarDetalle()
        {
            StringBuilder str = new();

            str.AppendLine($"{base.MostrarDetalle()}Mail Contacto: {this.MailContacto}\nNumero Contacto: {this.NumTelefono}");
            str.AppendLine("Listado Publicaciones:\n");

            if(this.carrito.Productos.Count > 0)
            {
                foreach(Publicacion item in this.carrito.Productos)
                {
                    str.AppendLine(item.ToString() + "\n");
                }
            }
            else
            {
                str.AppendLine("Sin Libros al momento!");
            }

            return str.ToString();
        }

        public static bool operator ==(Cliente_BookCloud c1 , Cliente_BookCloud c2)
        {
            bool ret = false;
            if(!(c1 is null) && !(c2 is null))
            {
                if(c1.Dni == c2.Dni && c1.Nacionalidad == c2.Nacionalidad)
                {
                    ret = true;
                }
            }
            return ret;
        }

        public static bool operator !=(Cliente_BookCloud c1, Cliente_BookCloud c2)
        {
            return !(c1 == c2);
        }

        public override bool Equals(object obj)
        {
            bool ret = false;
            if(obj is Cliente_BookCloud)
            {
                ret = this == ((Cliente_BookCloud)obj);
            }
            return ret;
        }

        /// <summary>
        /// Retorna el tipo de cliente,nombre apellido y dni del cliente en formato de string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder str = new();

            str.AppendLine($"Tipo Cliente: {this.GetType().Name}\n{this.Nombre}, {this.Apellido} Dni: {this.Dni}");

            return str.ToString();
        }
    }
}
