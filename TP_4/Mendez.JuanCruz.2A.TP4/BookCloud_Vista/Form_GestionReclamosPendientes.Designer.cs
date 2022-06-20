
namespace BookCloud_Vista
{
    partial class Form_GestionReclamosPendientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.Lst_Reclamos = new System.Windows.Forms.ListBox();
            this.Btn_SolucionarReclamo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reclamos Pendientes a Solucionar";
            // 
            // Lst_Reclamos
            // 
            this.Lst_Reclamos.FormattingEnabled = true;
            this.Lst_Reclamos.ItemHeight = 25;
            this.Lst_Reclamos.Location = new System.Drawing.Point(12, 58);
            this.Lst_Reclamos.Name = "Lst_Reclamos";
            this.Lst_Reclamos.Size = new System.Drawing.Size(987, 504);
            this.Lst_Reclamos.TabIndex = 1;
            // 
            // Btn_SolucionarReclamo
            // 
            this.Btn_SolucionarReclamo.Location = new System.Drawing.Point(827, 591);
            this.Btn_SolucionarReclamo.Name = "Btn_SolucionarReclamo";
            this.Btn_SolucionarReclamo.Size = new System.Drawing.Size(172, 46);
            this.Btn_SolucionarReclamo.TabIndex = 2;
            this.Btn_SolucionarReclamo.Text = "Solucionar";
            this.Btn_SolucionarReclamo.UseVisualStyleBackColor = true;
            this.Btn_SolucionarReclamo.Click += new System.EventHandler(this.Btn_SolucionarReclamo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 599);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(660, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "La consulta ya fue solucionada? Eliminemosla de la lista de pendientes!";
            // 
            // Form_GestionReclamosPendientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 649);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_SolucionarReclamo);
            this.Controls.Add(this.Lst_Reclamos);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_GestionReclamosPendientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionar Reclamos";
            this.Load += new System.EventHandler(this.Form_GestionReclamosPendientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Lst_Reclamos;
        private System.Windows.Forms.Button Btn_SolucionarReclamo;
        private System.Windows.Forms.Label label2;
    }
}