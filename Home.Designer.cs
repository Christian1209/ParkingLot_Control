namespace Estacionamiento
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.btn_inicio = new Guna.UI2.WinForms.Guna2Button();
            this.panelUno = new System.Windows.Forms.Panel();
            this.btn_admin = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.btn_mapa = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.elipse_home = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_empleado = new System.Windows.Forms.Label();
            this.time_picker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.icon_user = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btn_close = new Guna.UI2.WinForms.Guna2ControlBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelUno.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_user)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_inicio
            // 
            this.btn_inicio.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_inicio.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_inicio.CheckedState.CustomBorderColor = System.Drawing.Color.Navy;
            this.btn_inicio.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btn_inicio.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_inicio.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_inicio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_inicio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_inicio.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btn_inicio.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inicio.ForeColor = System.Drawing.Color.Black;
            this.btn_inicio.HoverState.CustomBorderColor = System.Drawing.Color.Navy;
            this.btn_inicio.Location = new System.Drawing.Point(0, 127);
            this.btn_inicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.PressedColor = System.Drawing.Color.Transparent;
            this.btn_inicio.Size = new System.Drawing.Size(236, 46);
            this.btn_inicio.TabIndex = 2;
            this.btn_inicio.Text = "COBRO";
            this.btn_inicio.Click += new System.EventHandler(this.inicioButton_Click);
            // 
            // panelUno
            // 
            this.panelUno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelUno.Controls.Add(this.btn_admin);
            this.panelUno.Controls.Add(this.guna2Button5);
            this.panelUno.Controls.Add(this.guna2Button6);
            this.panelUno.Controls.Add(this.guna2Button3);
            this.panelUno.Controls.Add(this.btn_mapa);
            this.panelUno.Controls.Add(this.btn_inicio);
            this.panelUno.Location = new System.Drawing.Point(3, 134);
            this.panelUno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelUno.Name = "panelUno";
            this.panelUno.Size = new System.Drawing.Size(243, 646);
            this.panelUno.TabIndex = 3;
            // 
            // btn_admin
            // 
            this.btn_admin.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_admin.CheckedState.CustomBorderColor = System.Drawing.Color.Navy;
            this.btn_admin.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btn_admin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_admin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_admin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_admin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_admin.FillColor = System.Drawing.Color.LightBlue;
            this.btn_admin.Font = new System.Drawing.Font("MS PGothic", 12F);
            this.btn_admin.ForeColor = System.Drawing.Color.Black;
            this.btn_admin.HoverState.CustomBorderColor = System.Drawing.Color.Navy;
            this.btn_admin.Location = new System.Drawing.Point(1, 227);
            this.btn_admin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(236, 46);
            this.btn_admin.TabIndex = 11;
            this.btn_admin.Text = "Administración (Gastos/Egresos)";
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // guna2Button5
            // 
            this.guna2Button5.BackColor = System.Drawing.Color.RoyalBlue;
            this.guna2Button5.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button5.CheckedState.CustomBorderColor = System.Drawing.Color.Navy;
            this.guna2Button5.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.Color.LightSkyBlue;
            this.guna2Button5.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button5.ForeColor = System.Drawing.Color.Black;
            this.guna2Button5.HoverState.CustomBorderColor = System.Drawing.Color.Navy;
            this.guna2Button5.Location = new System.Drawing.Point(0, 76);
            this.guna2Button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.PressedColor = System.Drawing.Color.Transparent;
            this.guna2Button5.Size = new System.Drawing.Size(236, 46);
            this.guna2Button5.TabIndex = 10;
            this.guna2Button5.Text = "Tickets";
            this.guna2Button5.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // guna2Button6
            // 
            this.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Button6.Font = new System.Drawing.Font("MS PGothic", 12F);
            this.guna2Button6.ForeColor = System.Drawing.Color.Black;
            this.guna2Button6.Location = new System.Drawing.Point(4, 597);
            this.guna2Button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.Size = new System.Drawing.Size(236, 38);
            this.guna2Button6.TabIndex = 7;
            this.guna2Button6.Text = "Cerrar Sesión";
            this.guna2Button6.Click += new System.EventHandler(this.guna2Button6_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.LightGray;
            this.guna2Button3.Font = new System.Drawing.Font("MS PGothic", 12F);
            this.guna2Button3.ForeColor = System.Drawing.Color.Black;
            this.guna2Button3.Location = new System.Drawing.Point(3, 554);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(236, 38);
            this.guna2Button3.TabIndex = 4;
            this.guna2Button3.Text = "Ayuda";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // btn_mapa
            // 
            this.btn_mapa.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_mapa.CheckedState.CustomBorderColor = System.Drawing.Color.Navy;
            this.btn_mapa.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btn_mapa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_mapa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_mapa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_mapa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_mapa.FillColor = System.Drawing.Color.LightBlue;
            this.btn_mapa.Font = new System.Drawing.Font("MS PGothic", 12F);
            this.btn_mapa.ForeColor = System.Drawing.Color.Black;
            this.btn_mapa.HoverState.CustomBorderColor = System.Drawing.Color.Navy;
            this.btn_mapa.Location = new System.Drawing.Point(0, 177);
            this.btn_mapa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_mapa.Name = "btn_mapa";
            this.btn_mapa.Size = new System.Drawing.Size(236, 46);
            this.btn_mapa.TabIndex = 3;
            this.btn_mapa.Text = "Mapa";
            this.btn_mapa.Click += new System.EventHandler(this.btn_mapa_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Location = new System.Drawing.Point(0, 491);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(236, 45);
            this.guna2Button4.TabIndex = 5;
            this.guna2Button4.Text = "Ayuda";
            // 
            // elipse_home
            // 
            this.elipse_home.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Controls.Add(this.lbl_time);
            this.guna2Panel1.Controls.Add(this.lbl_empleado);
            this.guna2Panel1.Controls.Add(this.time_picker);
            this.guna2Panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.guna2Panel1.Controls.Add(this.icon_user);
            this.guna2Panel1.Controls.Add(this.btn_close);
            this.guna2Panel1.Location = new System.Drawing.Point(5, 7);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1571, 121);
            this.guna2Panel1.TabIndex = 5;
            this.guna2Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2Panel1_MouseDown);
            this.guna2Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.guna2Panel1_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1341, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 56);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("MS PGothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.Location = new System.Drawing.Point(1092, 47);
            this.lbl_time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(56, 34);
            this.lbl_time.TabIndex = 11;
            this.lbl_time.Text = "0:0";
            // 
            // lbl_empleado
            // 
            this.lbl_empleado.AutoSize = true;
            this.lbl_empleado.Font = new System.Drawing.Font("MS PGothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empleado.Location = new System.Drawing.Point(341, 64);
            this.lbl_empleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_empleado.Name = "lbl_empleado";
            this.lbl_empleado.Size = new System.Drawing.Size(150, 34);
            this.lbl_empleado.TabIndex = 10;
            this.lbl_empleado.Text = "Empleado";
            this.lbl_empleado.Click += new System.EventHandler(this.lbl_empleado_Click);
            // 
            // time_picker
            // 
            this.time_picker.Checked = true;
            this.time_picker.Enabled = false;
            this.time_picker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.time_picker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.time_picker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.time_picker.Location = new System.Drawing.Point(1099, 7);
            this.time_picker.Margin = new System.Windows.Forms.Padding(4);
            this.time_picker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.time_picker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.time_picker.Name = "time_picker";
            this.time_picker.ShowUpDown = true;
            this.time_picker.Size = new System.Drawing.Size(271, 36);
            this.time_picker.TabIndex = 9;
            this.time_picker.Value = new System.DateTime(2023, 5, 2, 19, 13, 36, 968);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::Estacionamiento.Properties.Resources.logo;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(55, 1);
            this.guna2CirclePictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(131, 116);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 8;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.UseTransparentBackground = true;
            // 
            // icon_user
            // 
            this.icon_user.BackColor = System.Drawing.Color.Transparent;
            this.icon_user.Image = global::Estacionamiento.Properties.Resources.user;
            this.icon_user.ImageRotate = 0F;
            this.icon_user.Location = new System.Drawing.Point(248, 18);
            this.icon_user.Margin = new System.Windows.Forms.Padding(4);
            this.icon_user.Name = "icon_user";
            this.icon_user.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.icon_user.Size = new System.Drawing.Size(85, 79);
            this.icon_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon_user.TabIndex = 7;
            this.icon_user.TabStop = false;
            this.icon_user.UseTransparentBackground = true;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_close.IconColor = System.Drawing.Color.Cyan;
            this.btn_close.Location = new System.Drawing.Point(1466, 7);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(60, 36);
            this.btn_close.TabIndex = 6;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelContainer.Location = new System.Drawing.Point(253, 134);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1323, 645);
            this.panelContainer.TabIndex = 4;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(110)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(1611, 783);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelUno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Home_MouseDown_1);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Home_MouseMove);
            this.panelUno.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_user)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btn_inicio;
        private System.Windows.Forms.Panel panelUno;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button btn_mapa;
        private Guna.UI2.WinForms.Guna2Elipse elipse_home;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox icon_user;
        private Guna.UI2.WinForms.Guna2ControlBox btn_close;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2DateTimePicker time_picker;
        private System.Windows.Forms.Label lbl_empleado;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private System.Windows.Forms.Panel panelContainer;
        private Guna.UI2.WinForms.Guna2Button btn_admin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}