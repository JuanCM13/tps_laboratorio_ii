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
    public partial class FormAltaCliente : Form , IComunes_Forms
    {
        public List<Cliente_BookCloud> listadoClientes;

        public FormAltaCliente(List<Cliente_BookCloud> clientes)
        {
            InitializeComponent();
            this.listadoClientes = clientes;
        }

        /// <summary>
        /// Carga informacion a combobox e invoca a setearDatos()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormAltaCliente_Load(object sender, EventArgs e)
        {
            this.cmb_Nacionalidad_AltaCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmb_Nacionalidad_AltaCliente.DataSource = Enum.GetValues(typeof(ENacionalidad));
            this.cmb_Nacionalidad_AltaCliente.SelectedIndex = 0; //por default es argentino

            this.cmb_TipoCliente_AltaCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmb_TipoCliente_AltaCliente.Items.Add("Premium");
            this.cmb_TipoCliente_AltaCliente.Items.Add("Regular");
            this.cmb_TipoCliente_AltaCliente.SelectedIndex = 0;
            this.Setear_Datos();
        }

        /// <summary>
        /// Actualiza datos default
        /// </summary>
        public void Setear_Datos()
        {
            foreach (Control item in this.Controls)
            {
                if(item is TextBox)
                {
                    TextBox aux = (TextBox)item;
                    aux.Text = String.Empty;
                }
            }
        }

        /// <summary>
        /// Gestiona el alta de cliente, valida que este no se encuentre ya cargado y gestiona campos erroneos y sus excepciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            bool sePuede = true;


            foreach(Control item in this.Controls)
            {
                if(item is TextBox)
                {
                    TextBox aux = (TextBox)item;
                    if(String.IsNullOrWhiteSpace(aux.Text))
                    {
                        sePuede = false;
                        break;
                    }
                }
            }

            if(sePuede)
            {
                String tipoCliente = this.cmb_TipoCliente_AltaCliente.GetItemText(this.cmb_TipoCliente_AltaCliente.SelectedItem);
                String nombre = this.tbx_Nombre_AltaCliente.Text;
                String dni = this.tbx_Dni_AltaCliente.Text;
                String apellido = this.tbx_Apellido_AltaCliente.Text;
                DateTime fecha = this.dateTimePicker_AltaCliente.Value;
                ENacionalidad nacionalidad = (ENacionalidad)Enum.Parse(typeof(ENacionalidad) , ((this.cmb_Nacionalidad_AltaCliente).SelectedValue).ToString());
                String mail = this.tbx_Email_AltaCliente.Text;
                String telefono = this.tbx_Telefono_AltaCliente.Text;


                try
                {
                    if (tipoCliente == "Premium")
                    {
                        Premium auxPrem = new Premium(dni, nombre, apellido, fecha, nacionalidad, mail, telefono);
                        
                        if ( !this.listadoClientes.Contains(auxPrem))
                        {
                            this.listadoClientes.Add(auxPrem);
                        }   
                        else
                        {
                            throw new ClienteExistenteException("Error, el cliente ya se encuentra cargado en el listado!");
                        }
                    }
                    else
                    {
                        Regular auxReg = new Regular(dni, nombre, apellido, fecha, nacionalidad, mail, telefono);

                        if (!this.listadoClientes.Contains(auxReg))
                        {
                            this.listadoClientes.Add(auxReg);
                        }
                        else
                        {
                            throw new ClienteExistenteException("Error, el cliente ya se encuentra cargado en el listado!");
                        }
                    }

                    MessageBox.Show($"Cliente: {nombre} {apellido}, cargado con exito", "Exito", MessageBoxButtons.OK);
                    this.Setear_Datos();
                    this.Close();
                }  
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Asegurese de completar todos los campos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Click_Cancelar(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
