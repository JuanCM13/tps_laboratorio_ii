
namespace BookCloud_Vista
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_GestionClientes = new System.Windows.Forms.Button();
            this.Btn_RealizarVenta_FormPrincipal = new System.Windows.Forms.Button();
            this.Btn_RegistroVentas_FormPrincipal = new System.Windows.Forms.Button();
            this.Btn_SoporteTecnico = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_GestionarReclamosPendientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_GestionClientes
            // 
            this.Btn_GestionClientes.Location = new System.Drawing.Point(12, 167);
            this.Btn_GestionClientes.Name = "Btn_GestionClientes";
            this.Btn_GestionClientes.Size = new System.Drawing.Size(556, 73);
            this.Btn_GestionClientes.TabIndex = 0;
            this.Btn_GestionClientes.Text = "Gestion de Clientes";
            this.Btn_GestionClientes.UseVisualStyleBackColor = true;
            this.Btn_GestionClientes.Click += new System.EventHandler(this.GestionClientes_Click);
            // 
            // Btn_RealizarVenta_FormPrincipal
            // 
            this.Btn_RealizarVenta_FormPrincipal.Location = new System.Drawing.Point(12, 269);
            this.Btn_RealizarVenta_FormPrincipal.Name = "Btn_RealizarVenta_FormPrincipal";
            this.Btn_RealizarVenta_FormPrincipal.Size = new System.Drawing.Size(556, 73);
            this.Btn_RealizarVenta_FormPrincipal.TabIndex = 1;
            this.Btn_RealizarVenta_FormPrincipal.Text = "Realizar Venta";
            this.Btn_RealizarVenta_FormPrincipal.UseVisualStyleBackColor = true;
            this.Btn_RealizarVenta_FormPrincipal.Click += new System.EventHandler(this.RealizarVenta_Click);
            // 
            // Btn_RegistroVentas_FormPrincipal
            // 
            this.Btn_RegistroVentas_FormPrincipal.Location = new System.Drawing.Point(12, 373);
            this.Btn_RegistroVentas_FormPrincipal.Name = "Btn_RegistroVentas_FormPrincipal";
            this.Btn_RegistroVentas_FormPrincipal.Size = new System.Drawing.Size(556, 73);
            this.Btn_RegistroVentas_FormPrincipal.TabIndex = 2;
            this.Btn_RegistroVentas_FormPrincipal.Text = "Registro de Ventas";
            this.Btn_RegistroVentas_FormPrincipal.UseVisualStyleBackColor = true;
            this.Btn_RegistroVentas_FormPrincipal.Click += new System.EventHandler(this.Btn_RegistroVentas_FormPrincipal_Click);
            // 
            // Btn_SoporteTecnico
            // 
            this.Btn_SoporteTecnico.Location = new System.Drawing.Point(358, 587);
            this.Btn_SoporteTecnico.Name = "Btn_SoporteTecnico";
            this.Btn_SoporteTecnico.Size = new System.Drawing.Size(219, 34);
            this.Btn_SoporteTecnico.TabIndex = 3;
            this.Btn_SoporteTecnico.Text = "Soporte Tecnico";
            this.Btn_SoporteTecnico.UseVisualStyleBackColor = true;
            this.Btn_SoporteTecnico.Click += new System.EventHandler(this.Btn_SoporteTecnico_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(-2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(591, 74);
            this.label1.TabIndex = 4;
            this.label1.Text = "BOOKCLOUD VENTAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(87, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(390, 45);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tu Libreria de Confianza";
            // 
            // Btn_GestionarReclamosPendientes
            // 
            this.Btn_GestionarReclamosPendientes.Location = new System.Drawing.Point(12, 481);
            this.Btn_GestionarReclamosPendientes.Name = "Btn_GestionarReclamosPendientes";
            this.Btn_GestionarReclamosPendientes.Size = new System.Drawing.Size(556, 73);
            this.Btn_GestionarReclamosPendientes.TabIndex = 6;
            this.Btn_GestionarReclamosPendientes.Text = "Gestion Reclamos Pendientes";
            this.Btn_GestionarReclamosPendientes.UseVisualStyleBackColor = true;
            this.Btn_GestionarReclamosPendientes.Click += new System.EventHandler(this.Btn_GestionarReclamosPendientes_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(589, 633);
            this.Controls.Add(this.Btn_GestionarReclamosPendientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_SoporteTecnico);
            this.Controls.Add(this.Btn_RegistroVentas_FormPrincipal);
            this.Controls.Add(this.Btn_RealizarVenta_FormPrincipal);
            this.Controls.Add(this.Btn_GestionClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INICIO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_GestionClientes;
        private System.Windows.Forms.Button Btn_RealizarVenta_FormPrincipal;
        private System.Windows.Forms.Button Btn_RegistroVentas_FormPrincipal;
        private System.Windows.Forms.Button Btn_SoporteTecnico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_GestionarReclamosPendientes;
    }
}

