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
    public partial class Form_RegistroVentas : Form
    {
        public Form_RegistroVentas(List<Venta> ventas)
        {
            InitializeComponent();
            this.MostrarVentas(ventas); 
        }

        /// <summary>
        /// Vuelca informacion de ventas al listbox
        /// </summary>
        /// <param name="ventas"></param>
        private void MostrarVentas(List<Venta> ventas)
        {
            if(!(ventas is null) && ventas.Count > 0)
            {
                foreach(Venta item in ventas)
                {
                    this.Ltb_Ventas_RegistroVentas.Items.Add(item);
                }
            }
            else
            {
                this.Ltb_Ventas_RegistroVentas.Items.Add("Cargando listado de Ventas, vuelva al menu principal y reingrese en unos segundos!");
            }
        }
    }
}
