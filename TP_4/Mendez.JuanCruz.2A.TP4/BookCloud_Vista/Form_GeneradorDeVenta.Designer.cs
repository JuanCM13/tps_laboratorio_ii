
namespace BookCloud_Vista
{
    partial class Form_GeneradorDeVenta
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
            this.Ltb_Productos_GestorVenta = new System.Windows.Forms.ListBox();
            this.Rtb_DetalleProducto_GestorVenta = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_nombreCliente = new System.Windows.Forms.Label();
            this.Btn_EliminarProducto_GestorVentas = new System.Windows.Forms.Button();
            this.Btn_Comprar_GestorVentas = new System.Windows.Forms.Button();
            this.Btn_CancelarCompra_GestorVentas = new System.Windows.Forms.Button();
            this.Tbx_PrecioFinal_GestorVentas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_VaciarCarrito_GeneradorVentas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_AgregarProducto_GestorVentas = new System.Windows.Forms.Button();
            this.Rtb_CarritoCliente_GestorVentas = new System.Windows.Forms.RichTextBox();
            this.Lbl_NombreDeCliente_GestorVentas = new System.Windows.Forms.Label();
            this.Lbl_LugarCarrito = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Ltb_Productos_GestorVenta
            // 
            this.Ltb_Productos_GestorVenta.FormattingEnabled = true;
            this.Ltb_Productos_GestorVenta.ItemHeight = 25;
            this.Ltb_Productos_GestorVenta.Location = new System.Drawing.Point(12, 38);
            this.Ltb_Productos_GestorVenta.Name = "Ltb_Productos_GestorVenta";
            this.Ltb_Productos_GestorVenta.Size = new System.Drawing.Size(624, 379);
            this.Ltb_Productos_GestorVenta.TabIndex = 0;
            this.Ltb_Productos_GestorVenta.SelectedIndexChanged += new System.EventHandler(this.Btn_MostrarDetalle);
            // 
            // Rtb_DetalleProducto_GestorVenta
            // 
            this.Rtb_DetalleProducto_GestorVenta.Location = new System.Drawing.Point(12, 475);
            this.Rtb_DetalleProducto_GestorVenta.Name = "Rtb_DetalleProducto_GestorVenta";
            this.Rtb_DetalleProducto_GestorVenta.Size = new System.Drawing.Size(730, 146);
            this.Rtb_DetalleProducto_GestorVenta.TabIndex = 3;
            this.Rtb_DetalleProducto_GestorVenta.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 447);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Detalle del Producto";
            // 
            // Lbl_nombreCliente
            // 
            this.Lbl_nombreCliente.AutoSize = true;
            this.Lbl_nombreCliente.Location = new System.Drawing.Point(763, 10);
            this.Lbl_nombreCliente.Name = "Lbl_nombreCliente";
            this.Lbl_nombreCliente.Size = new System.Drawing.Size(0, 25);
            this.Lbl_nombreCliente.TabIndex = 5;
            // 
            // Btn_EliminarProducto_GestorVentas
            // 
            this.Btn_EliminarProducto_GestorVentas.Location = new System.Drawing.Point(654, 328);
            this.Btn_EliminarProducto_GestorVentas.Name = "Btn_EliminarProducto_GestorVentas";
            this.Btn_EliminarProducto_GestorVentas.Size = new System.Drawing.Size(417, 34);
            this.Btn_EliminarProducto_GestorVentas.TabIndex = 7;
            this.Btn_EliminarProducto_GestorVentas.Text = "Eliminar Producto del Carrito";
            this.Btn_EliminarProducto_GestorVentas.UseVisualStyleBackColor = true;
            this.Btn_EliminarProducto_GestorVentas.Click += new System.EventHandler(this.Btn_EliminarProducto_GestorVentas_Click);
            // 
            // Btn_Comprar_GestorVentas
            // 
            this.Btn_Comprar_GestorVentas.Location = new System.Drawing.Point(763, 587);
            this.Btn_Comprar_GestorVentas.Name = "Btn_Comprar_GestorVentas";
            this.Btn_Comprar_GestorVentas.Size = new System.Drawing.Size(308, 34);
            this.Btn_Comprar_GestorVentas.TabIndex = 8;
            this.Btn_Comprar_GestorVentas.Text = "Generar Venta";
            this.Btn_Comprar_GestorVentas.UseVisualStyleBackColor = true;
            this.Btn_Comprar_GestorVentas.Click += new System.EventHandler(this.Btn_Comprar_GestorVentas_Click);
            // 
            // Btn_CancelarCompra_GestorVentas
            // 
            this.Btn_CancelarCompra_GestorVentas.Location = new System.Drawing.Point(763, 547);
            this.Btn_CancelarCompra_GestorVentas.Name = "Btn_CancelarCompra_GestorVentas";
            this.Btn_CancelarCompra_GestorVentas.Size = new System.Drawing.Size(308, 34);
            this.Btn_CancelarCompra_GestorVentas.TabIndex = 9;
            this.Btn_CancelarCompra_GestorVentas.Text = "Cancelar Compra";
            this.Btn_CancelarCompra_GestorVentas.UseVisualStyleBackColor = true;
            this.Btn_CancelarCompra_GestorVentas.Click += new System.EventHandler(this.Btn_CancelarCompra_GestorVentas_Click);
            // 
            // Tbx_PrecioFinal_GestorVentas
            // 
            this.Tbx_PrecioFinal_GestorVentas.Location = new System.Drawing.Point(763, 510);
            this.Tbx_PrecioFinal_GestorVentas.Name = "Tbx_PrecioFinal_GestorVentas";
            this.Tbx_PrecioFinal_GestorVentas.ReadOnly = true;
            this.Tbx_PrecioFinal_GestorVentas.Size = new System.Drawing.Size(308, 31);
            this.Tbx_PrecioFinal_GestorVentas.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(763, 482);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Precio Final con Descuentos Incluidos";
            // 
            // Btn_VaciarCarrito_GeneradorVentas
            // 
            this.Btn_VaciarCarrito_GeneradorVentas.Location = new System.Drawing.Point(654, 382);
            this.Btn_VaciarCarrito_GeneradorVentas.Name = "Btn_VaciarCarrito_GeneradorVentas";
            this.Btn_VaciarCarrito_GeneradorVentas.Size = new System.Drawing.Size(417, 34);
            this.Btn_VaciarCarrito_GeneradorVentas.TabIndex = 12;
            this.Btn_VaciarCarrito_GeneradorVentas.Text = "Vaciar Carrito";
            this.Btn_VaciarCarrito_GeneradorVentas.UseVisualStyleBackColor = true;
            this.Btn_VaciarCarrito_GeneradorVentas.Click += new System.EventHandler(this.Btn_VaciarCarrito_GeneradorVentas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Publicaciones";
            // 
            // Btn_AgregarProducto_GestorVentas
            // 
            this.Btn_AgregarProducto_GestorVentas.Location = new System.Drawing.Point(654, 272);
            this.Btn_AgregarProducto_GestorVentas.Name = "Btn_AgregarProducto_GestorVentas";
            this.Btn_AgregarProducto_GestorVentas.Size = new System.Drawing.Size(417, 34);
            this.Btn_AgregarProducto_GestorVentas.TabIndex = 14;
            this.Btn_AgregarProducto_GestorVentas.Text = "Agregar Producto al Carrito";
            this.Btn_AgregarProducto_GestorVentas.UseVisualStyleBackColor = true;
            this.Btn_AgregarProducto_GestorVentas.Click += new System.EventHandler(this.Btn_AgregarProducto_GestorVentas_Click);
            // 
            // Rtb_CarritoCliente_GestorVentas
            // 
            this.Rtb_CarritoCliente_GestorVentas.Location = new System.Drawing.Point(654, 39);
            this.Rtb_CarritoCliente_GestorVentas.Name = "Rtb_CarritoCliente_GestorVentas";
            this.Rtb_CarritoCliente_GestorVentas.Size = new System.Drawing.Size(417, 163);
            this.Rtb_CarritoCliente_GestorVentas.TabIndex = 15;
            this.Rtb_CarritoCliente_GestorVentas.Text = "";
            // 
            // Lbl_NombreDeCliente_GestorVentas
            // 
            this.Lbl_NombreDeCliente_GestorVentas.AutoSize = true;
            this.Lbl_NombreDeCliente_GestorVentas.Location = new System.Drawing.Point(763, 9);
            this.Lbl_NombreDeCliente_GestorVentas.Name = "Lbl_NombreDeCliente_GestorVentas";
            this.Lbl_NombreDeCliente_GestorVentas.Size = new System.Drawing.Size(0, 25);
            this.Lbl_NombreDeCliente_GestorVentas.TabIndex = 16;
            // 
            // Lbl_LugarCarrito
            // 
            this.Lbl_LugarCarrito.AutoSize = true;
            this.Lbl_LugarCarrito.Font = new System.Drawing.Font("Segoe UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Lbl_LugarCarrito.Location = new System.Drawing.Point(663, 205);
            this.Lbl_LugarCarrito.Name = "Lbl_LugarCarrito";
            this.Lbl_LugarCarrito.Size = new System.Drawing.Size(0, 21);
            this.Lbl_LugarCarrito.TabIndex = 17;
            // 
            // Form_GeneradorDeVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 633);
            this.Controls.Add(this.Lbl_LugarCarrito);
            this.Controls.Add(this.Lbl_NombreDeCliente_GestorVentas);
            this.Controls.Add(this.Rtb_CarritoCliente_GestorVentas);
            this.Controls.Add(this.Btn_AgregarProducto_GestorVentas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_VaciarCarrito_GeneradorVentas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Tbx_PrecioFinal_GestorVentas);
            this.Controls.Add(this.Btn_CancelarCompra_GestorVentas);
            this.Controls.Add(this.Btn_Comprar_GestorVentas);
            this.Controls.Add(this.Btn_EliminarProducto_GestorVentas);
            this.Controls.Add(this.Lbl_nombreCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Rtb_DetalleProducto_GestorVenta);
            this.Controls.Add(this.Ltb_Productos_GestorVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_GeneradorDeVenta";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor Ventas";
            this.Load += new System.EventHandler(this.Form_GeneradorDeVenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Ltb_Productos_GestorVenta;
        private System.Windows.Forms.RichTextBox Rtb_DetalleProducto_GestorVenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lbl_nombreCliente;
        private System.Windows.Forms.Button Btn_EliminarProducto_GestorVentas;
        private System.Windows.Forms.Button Btn_Comprar_GestorVentas;
        private System.Windows.Forms.Button Btn_CancelarCompra_GestorVentas;
        private System.Windows.Forms.TextBox Tbx_PrecioFinal_GestorVentas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_VaciarCarrito_GeneradorVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_AgregarProducto_GestorVentas;
        private System.Windows.Forms.RichTextBox Rtb_CarritoCliente_GestorVentas;
        private System.Windows.Forms.Label Lbl_NombreDeCliente_GestorVentas;
        private System.Windows.Forms.Label Lbl_LugarCarrito;
    }
}