using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BookCloud_Entidades
{
    [XmlInclude(typeof(Cuento))]
    [XmlInclude(typeof(Historieta))]
    [XmlInclude(typeof(Manual))]
    [XmlInclude(typeof(Novela))]

    public abstract class Publicacion : IComun
    {
        protected Int32 codigoIdentificador;
        protected String titulo;
        protected String autor;
        protected Int32 numeroEdicion;
        protected Int32 cantPaginas;
        protected Double precio; 
        protected bool tieneDescuento;

        public Publicacion()
        { }

        public Publicacion(Int32 codigo , String titulo , String autor , Int32 numEdicion , Double precio , bool descuento , Int32 cantPag)
        {
            this.CodigoIdentificador = codigo;
            this.Titulo = titulo;
            this.Autor = autor;
            this.Edicion = numEdicion;
            this.Precio = precio;
            this.TieneDescuento = descuento;
            this.CantPaginas = cantPag;
        }

        public Int32 CodigoIdentificador
        {
            get { return this.codigoIdentificador; }
            set { this.codigoIdentificador = value; }
        }

        public String Titulo
        {
            get { return this.titulo; }
            set { this.titulo = value; }
        }

        public String Autor
        {
            get { return this.autor; }
            set { this.autor = value; }
        }

        public Int32 Edicion
        {
            get { return this.numeroEdicion; }
            set { this.numeroEdicion = value; }
        }

        public Int32 CantPaginas 
        { 
            get { return this.cantPaginas; }
            set { this.cantPaginas = value; }
        }

        public Double Precio
        {
            get { return this.CalcularPrecio(this.precio); }
            set { this.precio = value; }
        }

        public bool TieneDescuento
        {
            get { return this.tieneDescuento; }
            set { this.tieneDescuento = value; }
        }

        protected abstract Double Descuento { get; } 

        /// <summary>
        /// Calcula el precio del producto si tiene o no descuento..
        /// </summary>
        /// <param name="precioSinDescuento"></param>
        /// <returns></returns>
        protected Double CalcularPrecio(Double precioSinDescuento)
        {
            Double ret = precioSinDescuento;

            if (this.TieneDescuento)
            {
                ret = ret - ((ret * this.Descuento) / 100);
            }

            return Math.Round(ret,2);
        }

        /// <summary>
        /// Muestra detalle completo de la publicacion
        /// </summary>
        /// <returns></returns>
        public virtual String MostrarDetalle()
        {
            StringBuilder str = new();

            String aux = this.TieneDescuento ? "Tiene Descuento" : "No Tiene Descuento"; 

            str.AppendLine($"Tipo: {this.GetType().Name}\nCodigo: {this.CodigoIdentificador}\nTitulo: {this.Titulo}\nAutor: {this.Autor}\nCantidad Paginas: {this.CantPaginas}\n" +
                $"Numero de Edicion: {this.Edicion}\nPrecio: ${this.Precio}\n{aux}");

            /*\nCantidad Paginas: {this.CantPaginas} --- Tipo de Tapa: {Enum.GetName(typeof(ETipoTapa) , this.TipoTapa)}*/

            return str.ToString();
        }

        public static bool operator ==(Publicacion p1, Publicacion p2)
        {
            bool ret = false;
            if(!(p1 is null) && !(p2 is null))
            {
                if(p1.Autor == p2.Autor && p1.Titulo == p2.Titulo && p1.Edicion == p2.Edicion)
                {
                    ret = true;
                }
            }
            return ret;
        }

        public static bool operator !=(Publicacion p1, Publicacion p2)
        {
            return !(p1 == p2);
        }
     
        /// <summary>
        /// Retorna tipo de publicacion, titulo y nombre del autor..
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder str = new();

            return str.AppendLine($"Tipo: {this.GetType().Name} -- {this.Titulo} , del autor {this.Autor}").ToString();
        }
    }
}
