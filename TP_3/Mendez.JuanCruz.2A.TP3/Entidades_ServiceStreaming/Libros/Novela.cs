using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCloud_Entidades
{
    public class Novela : Publicacion
    {
        private ENovela tipoNovela;

        public Novela()
        {}

        public Novela(Int32 codigo, String titulo, String autor, Int32 numEdicion, Double precio, bool descuento, Int32 cantPag , ENovela tipo)
            : base(codigo, titulo, autor, numEdicion, precio, descuento , cantPag)
        {
            this.TipoNovela = tipo;
        }

        public ENovela TipoNovela
        {
            get { return this.tipoNovela; }
            set { this.tipoNovela = value; }
        }

        /// <summary>
        /// Por defailt si la novela llega a tener descuento, sera del 5%
        /// </summary>
        protected override double Descuento
        {
            get { return 5; }  
        }

        public static bool operator ==(Novela n1 , Novela n2)
        {
            bool ret = false;
            if(!(n1 is null) && !(n2 is null))
            {
                if(n1 == ((Publicacion)n2) && n1.TipoNovela == n2.TipoNovela)
                {
                    ret = true;
                }
            }
            return ret;
        }

        public static bool operator !=(Novela n1, Novela n2)
        {
            return !(n1 == n2);
        }

        public override bool Equals(object obj)
        {
            bool ret = false;
            if(obj is Novela)
            {
                ret = this == ((Novela)obj);
            }
            return ret;
        }

        /// <summary>
        /// Devuelve informacion de la publicacion sumando el genero de la novela..
        /// </summary>
        /// <returns></returns>
        public override string MostrarDetalle()
        {
            StringBuilder str = new();

            str.AppendLine($"{base.MostrarDetalle()}Genero de Novela: {Enum.GetName(typeof(ENovela), this.TipoNovela)}");
            return base.MostrarDetalle();
        }
    }
}
