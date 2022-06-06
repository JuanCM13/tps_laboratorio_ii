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
    public partial class Form_GestionClientes : Form , IComunes_Forms
    {
        List<Cliente_BookCloud> clientes;

        public Form_GestionClientes(List<Cliente_BookCloud> listadoClientes)
        {
            InitializeComponent();
            this.clientes = listadoClientes;
        }

        /// <summary>
        /// Setea datos por default
        /// </summary>
        public void Setear_Datos()
        {
            if (!(this.clientes is null))
            {
                this.listBox_GestionClientes.Items.Clear();
                foreach (Cliente_BookCloud item in this.clientes)
                {
                    this.listBox_GestionClientes.Items.Add(item);
                }
            }
        }

        private void Form_GestionClientes_Load(object sender, EventArgs e)
        {
            this.Setear_Datos();   
        }

        /// <summary>
        /// Elimina cliente del listado de clientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_DarClienteBaja_GestorClientes_Click(object sender, EventArgs e)
        {       
            if(!(this.listBox_GestionClientes.SelectedItem is null))
            {
                this.clientes.Remove(((Cliente_BookCloud)this.listBox_GestionClientes.SelectedItem));                
                this.Setear_Datos();
                MessageBox.Show("Cliente eliminado con exito!","Exito",MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para ser removido!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        /// <summary>
        /// Instancia formulario de alta de cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_DarClienteAlta_GestorClientes_Click(object sender, EventArgs e)
        {
            FormAltaCliente formAlta = new FormAltaCliente(this.clientes);
            this.Hide();
            formAlta.ShowDialog();
            this.Setear_Datos();
            this.Show();
        }

        /// <summary>
        /// Muestra el detalle completo del cliente al clickear sobre el..
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_MostrarDatos(object sender, EventArgs e)
        {
            if((this.listBox_GestionClientes.SelectedIndex != -1))
            {
                this.Rtb_InfoCliente_GestionClientes.Text = ((Cliente_BookCloud)(this.listBox_GestionClientes.SelectedItem)).MostrarDetalle();
            }
        }
    }
}
