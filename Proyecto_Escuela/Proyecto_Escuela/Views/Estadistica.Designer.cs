namespace Proyecto_Escuela.Views
{
    partial class Estadistica
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
            this.tabla = new System.Windows.Forms.DataGridView();
            this.documentoE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradoE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciertosE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.erroresE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // tabla
            // 
            this.tabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.documentoE,
            this.nombreE,
            this.apellidoE,
            this.gradoE,
            this.grupoE,
            this.aciertosE,
            this.erroresE});
            this.tabla.Location = new System.Drawing.Point(12, 12);
            this.tabla.MultiSelect = false;
            this.tabla.Name = "tabla";
            this.tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla.Size = new System.Drawing.Size(984, 171);
            this.tabla.TabIndex = 16;
            // 
            // documentoE
            // 
            this.documentoE.HeaderText = "Documento";
            this.documentoE.Name = "documentoE";
            // 
            // nombreE
            // 
            this.nombreE.HeaderText = "Nombre";
            this.nombreE.Name = "nombreE";
            // 
            // apellidoE
            // 
            this.apellidoE.HeaderText = "Apellidos";
            this.apellidoE.Name = "apellidoE";
            // 
            // gradoE
            // 
            this.gradoE.HeaderText = "Grado";
            this.gradoE.Name = "gradoE";
            // 
            // grupoE
            // 
            this.grupoE.HeaderText = "Grupo";
            this.grupoE.Name = "grupoE";
            // 
            // aciertosE
            // 
            this.aciertosE.HeaderText = "Aciertos";
            this.aciertosE.Name = "aciertosE";
            // 
            // erroresE
            // 
            this.erroresE.HeaderText = "Errores";
            this.erroresE.Name = "erroresE";
            // 
            // Estadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.tabla);
            this.Name = "Estadistica";
            this.Text = "Estadistica";
            this.Load += new System.EventHandler(this.Estadistica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoE;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreE;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoE;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradoE;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupoE;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciertosE;
        private System.Windows.Forms.DataGridViewTextBoxColumn erroresE;
    }
}