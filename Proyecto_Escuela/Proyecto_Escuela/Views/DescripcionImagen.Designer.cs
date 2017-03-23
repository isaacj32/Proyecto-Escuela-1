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
            this.button2 = new System.Windows.Forms.Button();
            this.textoLabel = new System.Windows.Forms.Label();
            this.respuesta = new System.Windows.Forms.TextBox();
            this.imagen = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.reintentar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 432);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 93);
            this.button2.TabIndex = 38;
            this.button2.Text = "Terminar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("PreCursive", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(704, 113);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 61);
            this.button4.TabIndex = 44;
            this.button4.Text = "Anterior";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Font = new System.Drawing.Font("PreCursive", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(874, 113);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 61);
            this.button5.TabIndex = 45;
            this.button5.Text = "Siguiente";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PreCursive", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 51);
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
            this.label3.Location = new System.Drawing.Point(36, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 47;
            this.label3.Text = "Intentos: ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("PreCursive", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(139, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(96, 28);
            this.textBox1.TabIndex = 48;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("PreCursive", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(139, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(96, 28);
            this.textBox2.TabIndex = 49;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(704, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 127);
            this.panel1.TabIndex = 50;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("PreCursive", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(139, 81);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(96, 28);
            this.textBox3.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PreCursive", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 85);
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
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.reintentar);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.imagen);
            this.Controls.Add(this.textoLabel);
            this.Controls.Add(this.respuesta);
            this.Controls.Add(this.button2);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox imagen;
        private System.Windows.Forms.Label textoLabel;
        private System.Windows.Forms.TextBox respuesta;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button reintentar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
    }
}

