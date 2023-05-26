namespace Estacionamiento.UserControls
{
    partial class UC_Ticket
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
            this.Tickets = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxPension = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_na = new Guna.UI2.WinForms.Guna2RadioButton();
            this.btn_dis_terc = new Guna.UI2.WinForms.Guna2RadioButton();
            this.btn_cliente_frec = new Guna.UI2.WinForms.Guna2RadioButton();
            this.txt_placas = new Guna.UI2.WinForms.Guna2TextBox();
            this.color_vehiculo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.marca_vehiculo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tipo_vehiculo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGeneraTicket = new Guna.UI2.WinForms.Guna2Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblLugaresDisponibles = new System.Windows.Forms.Label();
            this.lblLugaresDisponiblesDiscapacitados = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblLugaresDisponiblesCliente = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblLugarAsignado = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tickets
            // 
            this.Tickets.AutoSize = true;
            this.Tickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tickets.Location = new System.Drawing.Point(623, 12);
            this.Tickets.Name = "Tickets";
            this.Tickets.Size = new System.Drawing.Size(297, 46);
            this.Tickets.TabIndex = 0;
            this.Tickets.Text = "Generar Ticket";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxPension);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txt_placas);
            this.groupBox1.Controls.Add(this.color_vehiculo);
            this.groupBox1.Controls.Add(this.marca_vehiculo);
            this.groupBox1.Controls.Add(this.tipo_vehiculo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(350, 60);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(925, 495);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // checkBoxPension
            // 
            this.checkBoxPension.AutoSize = true;
            this.checkBoxPension.Location = new System.Drawing.Point(324, 284);
            this.checkBoxPension.Name = "checkBoxPension";
            this.checkBoxPension.Size = new System.Drawing.Size(18, 17);
            this.checkBoxPension.TabIndex = 21;
            this.checkBoxPension.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 29);
            this.label6.TabIndex = 20;
            this.label6.Text = "Pensión";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(46, 435);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 29);
            this.label10.TabIndex = 19;
            this.label10.Text = "NA";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.btn_na);
            this.groupBox2.Controls.Add(this.btn_dis_terc);
            this.groupBox2.Controls.Add(this.btn_cliente_frec);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Location = new System.Drawing.Point(425, 325);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(75, 140);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // btn_na
            // 
            this.btn_na.AutoSize = true;
            this.btn_na.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_na.CheckedState.BorderThickness = 0;
            this.btn_na.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_na.CheckedState.InnerColor = System.Drawing.Color.White;
            this.btn_na.CheckedState.InnerOffset = -4;
            this.btn_na.Location = new System.Drawing.Point(29, 110);
            this.btn_na.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_na.Name = "btn_na";
            this.btn_na.Size = new System.Drawing.Size(17, 16);
            this.btn_na.TabIndex = 15;
            this.btn_na.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.btn_na.UncheckedState.BorderThickness = 2;
            this.btn_na.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btn_na.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // btn_dis_terc
            // 
            this.btn_dis_terc.AutoSize = true;
            this.btn_dis_terc.BackColor = System.Drawing.SystemColors.Control;
            this.btn_dis_terc.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_dis_terc.CheckedState.BorderThickness = 0;
            this.btn_dis_terc.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_dis_terc.CheckedState.InnerColor = System.Drawing.Color.White;
            this.btn_dis_terc.CheckedState.InnerOffset = -4;
            this.btn_dis_terc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_dis_terc.Location = new System.Drawing.Point(29, 21);
            this.btn_dis_terc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_dis_terc.Name = "btn_dis_terc";
            this.btn_dis_terc.Size = new System.Drawing.Size(17, 16);
            this.btn_dis_terc.TabIndex = 13;
            this.btn_dis_terc.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.btn_dis_terc.UncheckedState.BorderThickness = 2;
            this.btn_dis_terc.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btn_dis_terc.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.btn_dis_terc.UseVisualStyleBackColor = false;
            // 
            // btn_cliente_frec
            // 
            this.btn_cliente_frec.AutoSize = true;
            this.btn_cliente_frec.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_cliente_frec.CheckedState.BorderThickness = 0;
            this.btn_cliente_frec.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_cliente_frec.CheckedState.InnerColor = System.Drawing.Color.White;
            this.btn_cliente_frec.CheckedState.InnerOffset = -4;
            this.btn_cliente_frec.Location = new System.Drawing.Point(29, 60);
            this.btn_cliente_frec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cliente_frec.Name = "btn_cliente_frec";
            this.btn_cliente_frec.Size = new System.Drawing.Size(17, 16);
            this.btn_cliente_frec.TabIndex = 14;
            this.btn_cliente_frec.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.btn_cliente_frec.UncheckedState.BorderThickness = 2;
            this.btn_cliente_frec.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btn_cliente_frec.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // txt_placas
            // 
            this.txt_placas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_placas.DefaultText = "";
            this.txt_placas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_placas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_placas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_placas.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_placas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_placas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_placas.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_placas.Location = new System.Drawing.Point(324, 31);
            this.txt_placas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_placas.Name = "txt_placas";
            this.txt_placas.PasswordChar = '\0';
            this.txt_placas.PlaceholderText = "###1111";
            this.txt_placas.SelectedText = "";
            this.txt_placas.Size = new System.Drawing.Size(272, 39);
            this.txt_placas.TabIndex = 17;
            // 
            // color_vehiculo
            // 
            this.color_vehiculo.BackColor = System.Drawing.Color.Transparent;
            this.color_vehiculo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.color_vehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.color_vehiculo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.color_vehiculo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.color_vehiculo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.color_vehiculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.color_vehiculo.ItemHeight = 30;
            this.color_vehiculo.Items.AddRange(new object[] {
            "Rojo",
            "Naranja",
            "Amarillo",
            "Verde",
            "Azul",
            "Morado o violeta",
            "Blanco",
            "Negro",
            "Gris"});
            this.color_vehiculo.Location = new System.Drawing.Point(324, 219);
            this.color_vehiculo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.color_vehiculo.Name = "color_vehiculo";
            this.color_vehiculo.Size = new System.Drawing.Size(272, 36);
            this.color_vehiculo.TabIndex = 9;
            // 
            // marca_vehiculo
            // 
            this.marca_vehiculo.BackColor = System.Drawing.Color.Transparent;
            this.marca_vehiculo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.marca_vehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.marca_vehiculo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.marca_vehiculo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.marca_vehiculo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.marca_vehiculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.marca_vehiculo.ItemHeight = 30;
            this.marca_vehiculo.Location = new System.Drawing.Point(324, 151);
            this.marca_vehiculo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.marca_vehiculo.Name = "marca_vehiculo";
            this.marca_vehiculo.Size = new System.Drawing.Size(272, 36);
            this.marca_vehiculo.TabIndex = 8;
            // 
            // tipo_vehiculo
            // 
            this.tipo_vehiculo.BackColor = System.Drawing.Color.Transparent;
            this.tipo_vehiculo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.tipo_vehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipo_vehiculo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tipo_vehiculo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tipo_vehiculo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tipo_vehiculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.tipo_vehiculo.ItemHeight = 30;
            this.tipo_vehiculo.Items.AddRange(new object[] {
            "Carro",
            "Moto",
            "Camioneta"});
            this.tipo_vehiculo.Location = new System.Drawing.Point(324, 93);
            this.tipo_vehiculo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tipo_vehiculo.Name = "tipo_vehiculo";
            this.tipo_vehiculo.Size = new System.Drawing.Size(272, 36);
            this.tipo_vehiculo.TabIndex = 7;
            this.tipo_vehiculo.SelectedIndexChanged += new System.EventHandler(this.tipo_vehiculo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cliente Frecuente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(314, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Discapacidad/Tercera Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de vehiculo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placas";
            // 
            // btnGeneraTicket
            // 
            this.btnGeneraTicket.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGeneraTicket.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGeneraTicket.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGeneraTicket.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGeneraTicket.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGeneraTicket.ForeColor = System.Drawing.Color.White;
            this.btnGeneraTicket.Location = new System.Drawing.Point(714, 559);
            this.btnGeneraTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGeneraTicket.Name = "btnGeneraTicket";
            this.btnGeneraTicket.Size = new System.Drawing.Size(180, 46);
            this.btnGeneraTicket.TabIndex = 2;
            this.btnGeneraTicket.Text = "Genera Ticket";
            this.btnGeneraTicket.Click += new System.EventHandler(this.btnGeneraTicket_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(240, 29);
            this.label9.TabIndex = 3;
            this.label9.Text = "Lugares Disponibles:";
            // 
            // lblLugaresDisponibles
            // 
            this.lblLugaresDisponibles.AutoSize = true;
            this.lblLugaresDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLugaresDisponibles.Location = new System.Drawing.Point(273, 81);
            this.lblLugaresDisponibles.Name = "lblLugaresDisponibles";
            this.lblLugaresDisponibles.Size = new System.Drawing.Size(26, 29);
            this.lblLugaresDisponibles.TabIndex = 4;
            this.lblLugaresDisponibles.Text = "0";
            // 
            // lblLugaresDisponiblesDiscapacitados
            // 
            this.lblLugaresDisponiblesDiscapacitados.AutoSize = true;
            this.lblLugaresDisponiblesDiscapacitados.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLugaresDisponiblesDiscapacitados.Location = new System.Drawing.Point(273, 261);
            this.lblLugaresDisponiblesDiscapacitados.Name = "lblLugaresDisponiblesDiscapacitados";
            this.lblLugaresDisponiblesDiscapacitados.Size = new System.Drawing.Size(26, 29);
            this.lblLugaresDisponiblesDiscapacitados.TabIndex = 6;
            this.lblLugaresDisponiblesDiscapacitados.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(29, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(240, 29);
            this.label11.TabIndex = 5;
            this.label11.Text = "Lugares Disponibles:";
            // 
            // lblLugaresDisponiblesCliente
            // 
            this.lblLugaresDisponiblesCliente.AutoSize = true;
            this.lblLugaresDisponiblesCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLugaresDisponiblesCliente.Location = new System.Drawing.Point(273, 153);
            this.lblLugaresDisponiblesCliente.Name = "lblLugaresDisponiblesCliente";
            this.lblLugaresDisponiblesCliente.Size = new System.Drawing.Size(26, 29);
            this.lblLugaresDisponiblesCliente.TabIndex = 8;
            this.lblLugaresDisponiblesCliente.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(27, 263);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(240, 29);
            this.label13.TabIndex = 7;
            this.label13.Text = "Lugares Disponibles:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(28, 181);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(204, 31);
            this.label14.TabIndex = 9;
            this.label14.Text = "(Cliente frecuente)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(27, 293);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(177, 31);
            this.label15.TabIndex = 10;
            this.label15.Text = "(Discapacitado)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(997, 559);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(168, 25);
            this.label12.TabIndex = 11;
            this.label12.Text = "Lugar asignado:";
            this.label12.Visible = false;
            // 
            // lblLugarAsignado
            // 
            this.lblLugarAsignado.AutoSize = true;
            this.lblLugarAsignado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLugarAsignado.Location = new System.Drawing.Point(1184, 559);
            this.lblLugarAsignado.Name = "lblLugarAsignado";
            this.lblLugarAsignado.Size = new System.Drawing.Size(24, 25);
            this.lblLugarAsignado.TabIndex = 12;
            this.lblLugarAsignado.Text = "0";
            this.lblLugarAsignado.Visible = false;
            // 
            // UC_Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblLugarAsignado);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblLugaresDisponiblesCliente);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblLugaresDisponiblesDiscapacitados);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblLugaresDisponibles);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnGeneraTicket);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Tickets);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_Ticket";
            this.Size = new System.Drawing.Size(1381, 618);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Tickets;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_placas;
        private Guna.UI2.WinForms.Guna2RadioButton btn_cliente_frec;
        private Guna.UI2.WinForms.Guna2RadioButton btn_dis_terc;
        private Guna.UI2.WinForms.Guna2ComboBox color_vehiculo;
        private Guna.UI2.WinForms.Guna2ComboBox marca_vehiculo;
        private Guna.UI2.WinForms.Guna2ComboBox tipo_vehiculo;
        private Guna.UI2.WinForms.Guna2Button btnGeneraTicket;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblLugaresDisponibles;
        private System.Windows.Forms.Label lblLugaresDisponiblesDiscapacitados;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblLugaresDisponiblesCliente;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2RadioButton btn_na;
        private System.Windows.Forms.CheckBox checkBoxPension;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblLugarAsignado;
    }
}
