﻿namespace Proyecto_Escuela.Views
{
    partial class SecuenciaImagenes
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
            this.btnComprobacion = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnComprobacion
            // 
            this.btnComprobacion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprobacion.Location = new System.Drawing.Point(738, 551);
            this.btnComprobacion.Name = "btnComprobacion";
            this.btnComprobacion.Size = new System.Drawing.Size(190, 61);
            this.btnComprobacion.TabIndex = 0;
            this.btnComprobacion.Text = "Comprobar";
            this.btnComprobacion.UseVisualStyleBackColor = true;
            this.btnComprobacion.Click += new System.EventHandler(this.btnComprobacion_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnInfo.BackgroundImage = global::Proyecto_Escuela.Properties.Resources.info;
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInfo.Location = new System.Drawing.Point(751, 144);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(146, 139);
            this.btnInfo.TabIndex = 1;
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // SecuenciaImagenes
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 670);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnComprobacion);
            this.Name = "SecuenciaImagenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SecuenciaImagenes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SecuenciaImagenes_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnComprobacion;
        private System.Windows.Forms.Button btnInfo;
    }
}