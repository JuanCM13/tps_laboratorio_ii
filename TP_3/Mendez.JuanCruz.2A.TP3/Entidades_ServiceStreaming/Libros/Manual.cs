using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCloud_Entidades
{
    public class Manual : Publicacion
    {
        private EManual tipoManual;

        public Manual()
        {}

        public Manual(Int32 codigo, String titulo, String autor, Int32 numEdicion, Double precio, bool descuento, Int32 cantPag, EManual tipo)
            : base(codigo, titulo, autor, numEdicion, precio, descuento , cantPag)
        {
            this.TipoManual = tipo;
        }

        public EManual TipoManual
        {
            get { return this.tipoManual; }
            set { this.tipoManual = value; }
        }

        /// <summary>
        /// Por defailt si el manual llega a tener descuento, sera del 10%
        /// </summary>
        protected override double Descuento
        {
            get { return 10; } 
        }

        public static bool operator ==(Manual m1 , Manual m2)
        {
            bool ret = false;
            if(!(m1 is null) && !(m2 is null))
            {
                if(m1 == ((Publicacion)m2) && m1.TipoManual == m2.TipoManual)
                {
                    ret = true;
                }
            }
            return ret;
        }

        public static bool operator !=(Manual m1, Manual m2)
        {
            return !(m1 == m2);
        }

        public override bool Equals(object obj)
        {
            bool ret = false;
            if(obj is Manual)
            {
                ret = this == ((Manual)obj);
            }
            return ret;
        }

        /// <summary>
        /// Devuelve informacion de la publicacion sumando el genero de el manual..
        /// </summary>
        /// <returns></returns>
        public override string MostrarDetalle()
        {
            StringBuilder str = new();

            str.AppendLine($"{base.MostrarDetalle()}Tipo de Manual: {Enum.GetName(typeof(EManual), this.TipoManual)}");
            return base.MostrarDetalle();
        }
    }
}
