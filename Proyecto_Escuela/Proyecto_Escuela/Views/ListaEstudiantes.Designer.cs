namespace Proyecto_Escuela.Views
{
    partial class ListaEstudiantes
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.primero = new System.Windows.Forms.TabPage();
            this.tablaPrimero = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.segundo = new System.Windows.Forms.TabPage();
            this.tablaSegundo = new System.Windows.Forms.DataGridView();
            this.tercero = new System.Windows.Forms.TabPage();
            this.tablaTercero = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.primero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPrimero)).BeginInit();
            this.segundo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaSegundo)).BeginInit();
            this.tercero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTercero)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.primero);
            this.tabControl1.Controls.Add(this.segundo);
            this.tabControl1.Controls.Add(this.tercero);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("PreCursive", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1008, 537);
            this.tabControl1.TabIndex = 0;
            // 
            // primero
            // 
            this.primero.Controls.Add(this.tablaPrimero);
            this.primero.Location = new System.Drawing.Point(4, 37);
            this.primero.Name = "primero";
            this.primero.Padding = new System.Windows.Forms.Padding(3);
            this.primero.Size = new System.Drawing.Size(1000, 496);
            this.primero.TabIndex = 0;
            this.primero.Text = "Primero";
            this.primero.UseVisualStyleBackColor = true;
            // 
            // tablaPrimero
            // 
            this.tablaPrimero.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaPrimero.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaPrimero.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaPrimero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaPrimero.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.tablaPrimero.Location = new System.Drawing.Point(3, 3);
            this.tablaPrimero.Name = "tablaPrimero";
            this.tablaPrimero.Size = new System.Drawing.Size(994, 490);
            this.tablaPrimero.TabIndex = 1;
            this.tablaPrimero.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaPrimero_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // segundo
            // 
            this.segundo.Controls.Add(this.tablaSegundo);
            this.segundo.Location = new System.Drawing.Point(4, 37);
            this.segundo.Name = "segundo";
            this.segundo.Padding = new System.Windows.Forms.Padding(3);
            this.segundo.Size = new System.Drawing.Size(1000, 496);
            this.segundo.TabIndex = 1;
            this.segundo.Text = "Segundo";
            this.segundo.UseVisualStyleBackColor = true;
            // 
            // tablaSegundo
            // 
            this.tablaSegundo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaSegundo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaSegundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaSegundo.Location = new System.Drawing.Point(3, 3);
            this.tablaSegundo.Name = "tablaSegundo";
            this.tablaSegundo.Size = new System.Drawing.Size(994, 490);
            this.tablaSegundo.TabIndex = 1;
            // 
            // tercero
            // 
            this.tercero.Controls.Add(this.tablaTercero);
            this.tercero.Location = new System.Drawing.Point(4, 37);
            this.tercero.Name = "tercero";
            this.tercero.Padding = new System.Windows.Forms.Padding(3);
            this.tercero.Size = new System.Drawing.Size(1000, 496);
            this.tercero.TabIndex = 2;
            this.tercero.Text = "Tercero";
            this.tercero.UseVisualStyleBackColor = true;
            // 
            // tablaTercero
            // 
            this.tablaTercero.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaTercero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaTercero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaTercero.Location = new System.Drawing.Point(3, 3);
            this.tablaTercero.Name = "tablaTercero";
            this.tablaTercero.Size = new System.Drawing.Size(994, 490);
            this.tablaTercero.TabIndex = 0;
            // 
            // ListaEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.tabControl1);
            this.Name = "ListaEstudiantes";
            this.Text = "ListaEstudiante";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ListaEstudiantes_FormClosed);
            this.Load += new System.EventHandler(this.ListaEstudiantes_Load);
            this.tabControl1.ResumeLayout(false);
            this.primero.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaPrimero)).EndInit();
            this.segundo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaSegundo)).EndInit();
            this.tercero.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaTercero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage primero;
        private System.Windows.Forms.TabPage segundo;
        private System.Windows.Forms.DataGridView tablaPrimero;
        private System.Windows.Forms.DataGridView tablaSegundo;
        private System.Windows.Forms.TabPage tercero;
        private System.Windows.Forms.DataGridView tablaTercero;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn Column4;
    }
}