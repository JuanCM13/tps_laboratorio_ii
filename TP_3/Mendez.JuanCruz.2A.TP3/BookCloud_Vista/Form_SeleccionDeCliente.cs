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
    public partial class Form_SeleccionDeCliente : Form , IComunes_Forms
    {
        List<Venta> ventas;
        List<Cliente_BookCloud> clientes;
        List<Publicacion> publicaciones;

        public Form_SeleccionDeCliente(List<Cliente_BookCloud> clientes, List<Venta> ventas,List<Publicacion>publis)
        {
            InitializeComponent();
            this.ventas = ventas;
            this.clientes = clientes;
            this.publicaciones = publis;
        }

        private void Form_SeleccionDeCliente_Load(object sender, EventArgs e)
        {
            this.Setear_Datos();
        }

        /// <summary>
        /// Setea informacion por default
        /// </summary>
        public void Setear_Datos()
        {
            if (!(this.ventas is null) && !(this.clientes is null))
            {
                this.Lbt_Premium_SeleccionClientes.Items.Clear();
                this.Lbt_Regular_SeleccionClientes.Items.Clear();
                foreach (Cliente_BookCloud item in this.clientes)
                {
                    if (item is Premium)
                    {
                        this.Lbt_Premium_SeleccionClientes.Items.Add(item);
                    }
                    else
                    {
                        this.Lbt_Regular_SeleccionClientes.Items.Add(item);
                    }
                }
            }
        }


        /// <summary>
        /// Evita que puedan elegirse elementos del listado premium si se eligio alguno de los regulares
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lbt_Regular_SeleccionClientes_Click(object sender, EventArgs e)
        {
            this.Lbt_Premium_SeleccionClientes.Enabled = false;
        }

        /// <summary>
        /// Evita que puedan elegirse elementos del listado regulares si se eligio alguno de los premium
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lbt_Premium_SeleccionClientes_Click(object sender, EventArgs e)
        {
            this.Lbt_Regular_SeleccionClientes.Enabled = false;
        }

        /// <summary>
        /// Descliquea y habilita seleccion de ambos listbox premium y regulares
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Reset_SeleccionCliente_Click(object sender, EventArgs e)
        {
            this.Lbt_Regular_SeleccionClientes.SelectedIndex = -1;
            this.Lbt_Regular_SeleccionClientes.Enabled = true;
            this.Lbt_Premium_SeleccionClientes.SelectedIndex = -1;
            this.Lbt_Premium_SeleccionClientes.Enabled = true;
        }

        /// <summary>
        /// Instancia formulario de AltaCliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Click_AgregarCliente(object sender, EventArgs e)
        {
            FormAltaCliente altaCliente = new FormAltaCliente(clientes);
            this.Hide();
            altaCliente.ShowDialog();
            this.Setear_Datos();
            this.Show();
        }

        /// <summary>
        /// Habilita formulario de Generado Venta solo si hay algun elemento seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Click_Seleccionar(object sender, EventArgs e)
        {
            Cliente_BookCloud auxPrem = default;
            bool sePuede = true;

            if (this.Lbt_Premium_SeleccionClientes.SelectedIndex != -1)
            {
                auxPrem = ((Cliente_BookCloud)this.Lbt_Premium_SeleccionClientes.SelectedItem);                
            }
            else
            {
                if(this.Lbt_Regular_SeleccionClientes.SelectedIndex != -1)
                {
                    auxPrem = ((Cliente_BookCloud)this.Lbt_Regular_SeleccionClientes.SelectedItem);
                }     
                else
                {
                    sePuede = false;
                    MessageBox.Show("Debe elegir algun cliente para generar el pedido!", "Seleccione un cliente", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }

            if(sePuede)
            {
                Form_GeneradorDeVenta generadorVenta = new Form_GeneradorDeVenta(auxPrem, this.ventas, this.publicaciones);
                this.Hide();
                generadorVenta.ShowDialog();
                this.Show();
            }            
        }
    }
}
