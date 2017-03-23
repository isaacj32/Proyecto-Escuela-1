namespace Proyecto_Escuela.Views
{
    partial class DescripcionImagen
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
            this.label1 = new System.Windows.Forms.Label();
            this.probar = new System.Windows.Forms.Button();
            this.terminar = new System.Windows.Forms.Button();
            this.textoLabel = new System.Windows.Forms.Label();
            this.respuesta = new System.Windows.Forms.TextBox();
            this.imagen = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.reintentar = new System.Windows.Forms.Button();
            this.anterior = new System.Windows.Forms.Button();
            this.siguiente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.intentos = new System.Windows.Forms.TextBox();
            this.aciertos = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errores = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Andrés Felipe Aparicio Mestre";
            // 
            // probar
            // 
            this.probar.BackColor = System.Drawing.Color.White;
            this.probar.Font = new System.Drawing.Font("PreCursive", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.probar.Location = new System.Drawing.Point(830, 432);
            this.probar.Name = "probar";
            this.probar.Size = new System.Drawing.Size(166, 93);
            this.probar.TabIndex = 37;
            this.probar.Text = "Probar";
            this.probar.UseVisualStyleBackColor = false;
            this.probar.Click += new System.EventHandler(this.probar_Click);
            // 
            // terminar
            // 
            this.terminar.BackColor = System.Drawing.Color.White;
            this.terminar.Font = new System.Drawing.Font("PreCursive", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.terminar.Location = new System.Drawing.Point(12, 432);
            this.terminar.Name = "terminar";
            this.terminar.Size = new System.Drawing.Size(166, 93);
            this.terminar.TabIndex = 38;
            this.terminar.Text = "Terminar";
            this.terminar.UseVisualStyleBackColor = false;
            this.terminar.Click += new System.EventHandler(this.button2_Click);
            // 
            // textoLabel
            // 
            this.textoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textoLabel.AutoSize = true;
            this.textoLabel.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoLabel.Location = new System.Drawing.Point(469, 73);
            this.textoLabel.Name = "textoLabel";
            this.textoLabel.Size = new System.Drawing.Size(62, 26);
            this.textoLabel.TabIndex = 40;
            this.textoLabel.Text = "Titulo";
            // 
            // respuesta
            // 
            this.respuesta.Font = new System.Drawing.Font("PreCursive", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.respuesta.Location = new System.Drawing.Point(310, 444);
            this.respuesta.Name = "respuesta";
            this.respuesta.Size = new System.Drawing.Size(388, 28);
            this.respuesta.TabIndex = 39;
            // 
            // imagen
            // 
            this.imagen.BackColor = System.Drawing.Color.Transparent;
            this.imagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imagen.Location = new System.Drawing.Point(310, 113);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(388, 309);
            this.imagen.TabIndex = 41;
            this.imagen.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(216)))), ((int)(((byte)(170)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox1.Font = new System.Drawing.Font("PreCursive", 26.25F);
            this.richTextBox1.Location = new System.Drawing.Point(17, 113);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(287, 309);
            this.richTextBox1.TabIndex = 42;
            this.richTextBox1.Text = "Describe cada imagen que va a apareciendo. Da click en \"Probar\" para evaluar tu r" +
    "espuesta.";
            // 
            // reintentar
            // 
            this.reintentar.BackColor = System.Drawing.Color.White;
            this.reintentar.Font = new System.Drawing.Font("PreCursive", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reintentar.Location = new System.Drawing.Point(704, 318);
            this.reintentar.Name = "reintentar";
            this.reintentar.Size = new System.Drawing.Size(292, 61);
            this.reintentar.TabIndex = 43;
            this.reintentar.Text = "Reintentar";
            this.reintentar.UseVisualStyleBackColor = false;
            this.reintentar.Click += new System.EventHandler(this.reintentar_Click);
            // 
            // anterior
            // 
            this.anterior.BackColor = System.Drawing.Color.White;
            this.anterior.Font = new System.Drawing.Font("PreCursive", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anterior.Location = new System.Drawing.Point(704, 113);
            this.anterior.Name = "anterior";
            this.anterior.Size = new System.Drawing.Size(122, 61);
            this.anterior.TabIndex = 44;
            this.anterior.Text = "Anterior";
            this.anterior.UseVisualStyleBackColor = false;
            this.anterior.Click += new System.EventHandler(this.anterior_Click);
            // 
            // siguiente
            // 
            this.siguiente.BackColor = System.Drawing.Color.White;
            this.siguiente.Font = new System.Drawing.Font("PreCursive", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siguiente.Location = new System.Drawing.Point(874, 113);
            this.siguiente.Name = "siguiente";
            this.siguiente.Size = new System.Drawing.Size(122, 61);
            this.siguiente.TabIndex = 45;
            this.siguiente.Text = "Siguiente";
            this.siguiente.UseVisualStyleBackColor = false;
            this.siguiente.Click += new System.EventHandler(this.siguiente_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PreCursive", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 46;
            this.label2.Text = "Aciertos:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PreCursive", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 47;
            this.label3.Text = "Intentos: ";
            // 
            // intentos
            // 
            this.intentos.Font = new System.Drawing.Font("PreCursive", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intentos.Location = new System.Drawing.Point(139, 11);
            this.intentos.Name = "intentos";
            this.intentos.Size = new System.Drawing.Size(96, 28);
            this.intentos.TabIndex = 48;
            this.intentos.Text = "0";
            // 
            // aciertos
            // 
            this.aciertos.Font = new System.Drawing.Font("PreCursive", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aciertos.Location = new System.Drawing.Point(139, 47);
            this.aciertos.Name = "aciertos";
            this.aciertos.Size = new System.Drawing.Size(96, 28);
            this.aciertos.TabIndex = 49;
            this.aciertos.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.errores);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.aciertos);
            this.panel1.Controls.Add(this.intentos);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(704, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 127);
            this.panel1.TabIndex = 50;
            // 
            // errores
            // 
            this.errores.Font = new System.Drawing.Font("PreCursive", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errores.Location = new System.Drawing.Point(139, 81);
            this.errores.Name = "errores";
            this.errores.Size = new System.Drawing.Size(96, 28);
            this.errores.TabIndex = 51;
            this.errores.Text = "0";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PreCursive", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 50;
            this.label4.Text = "Errores:";
            // 
            // DescripcionImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(216)))), ((int)(((byte)(170)))));
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.siguiente);
            this.Controls.Add(this.anterior);
            this.Controls.Add(this.reintentar);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.imagen);
            this.Controls.Add(this.textoLabel);
            this.Controls.Add(this.respuesta);
            this.Controls.Add(this.terminar);
            this.Controls.Add(this.probar);
            this.Controls.Add(this.label1);
            this.Name = "DescripcionImagen";
            this.Text = "Escuela";
            this.Load += new System.EventHandler(this.DescripcionImagen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button probar;
        private System.Windows.Forms.Button terminar;
        private System.Windows.Forms.PictureBox imagen;
        private System.Windows.Forms.Label textoLabel;
        private System.Windows.Forms.TextBox respuesta;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button reintentar;
        private System.Windows.Forms.Button anterior;
        private System.Windows.Forms.Button siguiente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox intentos;
        private System.Windows.Forms.TextBox aciertos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox errores;
        private System.Windows.Forms.Label label4;
    }
}

