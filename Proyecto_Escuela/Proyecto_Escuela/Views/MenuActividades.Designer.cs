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
            this.tituloLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.describe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("PreCursive", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.Location = new System.Drawing.Point(444, 68);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(148, 64);
            this.tituloLabel.TabIndex = 2;
            this.tituloLabel.Text = "titulo";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.BackgroundImage = global::Proyecto_Escuela.Properties.Resources.dragon;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Font = new System.Drawing.Font("PreCursive", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(12, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(294, 170);
            this.button2.TabIndex = 3;
            this.button2.Text = "Secuencia de imagenes";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // describe
            // 
            this.describe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.describe.BackgroundImage = global::Proyecto_Escuela.Properties.Resources.draco;
            this.describe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.describe.Font = new System.Drawing.Font("PreCursive", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.describe.ForeColor = System.Drawing.Color.Black;
            this.describe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.describe.Location = new System.Drawing.Point(12, 179);
            this.describe.Name = "describe";
            this.describe.Size = new System.Drawing.Size(294, 170);
            this.describe.TabIndex = 4;
            this.describe.Text = "Describe una imagen";
            this.describe.UseVisualStyleBackColor = false;
            this.describe.Click += new System.EventHandler(this.describe_Click);
            // 
            // MenuActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.describe);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tituloLabel);
            this.Name = "MenuActividades";
            this.Text = "MenuActividades";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuActividades_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button describe;
    }
}