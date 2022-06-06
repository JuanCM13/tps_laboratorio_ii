using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCloud_Entidades
{
    public class Carrito<T> : IComun
    {
        private List<T> listadoProductos;
        private Int32 limiteCompras;

        public Carrito()
        {}

        /// <summary>
        /// Si el limite de compras es -1, la lista no tendria limite, seria ilimitada
        /// </summary>
        /// <param name="limiteCompras"></param>
        public Carrito(Int32 limiteCompras)
        {
            this.listadoProductos = new List<T>();
            this.LimiteCompras = limiteCompras;
        }

        public Int32 CantidadProductos
        {
            get { return this.listadoProductos.Count; }
        }

        public List<T> Productos
        {
            get { return this.listadoProductos; }
        }

        public Int32 LimiteCompras
        {
            get { return this.limiteCompras; }
            set 
            {
                if(value > 0)
                {
                    this.limiteCompras = value;
                }
            }
        }

        /// <summary>
        /// Metodo encargado de agregar un producto de tipo generico, a la lista generica de carrito, verifica si hay lugar en el listado, si hay agrega
        /// de lo contrario, lanza excepcion de tipo SinLugar
        /// </summary>
        /// <param name="producto">Elemento a agregar</param>
        /// <returns>true si lo cargo, excepcion de lo contrario</returns>
        public bool AgregarProducto(T producto)
        {
            bool ret = false;
            if(!(producto is null))
            {
                /*Si se inicializa el atributo con -1, se la hace ilimitada...*/
                if(this.limiteCompras == -1 || this.listadoProductos.Count < this.limiteCompras)
                {
                    ret = true;
                    this.listadoProductos.Add(producto);
                }                
                else
                {
                    throw new SinLugarException("Ha alcanzado el limite del carrito!");
                }
            }
            return ret;
        }

        /// <summary>
        /// Metodo encargado de eliminar el producto generico recibido por parametro, en la lista generica de carrito, el segundo parametro indica
        /// la cantidad de elementos de ese tipo a eliminar, 1 indica solo la primera ocurrencia del objeto y 2 elimina todas las ocurrencias del objeto
        /// en el listado
        /// </summary>
        /// <param name="producto">Elemento a eliminar</param>
        /// <param name="cantVeces">Cantidad de elementos a eliminar</param>
        /// <returns></returns>
        public bool EliminarProductos(T producto , Int32 cantVeces)
        {
            bool ret = false;
            Int32 guia;

            if(!(producto is null) && cantVeces > 0 && cantVeces < 3)
            {
                guia = 0;
                for(Int32 i=0; i<this.listadoProductos.Count; i++)
                {
                    if(this.listadoProductos[i].Equals(producto))
                    {
                        this.listadoProductos.Remove(producto);
                        guia++;
                        ret = true;
                    }

                    if(cantVeces == 1 && guia == 1)
                    {
                        break;
                    }
                }
            }
            return ret;
        }

        /// <summary>
        /// Metodo encargado de vaciar el listado de elementos, de la lista generica de elementos
        /// </summary>
        public void VaciarListado_Productos()
        {
            this.listadoProductos.Clear();
        }

        /// <summary>
        /// Agrega el elemento pasado por parametro a la lista pasada por parametro
        /// </summary>
        /// <param name="carrito">Objeto generico de tipo carrito</param>
        /// <param name="producto">Elemento a agregar</param>
        /// <returns></returns>
        public static bool operator +(Carrito<T> carrito , T producto)
        {
            bool ret = false;
            if(!(carrito is null) && !(producto is null))
            {
                ret = carrito.AgregarProducto(producto);
            }
            return ret;
        }

        /// <summary>
        /// Elimina el elemento pasado por parametro de la lista generica recibida por parametro
        /// </summary>
        /// <param name="carrito">Objeto generico de tipo carrito</param>
        /// <param name="producto">Elemento a eliminar</param>
        /// <returns></returns>
        public static bool operator -(Carrito<T> carrito, T producto)
        {
            bool ret = false;
            if (!(carrito is null) && !(producto is null))
            {
                ret = carrito.EliminarProductos(producto , 1);                
            }
            return ret;
        }

        /// <summary>
        /// Genera detalle completo del carrito, indicando el tipo de elemento (nombre de la clase de productos que contiene), cantidad de elementos,
        /// Genera el detalle de elementos cargados en la lista, invocando al metodo ToString de estos elementos
        /// </summary>
        /// <returns></returns>
        public String MostrarDetalle()
        {
            StringBuilder str = new();
            T aux = this.listadoProductos.FirstOrDefault();

            str.AppendLine($"Cantidad de Productos en el carrito: {this.CantidadProductos}");
            str.AppendLine($"Listado de {aux.GetType().Name}s:");

            if (this.CantidadProductos > 0)
            {
                foreach (T item in this.listadoProductos)
                {
                    str.AppendLine(item.ToString());
                }
            }
            else
            {
                str.AppendLine("Sin productos al momento!!");
            }

            return str.ToString();
        }

        /// <summary>
        /// Retorna la informacion completa del carrito, invocando al metodo MostrarDetalle
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarDetalle();
        }
    }
}
