
namespace BookCloud_Vista
{
    partial class Form_RegistroVentas
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
            this.Ltb_Ventas_RegistroVentas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Ltb_Ventas_RegistroVentas
            // 
            this.Ltb_Ventas_RegistroVentas.FormattingEnabled = true;
            this.Ltb_Ventas_RegistroVentas.ItemHeight = 25;
            this.Ltb_Ventas_RegistroVentas.Location = new System.Drawing.Point(13, 13);
            this.Ltb_Ventas_RegistroVentas.Name = "Ltb_Ventas_RegistroVentas";
            this.Ltb_Ventas_RegistroVentas.Size = new System.Drawing.Size(1217, 629);
            this.Ltb_Ventas_RegistroVentas.TabIndex = 0;
            // 
            // Form_RegistroVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 653);
            this.Controls.Add(this.Ltb_Ventas_RegistroVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_RegistroVentas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Ventas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Ltb_Ventas_RegistroVentas;
    }
}