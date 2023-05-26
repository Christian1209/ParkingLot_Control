namespace Estacionamiento
{
    partial class Ayuda_Login
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
            this.label1_Ayuda_info1 = new System.Windows.Forms.Label();
            this.label1_Ayuda_info2 = new System.Windows.Forms.Label();
            this.button_Ayuda_Correo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1_Ayuda_info1
            // 
            this.label1_Ayuda_info1.AutoSize = true;
            this.label1_Ayuda_info1.Location = new System.Drawing.Point(12, 33);
            this.label1_Ayuda_info1.Name = "label1_Ayuda_info1";
            this.label1_Ayuda_info1.Size = new System.Drawing.Size(281, 13);
            this.label1_Ayuda_info1.TabIndex = 0;
            this.label1_Ayuda_info1.Text = "Puedes mandar un correo a estacionateoficial@gmail.com";
            this.label1_Ayuda_info1.Click += new System.EventHandler(this.label1_Ayuda_info1_Click);
            // 
            // label1_Ayuda_info2
            // 
            this.label1_Ayuda_info2.AutoSize = true;
            this.label1_Ayuda_info2.Location = new System.Drawing.Point(60, 60);
            this.label1_Ayuda_info2.Name = "label1_Ayuda_info2";
            this.label1_Ayuda_info2.Size = new System.Drawing.Size(182, 13);
            this.label1_Ayuda_info2.TabIndex = 1;
            this.label1_Ayuda_info2.Text = "O mandar un mensaje a 3329566760";
            this.label1_Ayuda_info2.Click += new System.EventHandler(this.label1_Ayuda_info2_Click);
            // 
            // button_Ayuda_Correo
            // 
            this.button_Ayuda_Correo.Location = new System.Drawing.Point(87, 91);
            this.button_Ayuda_Correo.Name = "button_Ayuda_Correo";
            this.button_Ayuda_Correo.Size = new System.Drawing.Size(140, 23);
            this.button_Ayuda_Correo.TabIndex = 2;
            this.button_Ayuda_Correo.Text = "Enviar Correo";
            this.button_Ayuda_Correo.UseVisualStyleBackColor = true;
            this.button_Ayuda_Correo.Click += new System.EventHandler(this.button_Ayuda_Correo_Click);
            // 
            // Ayuda_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 149);
            this.Controls.Add(this.button_Ayuda_Correo);
            this.Controls.Add(this.label1_Ayuda_info2);
            this.Controls.Add(this.label1_Ayuda_info1);
            this.Name = "Ayuda_Login";
            this.Text = "Ayuda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_Ayuda_info1;
        private System.Windows.Forms.Label label1_Ayuda_info2;
        private System.Windows.Forms.Button button_Ayuda_Correo;
    }
}