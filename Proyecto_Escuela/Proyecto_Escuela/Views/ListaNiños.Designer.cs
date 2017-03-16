namespace Proyecto_Escuela.Views
{
    partial class SeleccionNiño
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeleccionNiño));
            this.botonSalida = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.niño_1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonSalida
            // 
            this.botonSalida.Location = new System.Drawing.Point(823, 406);
            this.botonSalida.Name = "botonSalida";
            this.botonSalida.Size = new System.Drawing.Size(154, 39);
            this.botonSalida.TabIndex = 0;
            this.botonSalida.Text = "Salir";
            this.botonSalida.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.niño_1);
            this.panel1.Location = new System.Drawing.Point(23, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 378);
            this.panel1.TabIndex = 1;
            // 
            // niño_1
            // 
            this.niño_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("niño_1.BackgroundImage")));
            this.niño_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.niño_1.Location = new System.Drawing.Point(3, 3);
            this.niño_1.Name = "niño_1";
            this.niño_1.Size = new System.Drawing.Size(168, 109);
            this.niño_1.TabIndex = 0;
            this.niño_1.UseVisualStyleBackColor = true;
            this.niño_1.Click += new System.EventHandler(this.niño_1_Click);
            // 
            // SeleccionNiño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.botonSalida);
            this.Name = "SeleccionNiño";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonSalida;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button niño_1;
    }
}