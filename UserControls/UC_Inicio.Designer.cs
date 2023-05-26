namespace Estacionamiento.UserControls
{
    partial class UC_Inicio
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Tickets = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txt_numeroDeTicket = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxSellado = new System.Windows.Forms.CheckBox();
            this.btnObtenerTicket = new Guna.UI2.WinForms.Guna2Button();
            this.btnPagado = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTipoDeCobro = new System.Windows.Forms.Label();
            this.lblDescuentoAplicado = new System.Windows.Forms.Label();
            this.lblTipoDeVehiculo = new System.Windows.Forms.Label();
            this.lblHoraDeSalida = new System.Windows.Forms.Label();
            this.btn_verMas = new Guna.UI2.WinForms.Guna2Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblHoraDeEntrada = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalculaCobro = new Guna.UI2.WinForms.Guna2Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tickets
            // 
            this.Tickets.AutoSize = true;
            this.Tickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tickets.Location = new System.Drawing.Point(595, 14);
            this.Tickets.Name = "Tickets";
            this.Tickets.Size = new System.Drawing.Size(135, 46);
            this.Tickets.TabIndex = 13;
            this.Tickets.Text = "Cobro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de ticket";
            // 
            // txt_numeroDeTicket
            // 
            this.txt_numeroDeTicket.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_numeroDeTicket.DefaultText = "";
            this.txt_numeroDeTicket.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_numeroDeTicket.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_numeroDeTicket.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_numeroDeTicket.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_numeroDeTicket.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_numeroDeTicket.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_numeroDeTicket.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_numeroDeTicket.Location = new System.Drawing.Point(319, 28);
            this.txt_numeroDeTicket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_numeroDeTicket.Name = "txt_numeroDeTicket";
            this.txt_numeroDeTicket.PasswordChar = '\0';
            this.txt_numeroDeTicket.PlaceholderText = "";
            this.txt_numeroDeTicket.SelectedText = "";
            this.txt_numeroDeTicket.Size = new System.Drawing.Size(272, 39);
            this.txt_numeroDeTicket.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 29);
            this.label2.TabIndex = 20;
            this.label2.Text = "Presenta Ticket";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 29);
            this.label6.TabIndex = 21;
            this.label6.Text = "sellado en tienda";
            // 
            // checkBoxSellado
            // 
            this.checkBoxSellado.AutoSize = true;
            this.checkBoxSellado.Location = new System.Drawing.Point(304, 286);
            this.checkBoxSellado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxSellado.Name = "checkBoxSellado";
            this.checkBoxSellado.Size = new System.Drawing.Size(18, 17);
            this.checkBoxSellado.TabIndex = 22;
            this.checkBoxSellado.UseVisualStyleBackColor = true;
            // 
            // btnObtenerTicket
            // 
            this.btnObtenerTicket.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnObtenerTicket.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnObtenerTicket.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnObtenerTicket.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnObtenerTicket.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnObtenerTicket.ForeColor = System.Drawing.Color.White;
            this.btnObtenerTicket.Location = new System.Drawing.Point(640, 21);
            this.btnObtenerTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnObtenerTicket.Name = "btnObtenerTicket";
            this.btnObtenerTicket.Size = new System.Drawing.Size(180, 46);
            this.btnObtenerTicket.TabIndex = 15;
            this.btnObtenerTicket.Text = "Obtener Ticket";
            this.btnObtenerTicket.Click += new System.EventHandler(this.btnObtenerTicket_Click);
            // 
            // btnPagado
            // 
            this.btnPagado.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPagado.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPagado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPagado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPagado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPagado.ForeColor = System.Drawing.Color.White;
            this.btnPagado.Location = new System.Drawing.Point(589, 545);
            this.btnPagado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPagado.Name = "btnPagado";
            this.btnPagado.Size = new System.Drawing.Size(180, 46);
            this.btnPagado.TabIndex = 23;
            this.btnPagado.Text = "Pagado";
            this.btnPagado.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 29);
            this.label3.TabIndex = 24;
            this.label3.Text = "Total a pagar: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTipoDeCobro);
            this.groupBox1.Controls.Add(this.lblDescuentoAplicado);
            this.groupBox1.Controls.Add(this.lblTipoDeVehiculo);
            this.groupBox1.Controls.Add(this.lblHoraDeSalida);
            this.groupBox1.Controls.Add(this.btn_verMas);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.lblHoraDeEntrada);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnCalculaCobro);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnObtenerTicket);
            this.groupBox1.Controls.Add(this.checkBoxSellado);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_numeroDeTicket);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(219, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(912, 479);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // lblTipoDeCobro
            // 
            this.lblTipoDeCobro.AutoSize = true;
            this.lblTipoDeCobro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDeCobro.Location = new System.Drawing.Point(204, 222);
            this.lblTipoDeCobro.Name = "lblTipoDeCobro";
            this.lblTipoDeCobro.Size = new System.Drawing.Size(23, 18);
            this.lblTipoDeCobro.TabIndex = 45;
            this.lblTipoDeCobro.Text = "...";
            // 
            // lblDescuentoAplicado
            // 
            this.lblDescuentoAplicado.AutoSize = true;
            this.lblDescuentoAplicado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuentoAplicado.Location = new System.Drawing.Point(204, 192);
            this.lblDescuentoAplicado.Name = "lblDescuentoAplicado";
            this.lblDescuentoAplicado.Size = new System.Drawing.Size(23, 18);
            this.lblDescuentoAplicado.TabIndex = 44;
            this.lblDescuentoAplicado.Text = "...";
            // 
            // lblTipoDeVehiculo
            // 
            this.lblTipoDeVehiculo.AutoSize = true;
            this.lblTipoDeVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDeVehiculo.Location = new System.Drawing.Point(204, 165);
            this.lblTipoDeVehiculo.Name = "lblTipoDeVehiculo";
            this.lblTipoDeVehiculo.Size = new System.Drawing.Size(23, 18);
            this.lblTipoDeVehiculo.TabIndex = 43;
            this.lblTipoDeVehiculo.Text = "...";
            // 
            // lblHoraDeSalida
            // 
            this.lblHoraDeSalida.AutoSize = true;
            this.lblHoraDeSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraDeSalida.Location = new System.Drawing.Point(204, 134);
            this.lblHoraDeSalida.Name = "lblHoraDeSalida";
            this.lblHoraDeSalida.Size = new System.Drawing.Size(23, 18);
            this.lblHoraDeSalida.TabIndex = 42;
            this.lblHoraDeSalida.Text = "...";
            // 
            // btn_verMas
            // 
            this.btn_verMas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_verMas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_verMas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_verMas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_verMas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_verMas.ForeColor = System.Drawing.Color.White;
            this.btn_verMas.Location = new System.Drawing.Point(371, 215);
            this.btn_verMas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_verMas.Name = "btn_verMas";
            this.btn_verMas.Size = new System.Drawing.Size(127, 25);
            this.btn_verMas.TabIndex = 41;
            this.btn_verMas.Text = "Ver mas...";
            this.btn_verMas.Click += new System.EventHandler(this.btn_verMas_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(44, 220);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 16);
            this.label16.TabIndex = 38;
            this.label16.Text = "Tipo de cobro";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(44, 134);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 16);
            this.label15.TabIndex = 37;
            this.label15.Text = "Hora de salida:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(68, 335);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(141, 16);
            this.label14.TabIndex = 36;
            this.label14.Text = "(Descuento 10% extra)";
            // 
            // lblHoraDeEntrada
            // 
            this.lblHoraDeEntrada.AutoSize = true;
            this.lblHoraDeEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraDeEntrada.Location = new System.Drawing.Point(204, 108);
            this.lblHoraDeEntrada.Name = "lblHoraDeEntrada";
            this.lblHoraDeEntrada.Size = new System.Drawing.Size(23, 18);
            this.lblHoraDeEntrada.TabIndex = 32;
            this.lblHoraDeEntrada.Text = "...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 16);
            this.label9.TabIndex = 31;
            this.label9.Text = "Descuento aplicado:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 16);
            this.label8.TabIndex = 30;
            this.label8.Text = "Tipo de Vehiculo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Hora de entrada:";
            // 
            // btnCalculaCobro
            // 
            this.btnCalculaCobro.DisabledState.BorderColor = System.Drawing.Color.PowderBlue;
            this.btnCalculaCobro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCalculaCobro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCalculaCobro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCalculaCobro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCalculaCobro.ForeColor = System.Drawing.Color.White;
            this.btnCalculaCobro.Location = new System.Drawing.Point(371, 353);
            this.btnCalculaCobro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalculaCobro.Name = "btnCalculaCobro";
            this.btnCalculaCobro.Size = new System.Drawing.Size(180, 46);
            this.btnCalculaCobro.TabIndex = 27;
            this.btnCalculaCobro.Text = "Calcula cobro";
            this.btnCalculaCobro.Click += new System.EventHandler(this.btnCalculaCobro_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(299, 417);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(77, 29);
            this.lblTotal.TabIndex = 26;
            this.lblTotal.Text = "$ 0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(444, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "Hora de salida";
            // 
            // UC_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Tickets);
            this.Controls.Add(this.btnPagado);
            this.Controls.Add(this.label7);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_Inicio";
            this.Size = new System.Drawing.Size(1388, 620);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Tickets;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_numeroDeTicket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxSellado;
        private Guna.UI2.WinForms.Guna2Button btnObtenerTicket;
        private Guna.UI2.WinForms.Guna2Button btnPagado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblHoraDeEntrada;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnCalculaCobro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2Button btn_verMas;
        private System.Windows.Forms.Label lblTipoDeCobro;
        private System.Windows.Forms.Label lblDescuentoAplicado;
        private System.Windows.Forms.Label lblTipoDeVehiculo;
        private System.Windows.Forms.Label lblHoraDeSalida;
    }
}
