
namespace BookCloud_Vista
{
    partial class Form_GestionClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox_GestionClientes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_DarClienteAlta_GestorClientes = new System.Windows.Forms.Button();
            this.Button_DarClienteBaja_GestorClientes = new System.Windows.Forms.Button();
            this.Rtb_InfoCliente_GestionClientes = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox_GestionClientes
            // 
            this.listBox_GestionClientes.FormattingEnabled = true;
            this.listBox_GestionClientes.ItemHeight = 25;
            this.listBox_GestionClientes.Location = new System.Drawing.Point(12, 52);
            this.listBox_GestionClientes.Name = "listBox_GestionClientes";
            this.listBox_GestionClientes.Size = new System.Drawing.Size(760, 329);
            this.listBox_GestionClientes.TabIndex = 0;
            this.listBox_GestionClientes.SelectedIndexChanged += new System.EventHandler(this.Btn_MostrarDatos);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Totalidad Clientes";
            // 
            // Button_DarClienteAlta_GestorClientes
            // 
            this.Button_DarClienteAlta_GestorClientes.Location = new System.Drawing.Point(12, 396);
            this.Button_DarClienteAlta_GestorClientes.Name = "Button_DarClienteAlta_GestorClientes";
            this.Button_DarClienteAlta_GestorClientes.Size = new System.Drawing.Size(331, 70);
            this.Button_DarClienteAlta_GestorClientes.TabIndex = 5;
            this.Button_DarClienteAlta_GestorClientes.Text = "Dar de Alta Cliente";
            this.Button_DarClienteAlta_GestorClientes.UseVisualStyleBackColor = true;
            this.Button_DarClienteAlta_GestorClientes.Click += new System.EventHandler(this.Button_DarClienteAlta_GestorClientes_Click);
            // 
            // Button_DarClienteBaja_GestorClientes
            // 
            this.Button_DarClienteBaja_GestorClientes.Location = new System.Drawing.Point(441, 396);
            this.Button_DarClienteBaja_GestorClientes.Name = "Button_DarClienteBaja_GestorClientes";
            this.Button_DarClienteBaja_GestorClientes.Size = new System.Drawing.Size(331, 70);
            this.Button_DarClienteBaja_GestorClientes.TabIndex = 6;
            this.Button_DarClienteBaja_GestorClientes.Text = "Dar de Baja Cliente";
            this.Button_DarClienteBaja_GestorClientes.UseVisualStyleBackColor = true;
            this.Button_DarClienteBaja_GestorClientes.Click += new System.EventHandler(this.Button_DarClienteBaja_GestorClientes_Click);
            // 
            // Rtb_InfoCliente_GestionClientes
            // 
            this.Rtb_InfoCliente_GestionClientes.Location = new System.Drawing.Point(779, 52);
            this.Rtb_InfoCliente_GestionClientes.Name = "Rtb_InfoCliente_GestionClientes";
            this.Rtb_InfoCliente_GestionClientes.Size = new System.Drawing.Size(326, 414);
            this.Rtb_InfoCliente_GestionClientes.TabIndex = 7;
            this.Rtb_InfoCliente_GestionClientes.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(779, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Datos del Cliente";
            // 
            // Form_GestionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 478);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Rtb_InfoCliente_GestionClientes);
            this.Controls.Add(this.Button_DarClienteBaja_GestorClientes);
            this.Controls.Add(this.Button_DarClienteAlta_GestorClientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_GestionClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_GestionClientes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Clientes";
            this.Load += new System.EventHandler(this.Form_GestionClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_GestionClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_DarClienteAlta_GestorClientes;
        private System.Windows.Forms.Button Button_DarClienteBaja_GestorClientes;
        private System.Windows.Forms.RichTextBox Rtb_InfoCliente_GestionClientes;
        private System.Windows.Forms.Label label2;
    }
}