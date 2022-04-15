using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Entidades;
namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga el combobox y define el ancho de los textbox , ademas prepara el entorno llamando al metodo 
        /// limpiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.cmbOperador.Items.Add(" ");
            this.cmbOperador.Items.Add("+");
            this.cmbOperador.Items.Add("-");
            this.cmbOperador.Items.Add("*");
            this.cmbOperador.Items.Add("/");
            this.Limpiar();
        }

        /// <summary>
        /// Limpia los buffers de ingreso de datos, y setea valores por default..
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Text = String.Empty;
            this.txtNumero2.Text = String.Empty;
            this.cmbOperador.SelectedItem = " ";
            this.lblResultado.Text = "0";
        }

        /// <summary>
        /// Imprime por pantalla el resultado de la operacion y setea esta operacion al listado de operaciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            this.txtNumero2.BackColor = Color.White;
            StringBuilder str = new StringBuilder();
            String operacion = this.cmbOperador.SelectedItem.ToString();
            String op1 = this.txtNumero1.Text;
            String op2 = this.txtNumero2.Text;
            double result;
            double auxCheckeo;

            result = this.Operar(op1, op2, operacion);

            if (result != double.MinValue)
            {
                this.lblResultado.Text = result.ToString("#,#.00");

                if (operacion == " ")
                {
                    operacion = "+";
                }

                if (!double.TryParse(op1, out auxCheckeo))
                {
                    op1 = "0";
                }

                if (!double.TryParse(op2, out auxCheckeo))
                {
                    op2 = "0";
                }

                str.AppendLine($"{op1} {operacion} {op2} = {this.lblResultado.Text}");
                this.lstOperaciones.Items.Add(str.ToString());
            }
            else
            {
                MessageBox.Show("No se puede dividir por 0..", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.txtNumero2.Focus();
                this.txtNumero2.BackColor = Color.FromArgb(255, 175, 139);
            }
        }

        /// <summary>
        /// Realiza el calculo ingresado por el usuario
        /// </summary>
        /// <param name="numero1"> operador 1</param>
        /// <param name="numero2"> operador 2</param>
        /// <param name="operador"> tipo de operacion</param>
        /// <returns> resultado del calculo </returns>
        private double Operar(String numero1, String numero2, String operador)
        {
            numero1 = numero1.Replace('.', ',');
            numero2 = numero2.Replace('.', ',');
            double ret = Calculadora.Operar(new Operando(numero1), new Operando(numero2), char.Parse(operador));
            return ret;
        }

        /// <summary>
        /// Limpia la pantalla, excepto el listado de operaciones y setea todos los valores a default
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        /// <summary>
        /// Convierte siempre que sea posible, el resultado a binario. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirAbinario_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.lblResultado.Text) == false)
            {
                this.lblResultado.Text = new Operando().DecimalBinario(this.lblResultado.Text);
            }
        }

        /// <summary>
        /// Convierte siempre que sea posible (que se haya convertido el resultado a binario) , el resultado
        /// a decimal..
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirAdecimal_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.lblResultado.Text) == false)
            {
                this.lblResultado.Text = new Operando().BinarioDecimal(this.lblResultado.Text);
            }
        }

        /// <summary>
        /// Controla la secuencia de terminacion del programa, pide confirmacion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Cierra el formulario pidiendo confirmacion. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
