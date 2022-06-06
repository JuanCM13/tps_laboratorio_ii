
namespace BookCloud_Vista
{
    partial class Form_SeleccionDeCliente
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
            this.Lbt_Premium_SeleccionClientes = new System.Windows.Forms.ListBox();
            this.Lbt_Regular_SeleccionClientes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Seleccionar_SeleccionCliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_AgregarCliente_SeleccionarCliente = new System.Windows.Forms.Button();
            this.Btn_Reset_SeleccionCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbt_Premium_SeleccionClientes
            // 
            this.Lbt_Premium_SeleccionClientes.FormattingEnabled = true;
            this.Lbt_Premium_SeleccionClientes.ItemHeight = 25;
            this.Lbt_Premium_SeleccionClientes.Location = new System.Drawing.Point(12, 42);
            this.Lbt_Premium_SeleccionClientes.Name = "Lbt_Premium_SeleccionClientes";
            this.Lbt_Premium_SeleccionClientes.Size = new System.Drawing.Size(682, 379);
            this.Lbt_Premium_SeleccionClientes.TabIndex = 0;
            this.Lbt_Premium_SeleccionClientes.Click += new System.EventHandler(this.Lbt_Premium_SeleccionClientes_Click);
            // 
            // Lbt_Regular_SeleccionClientes
            // 
            this.Lbt_Regular_SeleccionClientes.FormattingEnabled = true;
            this.Lbt_Regular_SeleccionClientes.ItemHeight = 25;
            this.Lbt_Regular_SeleccionClientes.Location = new System.Drawing.Point(710, 42);
            this.Lbt_Regular_SeleccionClientes.Name = "Lbt_Regular_SeleccionClientes";
            this.Lbt_Regular_SeleccionClientes.Size = new System.Drawing.Size(682, 379);
            this.Lbt_Regular_SeleccionClientes.TabIndex = 1;
            this.Lbt_Regular_SeleccionClientes.Click += new System.EventHandler(this.Lbt_Regular_SeleccionClientes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Clientes Premium";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(710, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clientes Regulares";
            // 
            // Btn_Seleccionar_SeleccionCliente
            // 
            this.Btn_Seleccionar_SeleccionCliente.Location = new System.Drawing.Point(1136, 443);
            this.Btn_Seleccionar_SeleccionCliente.Name = "Btn_Seleccionar_SeleccionCliente";
            this.Btn_Seleccionar_SeleccionCliente.Size = new System.Drawing.Size(256, 34);
            this.Btn_Seleccionar_SeleccionCliente.TabIndex = 4;
            this.Btn_Seleccionar_SeleccionCliente.Text = "Seleccionar";
            this.Btn_Seleccionar_SeleccionCliente.UseVisualStyleBackColor = true;
            this.Btn_Seleccionar_SeleccionCliente.Click += new System.EventHandler(this.Click_Seleccionar);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "No encontro el Cliente que buscaba?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(913, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Generemos ese Pedido!";
            // 
            // Btn_AgregarCliente_SeleccionarCliente
            // 
            this.Btn_AgregarCliente_SeleccionarCliente.Location = new System.Drawing.Point(331, 443);
            this.Btn_AgregarCliente_SeleccionarCliente.Name = "Btn_AgregarCliente_SeleccionarCliente";
            this.Btn_AgregarCliente_SeleccionarCliente.Size = new System.Drawing.Size(256, 34);
            this.Btn_AgregarCliente_SeleccionarCliente.TabIndex = 7;
            this.Btn_AgregarCliente_SeleccionarCliente.Text = "Sumar Nuevo Cliente!";
            this.Btn_AgregarCliente_SeleccionarCliente.UseVisualStyleBackColor = true;
            this.Btn_AgregarCliente_SeleccionarCliente.Click += new System.EventHandler(this.Click_AgregarCliente);
            // 
            // Btn_Reset_SeleccionCliente
            // 
            this.Btn_Reset_SeleccionCliente.Location = new System.Drawing.Point(710, 442);
            this.Btn_Reset_SeleccionCliente.Name = "Btn_Reset_SeleccionCliente";
            this.Btn_Reset_SeleccionCliente.Size = new System.Drawing.Size(166, 34);
            this.Btn_Reset_SeleccionCliente.TabIndex = 8;
            this.Btn_Reset_SeleccionCliente.Text = "Reset";
            this.Btn_Reset_SeleccionCliente.UseVisualStyleBackColor = true;
            this.Btn_Reset_SeleccionCliente.Click += new System.EventHandler(this.Btn_Reset_SeleccionCliente_Click);
            // 
            // Form_SeleccionDeCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 498);
            this.Controls.Add(this.Btn_Reset_SeleccionCliente);
            this.Controls.Add(this.Btn_AgregarCliente_SeleccionarCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Btn_Seleccionar_SeleccionCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbt_Regular_SeleccionClientes);
            this.Controls.Add(this.Lbt_Premium_SeleccionClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_SeleccionDeCliente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccion Cliente";
            this.Load += new System.EventHandler(this.Form_SeleccionDeCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Lbt_Premium_SeleccionClientes;
        private System.Windows.Forms.ListBox Lbt_Regular_SeleccionClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Seleccionar_SeleccionCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_AgregarCliente_SeleccionarCliente;
        private System.Windows.Forms.Button Btn_Reset_SeleccionCliente;
    }
}