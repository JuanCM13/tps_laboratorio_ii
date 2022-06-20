using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCloud_Entidades
{
    public class Historieta : Publicacion
    {
        private EHistorietas tipoHistorieta;

        public Historieta()
        {}

        public Historieta(Int32 codigo, String titulo, String autor, Int32 numEdicion, Double precio, bool descuento, Int32 cantPag, EHistorietas tipo)
            : base(codigo, titulo, autor, numEdicion, precio, descuento, cantPag)
        {
            this.TipoHistorieta = tipo;
        }

        public EHistorietas TipoHistorieta
        {
            get { return this.tipoHistorieta; }
            set { this.tipoHistorieta = value; }
        }

        /// <summary>
        /// Por defailt si la historieta llega a tener descuento, sera del 30%
        /// </summary>
        protected override double Descuento
        {
            get { return 30; } 
        }

        public static bool operator ==(Historieta h1 , Historieta h2)
        {
            bool ret = false;
            if(!(h1 is null) && !(h2 is null))
            {
                if(h1 == ((Publicacion)h2) && h1.TipoHistorieta == h2.TipoHistorieta)
                {
                    ret = true;
                }
            }
            return ret;
        }

        public static bool operator !=(Historieta h1, Historieta h2)
        {
            return !(h1 == h2);
        }

        public override bool Equals(object obj)
        {
            bool ret = false;
            if(obj is Historieta)
            {
                ret = this == ((Historieta)obj);
            }
            return ret;
        }

        /// <summary>
        /// Devuelve informacion de la publicacion sumando el genero de la historieta..
        /// </summary>
        /// <returns></returns>
        public override string MostrarDetalle()
        {
            StringBuilder str = new();

            str.AppendLine($"{base.MostrarDetalle()}Tipo de Historieta: {Enum.GetName(typeof(EHistorietas), this.TipoHistorieta)}");
            return base.MostrarDetalle();
        }
    }
}
