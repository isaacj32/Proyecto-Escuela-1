namespace Proyecto_Escuela.Views
{
    partial class Inicio
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
            this.profesor = new System.Windows.Forms.Button();
            this.Estudiante = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // profesor
            // 
            this.profesor.Location = new System.Drawing.Point(105, 82);
            this.profesor.Name = "profesor";
            this.profesor.Size = new System.Drawing.Size(75, 23);
            this.profesor.TabIndex = 0;
            this.profesor.Text = "Profesor";
            this.profesor.UseVisualStyleBackColor = true;
            this.profesor.Click += new System.EventHandler(this.profesor_Click);
            // 
            // Estudiante
            // 
            this.Estudiante.Location = new System.Drawing.Point(105, 137);
            this.Estudiante.Name = "Estudiante";
            this.Estudiante.Size = new System.Drawing.Size(75, 23);
            this.Estudiante.TabIndex = 1;
            this.Estudiante.Text = "Estudiante";
            this.Estudiante.UseVisualStyleBackColor = true;
            this.Estudiante.Click += new System.EventHandler(this.Estudiante_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Estudiante);
            this.Controls.Add(this.profesor);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button profesor;
        private System.Windows.Forms.Button Estudiante;
    }
}