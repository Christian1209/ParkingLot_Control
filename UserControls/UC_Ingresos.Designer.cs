namespace Estacionamiento.UserControls
{
    partial class UC_Ingresos
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
            this.btIngresosHoy = new Guna.UI2.WinForms.Guna2Button();
            this.Tickets = new System.Windows.Forms.Label();
            this.btnIngresosMes = new Guna.UI2.WinForms.Guna2Button();
            this.btnEstadisticas = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIngresarGasto = new Guna.UI2.WinForms.Guna2Button();
            this.txtBoxCostoGasto = new System.Windows.Forms.TextBox();
            this.txtBoxNombreGasto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btIngresosHoy
            // 
            this.btIngresosHoy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btIngresosHoy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btIngresosHoy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btIngresosHoy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btIngresosHoy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btIngresosHoy.ForeColor = System.Drawing.Color.White;
            this.btIngresosHoy.Location = new System.Drawing.Point(127, 179);
            this.btIngresosHoy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btIngresosHoy.Name = "btIngresosHoy";
            this.btIngresosHoy.Size = new System.Drawing.Size(180, 46);
            this.btIngresosHoy.TabIndex = 24;
            this.btIngresosHoy.Text = "Ver ingresos (Hoy)";
            this.btIngresosHoy.Click += new System.EventHandler(this.btIngresosHoy_Click);
            // 
            // Tickets
            // 
            this.Tickets.AutoSize = true;
            this.Tickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tickets.Location = new System.Drawing.Point(6, 60);
            this.Tickets.Name = "Tickets";
            this.Tickets.Size = new System.Drawing.Size(365, 36);
            this.Tickets.TabIndex = 25;
            this.Tickets.Text = "Información de ingresos.";
            // 
            // btnIngresosMes
            // 
            this.btnIngresosMes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIngresosMes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIngresosMes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIngresosMes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIngresosMes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnIngresosMes.ForeColor = System.Drawing.Color.White;
            this.btnIngresosMes.Location = new System.Drawing.Point(127, 256);
            this.btnIngresosMes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIngresosMes.Name = "btnIngresosMes";
            this.btnIngresosMes.Size = new System.Drawing.Size(180, 46);
            this.btnIngresosMes.TabIndex = 26;
            this.btnIngresosMes.Text = "Ver ingresos (Este mes)";
            this.btnIngresosMes.Click += new System.EventHandler(this.btnIngresosMes_Click);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEstadisticas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEstadisticas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEstadisticas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEstadisticas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEstadisticas.ForeColor = System.Drawing.Color.White;
            this.btnEstadisticas.Location = new System.Drawing.Point(127, 341);
            this.btnEstadisticas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(180, 46);
            this.btnEstadisticas.TabIndex = 27;
            this.btnEstadisticas.Text = "Estadisticas por hora.";
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btIngresosHoy);
            this.groupBox1.Controls.Add(this.btnIngresosMes);
            this.groupBox1.Controls.Add(this.Tickets);
            this.groupBox1.Controls.Add(this.btnEstadisticas);
            this.groupBox1.Location = new System.Drawing.Point(742, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 459);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnIngresarGasto);
            this.groupBox2.Controls.Add(this.txtBoxCostoGasto);
            this.groupBox2.Controls.Add(this.txtBoxNombreGasto);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(186, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(443, 459);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "(en pesos)";
            // 
            // btnIngresarGasto
            // 
            this.btnIngresarGasto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIngresarGasto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIngresarGasto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIngresarGasto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIngresarGasto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnIngresarGasto.ForeColor = System.Drawing.Color.White;
            this.btnIngresarGasto.Location = new System.Drawing.Point(125, 341);
            this.btnIngresarGasto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIngresarGasto.Name = "btnIngresarGasto";
            this.btnIngresarGasto.Size = new System.Drawing.Size(180, 46);
            this.btnIngresarGasto.TabIndex = 28;
            this.btnIngresarGasto.Text = "Ingresar";
            this.btnIngresarGasto.Click += new System.EventHandler(this.btnIngresarGasto_Click);
            // 
            // txtBoxCostoGasto
            // 
            this.txtBoxCostoGasto.Location = new System.Drawing.Point(213, 254);
            this.txtBoxCostoGasto.Name = "txtBoxCostoGasto";
            this.txtBoxCostoGasto.Size = new System.Drawing.Size(171, 22);
            this.txtBoxCostoGasto.TabIndex = 29;
            // 
            // txtBoxNombreGasto
            // 
            this.txtBoxNombreGasto.Location = new System.Drawing.Point(213, 179);
            this.txtBoxNombreGasto.Name = "txtBoxNombreGasto";
            this.txtBoxNombreGasto.Size = new System.Drawing.Size(171, 22);
            this.txtBoxNombreGasto.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Costo del gasto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nombre del gasto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 32);
            this.label1.TabIndex = 25;
            this.label1.Text = "Ingresa Gasto Operacional";
            // 
            // UC_Ingresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_Ingresos";
            this.Size = new System.Drawing.Size(1110, 496);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btIngresosHoy;
        private System.Windows.Forms.Label Tickets;
        private Guna.UI2.WinForms.Guna2Button btnIngresosMes;
        private Guna.UI2.WinForms.Guna2Button btnEstadisticas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnIngresarGasto;
        private System.Windows.Forms.TextBox txtBoxCostoGasto;
        private System.Windows.Forms.TextBox txtBoxNombreGasto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}
