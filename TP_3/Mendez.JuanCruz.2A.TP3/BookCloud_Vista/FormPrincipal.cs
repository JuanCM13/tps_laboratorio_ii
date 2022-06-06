﻿using System;
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
    public partial class FormPrincipal : Form
    {
        private List<Venta> listadoVentas;
        private List<Cliente_BookCloud> listadoClientes;
        private List<Publicacion> publicaciones;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga la data de clientes, ventas y publicaciones de archivos/base datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.listadoClientes = new Serializado_Xml<List<Cliente_BookCloud>>().Deserializar("Clientes_File");
            this.publicaciones = new Serializado_Xml<List<Publicacion>>().Deserializar("Publicaciones_File");
            this.listadoVentas = new Serializado_Json<List<Venta>>().Deserializar("Ventas_File");
        }

        /// <summary>
        /// Instancia y ejecuta formulario de GestionClientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GestionClientes_Click(object sender, EventArgs e)
        {
            Form_GestionClientes auxGestionClientes = new Form_GestionClientes(this.listadoClientes);
            this.Hide();
            auxGestionClientes.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Instancia y ejecuta formulario de GestionVenta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RealizarVenta_Click(object sender, EventArgs e)
        {
            Form_SeleccionDeCliente frmSeleccion = new Form_SeleccionDeCliente(this.listadoClientes, this.listadoVentas, this.publicaciones);
            this.Hide();
            frmSeleccion.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Instancia y ejecuta formulario de RegiostroVentas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_RegistroVentas_FormPrincipal_Click(object sender, EventArgs e)
        {
            Form_RegistroVentas frmRegistroVentas = new Form_RegistroVentas(this.listadoVentas);
            this.Hide();
            frmRegistroVentas.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Instancia y ejecuta formulario de Soporte tecnico
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_SoporteTecnico_Click(object sender, EventArgs e)
        {
            Form_SoporteTecnico frmSoporte = new Form_SoporteTecnico();
            this.Hide();
            frmSoporte.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Pide confirmacion de salir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Esta seguro de salir? Los carritos llenos de los clientes que no fueron concretadas sus ventas, seran vaciados..","Confirme",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Se actualizan los archivos y cierra la aplicacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Serializado_Xml<List<Cliente_BookCloud>> listaClientesActualizada = new();
            Serializado_Json<List<Venta>> listaVentasActualizada = new();

            try
            {
                listaClientesActualizada.Serializar(this.listadoClientes, "Clientes_File");
                listaVentasActualizada.Serializar(this.listadoVentas, "Ventas_File");

                MessageBox.Show("Las listas de ventas y clientes fueron actualizadas!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }
    }
}
