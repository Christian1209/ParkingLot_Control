namespace Estacionamiento
{
    partial class Ayuda_Home
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
            this.button_Ayuda_Correo = new System.Windows.Forms.Button();
            this.label1_Ayuda_info2 = new System.Windows.Forms.Label();
            this.label1_Ayuda_info1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Ayuda_Correo
            // 
            this.button_Ayuda_Correo.Location = new System.Drawing.Point(112, 181);
            this.button_Ayuda_Correo.Name = "button_Ayuda_Correo";
            this.button_Ayuda_Correo.Size = new System.Drawing.Size(140, 23);
            this.button_Ayuda_Correo.TabIndex = 5;
            this.button_Ayuda_Correo.Text = "Enviar Correo";
            this.button_Ayuda_Correo.UseVisualStyleBackColor = true;
            this.button_Ayuda_Correo.Click += new System.EventHandler(this.button_Ayuda_Correo_Click_1);
            // 
            // label1_Ayuda_info2
            // 
            this.label1_Ayuda_info2.AutoSize = true;
            this.label1_Ayuda_info2.Location = new System.Drawing.Point(91, 153);
            this.label1_Ayuda_info2.Name = "label1_Ayuda_info2";
            this.label1_Ayuda_info2.Size = new System.Drawing.Size(182, 13);
            this.label1_Ayuda_info2.TabIndex = 4;
            this.label1_Ayuda_info2.Text = "O mandar un mensaje a 3329566760";
            // 
            // label1_Ayuda_info1
            // 
            this.label1_Ayuda_info1.AutoSize = true;
            this.label1_Ayuda_info1.Location = new System.Drawing.Point(43, 127);
            this.label1_Ayuda_info1.Name = "label1_Ayuda_info1";
            this.label1_Ayuda_info1.Size = new System.Drawing.Size(281, 13);
            this.label1_Ayuda_info1.TabIndex = 3;
            this.label1_Ayuda_info1.Text = "Puedes mandar un correo a estacionateoficial@gmail.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "¿Problemas con el programa?";
            // 
            // Ayuda_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 244);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Ayuda_Correo);
            this.Controls.Add(this.label1_Ayuda_info2);
            this.Controls.Add(this.label1_Ayuda_info1);
            this.Name = "Ayuda_Home";
            this.Text = "Ayuda_Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Ayuda_Correo;
        private System.Windows.Forms.Label label1_Ayuda_info2;
        private System.Windows.Forms.Label label1_Ayuda_info1;
        private System.Windows.Forms.Label label1;
    }
}