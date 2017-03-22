namespace Proyecto_Escuela.Views
{
    partial class Login
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
            this.usuario = new System.Windows.Forms.TextBox();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.label_1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.Button();
            this.atras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(52, 79);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(174, 20);
            this.usuario.TabIndex = 0;
            // 
            // contraseña
            // 
            this.contraseña.Location = new System.Drawing.Point(52, 128);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(174, 20);
            this.contraseña.TabIndex = 1;
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Location = new System.Drawing.Point(49, 63);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(43, 13);
            this.label_1.TabIndex = 2;
            this.label_1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Constraseña";
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(89, 175);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(97, 25);
            this.log.TabIndex = 4;
            this.log.Text = "LogIn";
            this.log.UseVisualStyleBackColor = true;
            this.log.Click += new System.EventHandler(this.log_Click);
            // 
            // atras
            // 
            this.atras.Location = new System.Drawing.Point(12, 226);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(75, 23);
            this.atras.TabIndex = 5;
            this.atras.Text = "Atras";
            this.atras.UseVisualStyleBackColor = true;
            this.atras.Click += new System.EventHandler(this.atras_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.atras);
            this.Controls.Add(this.log);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_1);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.usuario);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button log;
        private System.Windows.Forms.Button atras;
    }
}