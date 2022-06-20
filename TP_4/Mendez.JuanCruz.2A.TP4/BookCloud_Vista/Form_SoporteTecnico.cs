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
    public partial class Form_SoporteTecnico : Form
    {
        public Form_SoporteTecnico()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sobreescribe el archivo Reclamos_File.txt, con la ultima consulta o reclamo generado, la idea es en un futuro simular un envio de mail o informacion
        /// a los encargados del mantenimiento del sitio, con la informacion de este mensaje, tambien carga dicho mensaje
        /// a una base de datos de reclamos pendientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_EnviarConsulta_Click(object sender, EventArgs e)
        {
            String data = this.Rtb_Consulta.Text;
            String aGuardar = String.Empty;

            if ( !String.IsNullOrWhiteSpace(data))
            {
                aGuardar += DateTime.Now.ToString() + " " + data;

                try
                {

                    GestionReclamos_Sql.ProbarConexion();
                    GestionReclamos_Sql.Agregar_Reclamo(aGuardar);
                    GestionArchivos_Txt.Grabar(aGuardar);
                    MessageBox.Show("Su consulta sera tomada en cuenta, nuestro equipo se pondra en contacto a la brevedad!", "Genial!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Ingrese la consulta para que lo podamos ayudar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
