namespace Proyecto_Escuela.Views
{
    partial class Configuracion
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
            this.estudiantes = new System.Windows.Forms.Button();
            this.textos = new System.Windows.Forms.Button();
            this.atras = new System.Windows.Forms.Button();
            this.secuencia = new System.Windows.Forms.Button();
            this.describe = new System.Windows.Forms.Button();
            this.jugadores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // estudiantes
            // 
            this.estudiantes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estudiantes.Location = new System.Drawing.Point(18, 12);
            this.estudiantes.Name = "estudiantes";
            this.estudiantes.Size = new System.Drawing.Size(248, 95);
            this.estudiantes.TabIndex = 0;
            this.estudiantes.Text = "Gestionar Estudiantes";
            this.estudiantes.UseVisualStyleBackColor = true;
            this.estudiantes.Click += new System.EventHandler(this.estudiantes_Click);
            // 
            // textos
            // 
            this.textos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textos.Location = new System.Drawing.Point(18, 127);
            this.textos.Name = "textos";
            this.textos.Size = new System.Drawing.Size(248, 95);
            this.textos.TabIndex = 1;
            this.textos.Text = "Gestionar Textos";
            this.textos.UseVisualStyleBackColor = true;
            this.textos.Click += new System.EventHandler(this.textos_Click);
            // 
            // atras
            // 
            this.atras.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atras.Location = new System.Drawing.Point(313, 390);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(248, 61);
            this.atras.TabIndex = 2;
            this.atras.Text = "Atras";
            this.atras.UseVisualStyleBackColor = true;
            this.atras.Click += new System.EventHandler(this.atras_Click);
            // 
            // secuencia
            // 
            this.secuencia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secuencia.Location = new System.Drawing.Point(313, 127);
            this.secuencia.Name = "secuencia";
            this.secuencia.Size = new System.Drawing.Size(248, 95);
            this.secuencia.TabIndex = 3;
            this.secuencia.Text = "Secuencia de Imagenes";
            this.secuencia.UseVisualStyleBackColor = true;
            this.secuencia.Click += new System.EventHandler(this.secuencia_Click);
            // 
            // describe
            // 
            this.describe.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.describe.Location = new System.Drawing.Point(313, 12);
            this.describe.Name = "describe";
            this.describe.Size = new System.Drawing.Size(248, 95);
            this.describe.TabIndex = 4;
            this.describe.Text = "Describe Imagen";
            this.describe.UseVisualStyleBackColor = true;
            this.describe.Click += new System.EventHandler(this.describe_Click);
            // 
            // jugadores
            // 
            this.jugadores.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jugadores.Location = new System.Drawing.Point(18, 244);
            this.jugadores.Name = "jugadores";
            this.jugadores.Size = new System.Drawing.Size(248, 95);
            this.jugadores.TabIndex = 5;
            this.jugadores.Text = "Gestionar Jugadores";
            this.jugadores.UseVisualStyleBackColor = true;
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 482);
            this.Controls.Add(this.jugadores);
            this.Controls.Add(this.describe);
            this.Controls.Add(this.secuencia);
            this.Controls.Add(this.atras);
            this.Controls.Add(this.textos);
            this.Controls.Add(this.estudiantes);
            this.Name = "Configuracion";
            this.Text = "Configuracion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button estudiantes;
        private System.Windows.Forms.Button textos;
        private System.Windows.Forms.Button atras;
        private System.Windows.Forms.Button secuencia;
        private System.Windows.Forms.Button describe;
        private System.Windows.Forms.Button jugadores;
    }
}