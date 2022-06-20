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
        /// Setea datos por default, si la lista todavia no fue cargada, deshabilita los botones de alta y baja
        /// e indica al usuario que salga y reingrese en pocos segundos, asi mientras tanto puede recorrer otras opciones
        /// del menu principal, luego al volver a entrar si la lista ya fue cargada desde el archivo, reanuda las operaciones
        /// de carga y baja de usuarios
        /// </summary>
        public void Setear_Datos()
        {
            if (!(this.clientes is null))
            {
                this.listBox_GestionClientes.Items.Clear();
                this.Button_DarClienteBaja_GestorClientes.Enabled = true;
                this.Button_DarClienteAlta_GestorClientes.Enabled = true;
                foreach (Cliente_BookCloud item in this.clientes)
                {
                    this.listBox_GestionClientes.Items.Add(item);
                }
            }
            else
            {
                this.Button_DarClienteBaja_GestorClientes.Enabled = false;
                this.Button_DarClienteAlta_GestorClientes.Enabled = false;
                this.listBox_GestionClientes.Items.Add("Cargando listado de Clientes, vuelva al menu principal y reingrese en unos segundos!");
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
                if(this.listBox_GestionClientes.SelectedItem is Cliente_BookCloud)
                {
                    this.Rtb_InfoCliente_GestionClientes.Text = ((Cliente_BookCloud)(this.listBox_GestionClientes.SelectedItem)).MostrarDetalle();
                }                
            }
        }
    }
}
