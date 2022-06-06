using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCloud_Entidades
{
    public class Cuento : Publicacion
    {
        private ECuentos tipoCuento;
        
        public Cuento()
        {}

        public Cuento(Int32 codigo, String titulo, String autor, Int32 numEdicion, Double precio, bool descuento, Int32 cantPag, ECuentos tipo)
            : base(codigo,titulo,autor,numEdicion,precio,descuento, cantPag)
        {
            this.TipoCuento = tipo;
        }

        public ECuentos TipoCuento
        {
            get { return this.tipoCuento; }
            set { this.tipoCuento = value; }
        }

        /// <summary>
        /// Por defailt si el cuento llega a tener descuento, sera del 16%
        /// </summary>
        protected override double Descuento
        {
            get { return 16; } 
        }

        public static bool operator ==(Cuento c1 , Cuento c2)
        {
            bool ret = false;
            if(!(c1 is null) && !(c2 is null))
            {
                if(c1 == ((Publicacion)c2) && c1.TipoCuento == c2.TipoCuento)
                {
                    ret = true;
                }                
            }
            return ret;
        }

        public static bool operator !=(Cuento c1, Cuento c2)
        {
            return !(c1 == c2);
        }

        public override bool Equals(object obj)
        {
            bool ret = false;
            if(obj is Cuento)
            {
                ret = this == ((Cuento)obj);
            }
            return ret;
        }

        /// <summary>
        /// Devuelve informacion de la publicacion sumando el genero de el cuento..
        /// </summary>
        /// <returns></returns>
        public override string MostrarDetalle()
        {
            StringBuilder str = new();

            str.AppendLine($"{base.MostrarDetalle()}Tipo de Cuento: {Enum.GetName(typeof(ECuentos), this.TipoCuento)}");            
            return base.MostrarDetalle();
        }
    }
}
