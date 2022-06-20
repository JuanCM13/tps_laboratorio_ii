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
    public delegate void TraerListas_Delegate();

    public partial class FormPrincipal : Form
    {
        private List<Venta> listadoVentas;
        private List<Cliente_BookCloud> listadoClientes;
        private List<Publicacion> publicaciones;
        private TraerListas_Delegate delegadoListas;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga la data de clientes, ventas y publicaciones de archivos/base datos, invocando al delegado y cargando
        /// sus metodos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.delegadoListas = CargarLista_clientesAsincronamente;
            this.delegadoListas += CargarLista_publicacionesAsincronamente;
            this.delegadoListas += CargarLista_ventasAsincronamente;

            this.delegadoListas.Invoke();
        }


        /// <summary>
        /// Llama de manera asincronica a metodo que carga lista de clientes, sin trabar la ejec del programa
        /// </summary>
        private async void CargarLista_clientesAsincronamente()
        {
            this.listadoClientes = await LongTasks.Traer_Clientes();

        }

        /// <summary>
        /// Llama de manera asincronica a metodo que carga lista de publicaciones, sin trabar la ejec del programa
        /// </summary>
        private async void CargarLista_publicacionesAsincronamente()
        {
            this.publicaciones = await LongTasks.Traer_Publicaciones();
        }

        /// <summary>
        /// Llama de manera asincronica a metodo que carga lista de ventas, sin trabar la ejec del programa
        /// </summary>
        private async void CargarLista_ventasAsincronamente()
        {
            this.listadoVentas = await LongTasks.Traer_Ventas();
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

        /// <summary>
        /// Instancia y ejecuta formulario de Gestion de Reclamos Pendientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_GestionarReclamosPendientes_Click(object sender, EventArgs e)
        {
            Form_GestionReclamosPendientes reclamos = new Form_GestionReclamosPendientes();

            this.Hide();
            reclamos.ShowDialog();
            this.Show();
        }
    }
}
