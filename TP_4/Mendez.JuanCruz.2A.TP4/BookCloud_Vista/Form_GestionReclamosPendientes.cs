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
    public partial class Form_GestionReclamosPendientes : Form , IComunes_Forms
    {
        public Form_GestionReclamosPendientes()
        {
            InitializeComponent();
        }

        private void Form_GestionReclamosPendientes_Load(object sender, EventArgs e)
        {
            this.Setear_Datos();
        }

        public void Setear_Datos()
        {
            this.Lst_Reclamos.Items.Clear();
            try
            {
                GestionReclamos_Sql.ProbarConexion();
                foreach(KeyValuePair<Int32 , String> item in GestionReclamos_Sql.Leer_Reclamos())
                {
                   this.Lst_Reclamos.Items.Add(item);
                }                
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}" , "Error" , MessageBoxButtons.OK);
            }            
        }

        private void Btn_SolucionarReclamo_Click(object sender, EventArgs e)
        {
            if(this.Lst_Reclamos.SelectedIndex > -1)
            {
                try
                {
                    KeyValuePair<Int32, String> elemento = (KeyValuePair<Int32, String>)this.Lst_Reclamos.SelectedItem;
                    
                    if(GestionReclamos_Sql.Liberar_Reclamo(elemento.Key))
                    {
                        this.Setear_Datos();
                        MessageBox.Show("Se removio el reclamo de la lista de pendientes!", "Exito", MessageBoxButtons.OK);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar algun elemento para eliminarlo!!", "Seleccione un elemento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
