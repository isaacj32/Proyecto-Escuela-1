namespace Proyecto_Escuela.Views
{
    partial class MenuActividades
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
            this.botonSecuencia = new System.Windows.Forms.Button();
            this.botonDescripcion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.botonLeerTexto = new System.Windows.Forms.Button();
            this.botonListaTextos = new System.Windows.Forms.Button();
            this.botonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonSecuencia
            // 
            this.botonSecuencia.Location = new System.Drawing.Point(94, 178);
            this.botonSecuencia.Name = "botonSecuencia";
            this.botonSecuencia.Size = new System.Drawing.Size(191, 100);
            this.botonSecuencia.TabIndex = 0;
            this.botonSecuencia.Text = "Secuencia";
            this.botonSecuencia.UseVisualStyleBackColor = true;
            this.botonSecuencia.Click += new System.EventHandler(this.botonSecuencia_Click);
            // 
            // botonDescripcion
            // 
            this.botonDescripcion.Location = new System.Drawing.Point(405, 178);
            this.botonDescripcion.Name = "botonDescripcion";
            this.botonDescripcion.Size = new System.Drawing.Size(191, 100);
            this.botonDescripcion.TabIndex = 1;
            this.botonDescripcion.Text = "Descripción";
            this.botonDescripcion.UseVisualStyleBackColor = true;
            this.botonDescripcion.Click += new System.EventHandler(this.botonDescripcion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(479, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "titulo";
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(737, 178);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 100);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(94, 326);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(191, 100);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(405, 326);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(191, 100);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(737, 326);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(191, 100);
            this.button6.TabIndex = 6;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "¡Selecciona un juego!";
            // 
            // botonLeerTexto
            // 
            this.botonLeerTexto.Location = new System.Drawing.Point(94, 470);
            this.botonLeerTexto.Name = "botonLeerTexto";
            this.botonLeerTexto.Size = new System.Drawing.Size(191, 44);
            this.botonLeerTexto.TabIndex = 8;
            this.botonLeerTexto.Text = "Volver a leer el texto";
            this.botonLeerTexto.UseVisualStyleBackColor = true;
            // 
            // botonListaTextos
            // 
            this.botonListaTextos.Location = new System.Drawing.Point(405, 470);
            this.botonListaTextos.Name = "botonListaTextos";
            this.botonListaTextos.Size = new System.Drawing.Size(191, 44);
            this.botonListaTextos.TabIndex = 9;
            this.botonListaTextos.Text = "Volver a la lista de textos";
            this.botonListaTextos.UseVisualStyleBackColor = true;
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(737, 470);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(191, 44);
            this.botonSalir.TabIndex = 10;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // MenuActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.botonListaTextos);
            this.Controls.Add(this.botonLeerTexto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonDescripcion);
            this.Controls.Add(this.botonSecuencia);
            this.Name = "MenuActividades";
            this.Text = "MenuActividades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonSecuencia;
        private System.Windows.Forms.Button botonDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botonLeerTexto;
        private System.Windows.Forms.Button botonListaTextos;
        private System.Windows.Forms.Button botonSalir;
    }
}