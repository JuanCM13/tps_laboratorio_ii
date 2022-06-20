using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookCloud_Entidades;

namespace BookCloud_Vista
{
    public partial class Form_GeneradorDeVenta : Form , IComunes_Forms
    {
        private List<Venta> ventas;
        private Cliente_BookCloud cliente;
        private List<Publicacion> publicaciones;

        public Form_GeneradorDeVenta(Cliente_BookCloud cliente,List<Venta>ventas,List<Publicacion>publis)
        {
            InitializeComponent();
            this.ventas = ventas;
            this.cliente= cliente;
            this.publicaciones = publis;
        }

        /// <summary>
        /// Agrega publicaciones al listbox, agrega el nombre del cliente al lbl de nombreCliente del carrito e invoca al metodo setearDatos()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_GeneradorDeVenta_Load(object sender, EventArgs e)
        {
            //asigno manejador al evento de la clase Carrito
            Carrito<Publicacion>.LimiteAlcanzado_Event += this.DeshabilitarBoton_AgregarAlCarrito;

            foreach (Publicacion item in this.publicaciones)
            {
                this.Ltb_Productos_GestorVenta.Items.Add(item);
            }

            this.Lbl_NombreDeCliente_GestorVentas.Text = $"Carrito de: {this.cliente.Nombre}";
            this.Setear_Datos(); 
        }

        /// <summary>
        /// Setea datos al listado de productos del carrito del usuario
        /// </summary>
        public void Setear_Datos()
        {
            String aux = String.Empty;

            this.Rtb_CarritoCliente_GestorVentas.Text = String.Empty;
            foreach (Publicacion item in this.cliente.CarritoCompras.Productos)
            {
                aux += item.ToString();
            }

            this.Rtb_CarritoCliente_GestorVentas.Text = aux;
            this.Tbx_PrecioFinal_GestorVentas.Text = (Math.Round(this.cliente.PrecioTotalCarrito,2)).ToString();

            //para restaurar datos modificados por el evento que desabilita el boton
            this.Btn_AgregarProducto_GestorVentas.Enabled = true;
            this.Lbl_LugarCarrito.Text = "Aun queda lugar en el carrito!";
        }

        /// <summary>
        /// Muestra el detalle del producto clickeado en el rich textbox de detalle de productos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_MostrarDetalle(object sender, EventArgs e)
        {
            this.Rtb_DetalleProducto_GestorVenta.Text = ((Publicacion)(this.Ltb_Productos_GestorVenta.SelectedItem)).MostrarDetalle();
        }

        /// <summary>
        /// Agrega producto al carrito del usuario, solo si todavia hay lugar en el carrito, evalua caso regular o premium
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_AgregarProducto_GestorVentas_Click(object sender, EventArgs e)
        {
            Publicacion auxP;

            if (this.Ltb_Productos_GestorVenta.SelectedIndex != -1)
            {
                auxP = (Publicacion)(this.Ltb_Productos_GestorVenta.SelectedItem);

                try
                {
                    this.cliente.CarritoCompras.AgregarProducto(auxP);
                    this.Setear_Datos();
                }
                catch(Exception ex)
                {
                    /*llego al limite del carrito excepcion!*/
                    MessageBox.Show($"{ex.Message}", "Error!", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe elegir un producto primero!", "Seleccione", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Elimina un producto del carrito solo si existe en el..
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_EliminarProducto_GestorVentas_Click(object sender, EventArgs e)
        {
            Publicacion auxP;

            if (this.Ltb_Productos_GestorVenta.SelectedIndex != -1)
            {
                if(this.cliente.CarritoCompras.CantidadProductos > 0)
                {
                    auxP = (Publicacion)(this.Ltb_Productos_GestorVenta.SelectedItem);
                    if (this.cliente.CarritoCompras.EliminarProductos(auxP, 1))
                    {
                        this.Setear_Datos();
                        MessageBox.Show("Producto eliminado con exito!", "Borrado", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("El producto no se encontro en el carrito,corrobore!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }    
                else
                {
                    MessageBox.Show("Carrito vacio!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Debe elegir un producto primero!", "Seleccione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Vacia los productos del carrito del usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_VaciarCarrito_GeneradorVentas_Click(object sender, EventArgs e)
        {
            this.cliente.CarritoCompras.VaciarListado_Productos();
            this.Setear_Datos();
        }

        /// <summary>
        /// Cancela la compra y cierra el formulario de aceptar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_CancelarCompra_GestorVentas_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Seguro que desea cancelar la venta, se perdera el carrito..?", "Confirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Btn_VaciarCarrito_GeneradorVentas_Click(sender, e);
                this.Close();
            }
        }

        /// <summary>
        /// Genera venta y la agrega al listado de ventas, solo si el carrito tiene al menos 1 elemento cargado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Comprar_GestorVentas_Click(object sender, EventArgs e)
        {
            String ticket = String.Empty;            

            if(this.cliente.CarritoCompras.CantidadProductos > 0)
            {
                this.ventas.Add(new Venta(DateTime.Now,this.cliente.Nombre,this.cliente.Apellido,this.cliente.Dni,this.cliente.PrecioTotalCarrito));

                this.Btn_VaciarCarrito_GeneradorVentas_Click(sender, e);                
                MessageBox.Show("Venta concretada! Recibo archivado!", "Confirmado", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("Carrito vacio!\nIngrese al menos un producto para realizar la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeshabilitarBoton_AgregarAlCarrito(String mensajeNoLugar)
        {
            this.Btn_AgregarProducto_GestorVentas.Enabled = false; 
            if( !String.IsNullOrWhiteSpace(mensajeNoLugar))
            {
                this.Lbl_LugarCarrito.Text = mensajeNoLugar;
            }
        }
    }
}
