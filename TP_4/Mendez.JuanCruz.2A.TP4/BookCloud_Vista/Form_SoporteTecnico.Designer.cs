
namespace BookCloud_Vista
{
    partial class Form_SoporteTecnico
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
            this.Rtb_Consulta = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_EnviarConsulta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Rtb_Consulta
            // 
            this.Rtb_Consulta.Location = new System.Drawing.Point(13, 44);
            this.Rtb_Consulta.Name = "Rtb_Consulta";
            this.Rtb_Consulta.Size = new System.Drawing.Size(855, 331);
            this.Rtb_Consulta.TabIndex = 0;
            this.Rtb_Consulta.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(855, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sentimos los inconvenientes, estamos en constante perfeccionamiento, dejanos tu c" +
    "onsulta!";
            // 
            // Btn_EnviarConsulta
            // 
            this.Btn_EnviarConsulta.Location = new System.Drawing.Point(695, 381);
            this.Btn_EnviarConsulta.Name = "Btn_EnviarConsulta";
            this.Btn_EnviarConsulta.Size = new System.Drawing.Size(173, 49);
            this.Btn_EnviarConsulta.TabIndex = 2;
            this.Btn_EnviarConsulta.Text = "Enviar Consulta";
            this.Btn_EnviarConsulta.UseVisualStyleBackColor = true;
            this.Btn_EnviarConsulta.Click += new System.EventHandler(this.Btn_EnviarConsulta_Click);
            // 
            // Form_SoporteTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 442);
            this.Controls.Add(this.Btn_EnviarConsulta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Rtb_Consulta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_SoporteTecnico";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soporte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Rtb_Consulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_EnviarConsulta;
    }
}