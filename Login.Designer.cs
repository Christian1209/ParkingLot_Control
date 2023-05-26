namespace Estacionamiento
{
    partial class Login
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button_Login_Acceder = new System.Windows.Forms.Button();
            this.button_Login_Ayuda = new System.Windows.Forms.Button();
            this.label_Login_Usuario = new System.Windows.Forms.Label();
            this.label_Login_Contraseña = new System.Windows.Forms.Label();
            this.textBox_Login_Usuario = new System.Windows.Forms.TextBox();
            this.textBox_Login_Contraseña = new System.Windows.Forms.TextBox();
            this.label_Login_Titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // button_Login_Acceder
            // 
            this.button_Login_Acceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Login_Acceder.Location = new System.Drawing.Point(211, 324);
            this.button_Login_Acceder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Login_Acceder.Name = "button_Login_Acceder";
            this.button_Login_Acceder.Size = new System.Drawing.Size(168, 44);
            this.button_Login_Acceder.TabIndex = 1;
            this.button_Login_Acceder.Text = "Acceder";
            this.button_Login_Acceder.UseVisualStyleBackColor = true;
            this.button_Login_Acceder.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Login_Ayuda
            // 
            this.button_Login_Ayuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Login_Ayuda.Location = new System.Drawing.Point(416, 324);
            this.button_Login_Ayuda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Login_Ayuda.Name = "button_Login_Ayuda";
            this.button_Login_Ayuda.Size = new System.Drawing.Size(168, 44);
            this.button_Login_Ayuda.TabIndex = 2;
            this.button_Login_Ayuda.Text = "Ayuda";
            this.button_Login_Ayuda.UseVisualStyleBackColor = true;
            this.button_Login_Ayuda.Click += new System.EventHandler(this.button_Login_Ayuda_Click);
            // 
            // label_Login_Usuario
            // 
            this.label_Login_Usuario.AutoSize = true;
            this.label_Login_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Login_Usuario.Location = new System.Drawing.Point(248, 116);
            this.label_Login_Usuario.MinimumSize = new System.Drawing.Size(100, 30);
            this.label_Login_Usuario.Name = "label_Login_Usuario";
            this.label_Login_Usuario.Size = new System.Drawing.Size(100, 30);
            this.label_Login_Usuario.TabIndex = 3;
            this.label_Login_Usuario.Text = "Usuario";
            // 
            // label_Login_Contraseña
            // 
            this.label_Login_Contraseña.AutoSize = true;
            this.label_Login_Contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Login_Contraseña.Location = new System.Drawing.Point(233, 171);
            this.label_Login_Contraseña.MinimumSize = new System.Drawing.Size(100, 30);
            this.label_Login_Contraseña.Name = "label_Login_Contraseña";
            this.label_Login_Contraseña.Size = new System.Drawing.Size(123, 30);
            this.label_Login_Contraseña.TabIndex = 4;
            this.label_Login_Contraseña.Text = "Contraseña";
            // 
            // textBox_Login_Usuario
            // 
            this.textBox_Login_Usuario.Location = new System.Drawing.Point(385, 116);
            this.textBox_Login_Usuario.MinimumSize = new System.Drawing.Size(150, 30);
            this.textBox_Login_Usuario.Name = "textBox_Login_Usuario";
            this.textBox_Login_Usuario.Size = new System.Drawing.Size(150, 20);
            this.textBox_Login_Usuario.TabIndex = 5;
            this.textBox_Login_Usuario.TextChanged += new System.EventHandler(this.textBox_Login_Usuario_TextChanged);
            // 
            // textBox_Login_Contraseña
            // 
            this.textBox_Login_Contraseña.Location = new System.Drawing.Point(385, 171);
            this.textBox_Login_Contraseña.MinimumSize = new System.Drawing.Size(150, 30);
            this.textBox_Login_Contraseña.Name = "textBox_Login_Contraseña";
            this.textBox_Login_Contraseña.PasswordChar = '*';
            this.textBox_Login_Contraseña.Size = new System.Drawing.Size(150, 20);
            this.textBox_Login_Contraseña.TabIndex = 6;
            // 
            // label_Login_Titulo
            // 
            this.label_Login_Titulo.AutoSize = true;
            this.label_Login_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Login_Titulo.Location = new System.Drawing.Point(287, 37);
            this.label_Login_Titulo.MinimumSize = new System.Drawing.Size(150, 30);
            this.label_Login_Titulo.Name = "label_Login_Titulo";
            this.label_Login_Titulo.Size = new System.Drawing.Size(184, 37);
            this.label_Login_Titulo.TabIndex = 7;
            this.label_Login_Titulo.Text = "Estacionate";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 502);
            this.Controls.Add(this.label_Login_Titulo);
            this.Controls.Add(this.textBox_Login_Contraseña);
            this.Controls.Add(this.textBox_Login_Usuario);
            this.Controls.Add(this.label_Login_Contraseña);
            this.Controls.Add(this.label_Login_Usuario);
            this.Controls.Add(this.button_Login_Ayuda);
            this.Controls.Add(this.button_Login_Acceder);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Login_Acceder;
        private System.Windows.Forms.Button button_Login_Ayuda;
        private System.Windows.Forms.Label label_Login_Usuario;
        private System.Windows.Forms.Label label_Login_Contraseña;
        private System.Windows.Forms.TextBox textBox_Login_Usuario;
        private System.Windows.Forms.TextBox textBox_Login_Contraseña;
        private System.Windows.Forms.Label label_Login_Titulo;
    }
}

