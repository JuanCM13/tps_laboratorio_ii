
namespace BookCloud_Vista
{
    partial class FormAltaCliente
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
            this.cmb_TipoCliente_AltaCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Nacionalidad_AltaCliente = new System.Windows.Forms.ComboBox();
            this.tbx_Nombre_AltaCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_Apellido_AltaCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_Dni_AltaCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_Email_AltaCliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbx_Telefono_AltaCliente = new System.Windows.Forms.TextBox();
            this.dateTimePicker_AltaCliente = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.Btn_Cancelar_AltaCliente = new System.Windows.Forms.Button();
            this.Btn_DarAlta_AltaCliente = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // cmb_TipoCliente_AltaCliente
            // 
            this.cmb_TipoCliente_AltaCliente.FormattingEnabled = true;
            this.cmb_TipoCliente_AltaCliente.Location = new System.Drawing.Point(13, 53);
            this.cmb_TipoCliente_AltaCliente.Name = "cmb_TipoCliente_AltaCliente";
            this.cmb_TipoCliente_AltaCliente.Size = new System.Drawing.Size(450, 33);
            this.cmb_TipoCliente_AltaCliente.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nacionalidad";
            // 
            // cmb_Nacionalidad_AltaCliente
            // 
            this.cmb_Nacionalidad_AltaCliente.FormattingEnabled = true;
            this.cmb_Nacionalidad_AltaCliente.Location = new System.Drawing.Point(13, 128);
            this.cmb_Nacionalidad_AltaCliente.Name = "cmb_Nacionalidad_AltaCliente";
            this.cmb_Nacionalidad_AltaCliente.Size = new System.Drawing.Size(450, 33);
            this.cmb_Nacionalidad_AltaCliente.TabIndex = 2;
            // 
            // tbx_Nombre_AltaCliente
            // 
            this.tbx_Nombre_AltaCliente.Location = new System.Drawing.Point(13, 198);
            this.tbx_Nombre_AltaCliente.Name = "tbx_Nombre_AltaCliente";
            this.tbx_Nombre_AltaCliente.Size = new System.Drawing.Size(450, 31);
            this.tbx_Nombre_AltaCliente.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Apellido";
            // 
            // tbx_Apellido_AltaCliente
            // 
            this.tbx_Apellido_AltaCliente.Location = new System.Drawing.Point(13, 276);
            this.tbx_Apellido_AltaCliente.Name = "tbx_Apellido_AltaCliente";
            this.tbx_Apellido_AltaCliente.Size = new System.Drawing.Size(450, 31);
            this.tbx_Apellido_AltaCliente.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "DNI";
            // 
            // tbx_Dni_AltaCliente
            // 
            this.tbx_Dni_AltaCliente.Location = new System.Drawing.Point(13, 346);
            this.tbx_Dni_AltaCliente.Name = "tbx_Dni_AltaCliente";
            this.tbx_Dni_AltaCliente.Size = new System.Drawing.Size(450, 31);
            this.tbx_Dni_AltaCliente.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "EMAIL";
            // 
            // tbx_Email_AltaCliente
            // 
            this.tbx_Email_AltaCliente.Location = new System.Drawing.Point(13, 411);
            this.tbx_Email_AltaCliente.Name = "tbx_Email_AltaCliente";
            this.tbx_Email_AltaCliente.Size = new System.Drawing.Size(450, 31);
            this.tbx_Email_AltaCliente.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 456);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Telefono";
            // 
            // tbx_Telefono_AltaCliente
            // 
            this.tbx_Telefono_AltaCliente.Location = new System.Drawing.Point(13, 484);
            this.tbx_Telefono_AltaCliente.Name = "tbx_Telefono_AltaCliente";
            this.tbx_Telefono_AltaCliente.Size = new System.Drawing.Size(450, 31);
            this.tbx_Telefono_AltaCliente.TabIndex = 12;
            // 
            // dateTimePicker_AltaCliente
            // 
            this.dateTimePicker_AltaCliente.Location = new System.Drawing.Point(11, 569);
            this.dateTimePicker_AltaCliente.Name = "dateTimePicker_AltaCliente";
            this.dateTimePicker_AltaCliente.Size = new System.Drawing.Size(450, 31);
            this.dateTimePicker_AltaCliente.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 531);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Feche Nacimiento";
            // 
            // Btn_Cancelar_AltaCliente
            // 
            this.Btn_Cancelar_AltaCliente.Location = new System.Drawing.Point(11, 625);
            this.Btn_Cancelar_AltaCliente.Name = "Btn_Cancelar_AltaCliente";
            this.Btn_Cancelar_AltaCliente.Size = new System.Drawing.Size(196, 34);
            this.Btn_Cancelar_AltaCliente.TabIndex = 16;
            this.Btn_Cancelar_AltaCliente.Text = "Cancelar";
            this.Btn_Cancelar_AltaCliente.UseVisualStyleBackColor = true;
            this.Btn_Cancelar_AltaCliente.Click += new System.EventHandler(this.Click_Cancelar);
            // 
            // Btn_DarAlta_AltaCliente
            // 
            this.Btn_DarAlta_AltaCliente.Location = new System.Drawing.Point(265, 625);
            this.Btn_DarAlta_AltaCliente.Name = "Btn_DarAlta_AltaCliente";
            this.Btn_DarAlta_AltaCliente.Size = new System.Drawing.Size(196, 34);
            this.Btn_DarAlta_AltaCliente.TabIndex = 17;
            this.Btn_DarAlta_AltaCliente.Text = "Dar de Alta";
            this.Btn_DarAlta_AltaCliente.UseVisualStyleBackColor = true;
            this.Btn_DarAlta_AltaCliente.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormAltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 671);
            this.Controls.Add(this.Btn_DarAlta_AltaCliente);
            this.Controls.Add(this.Btn_Cancelar_AltaCliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker_AltaCliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbx_Telefono_AltaCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbx_Email_AltaCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbx_Dni_AltaCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbx_Apellido_AltaCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_Nombre_AltaCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_Nacionalidad_AltaCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_TipoCliente_AltaCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAltaCliente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Cliente";
            //this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAltaCliente_FormClosing);
            this.Load += new System.EventHandler(this.FormAltaCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_TipoCliente_AltaCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Nacionalidad_AltaCliente;
        private System.Windows.Forms.TextBox tbx_Nombre_AltaCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_Apellido_AltaCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_Dni_AltaCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbx_Email_AltaCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbx_Telefono_AltaCliente;
        private System.Windows.Forms.DateTimePicker dateTimePicker_AltaCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Btn_Cancelar_AltaCliente;
        private System.Windows.Forms.Button Btn_DarAlta_AltaCliente;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}