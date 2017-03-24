namespace Proyecto_Escuela.Views
{
    partial class ConfiguracionEstudiantes
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
            this.components = new System.ComponentModel.Container();
            this.apellido = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.documento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grado = new System.Windows.Forms.ComboBox();
            this.grupo = new System.Windows.Forms.TextBox();
            this.guardar = new System.Windows.Forms.Button();
            this.buscar = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.modificar = new System.Windows.Forms.Button();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.dbescuelaDataSet = new Proyecto_Escuela.dbescuelaDataSet();
            this.estudianteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estudianteTableAdapter = new Proyecto_Escuela.dbescuelaDataSetTableAdapters.estudianteTableAdapter();
            this.clear = new System.Windows.Forms.Button();
            this.aceptar = new System.Windows.Forms.Button();
            this.foto = new System.Windows.Forms.PictureBox();
            this.documentoE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradoE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotoE = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbescuelaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).BeginInit();
            this.SuspendLayout();
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(453, 42);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(195, 20);
            this.apellido.TabIndex = 1;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(235, 42);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(195, 20);
            this.nombre.TabIndex = 2;
            // 
            // documento
            // 
            this.documento.Location = new System.Drawing.Point(12, 42);
            this.documento.Name = "documento";
            this.documento.Size = new System.Drawing.Size(198, 20);
            this.documento.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "nombre(s)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "apellidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(669, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "grupo";
            // 
            // grado
            // 
            this.grado.FormattingEnabled = true;
            this.grado.Items.AddRange(new object[] {
            "",
            "Primero",
            "Segundo",
            "Tercero"});
            this.grado.Location = new System.Drawing.Point(672, 41);
            this.grado.Name = "grado";
            this.grado.Size = new System.Drawing.Size(106, 21);
            this.grado.TabIndex = 8;
            // 
            // grupo
            // 
            this.grupo.Location = new System.Drawing.Point(784, 42);
            this.grupo.Name = "grupo";
            this.grupo.Size = new System.Drawing.Size(83, 20);
            this.grupo.TabIndex = 9;
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(12, 91);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(198, 23);
            this.guardar.TabIndex = 11;
            this.guardar.Text = "guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(235, 91);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(195, 23);
            this.buscar.TabIndex = 12;
            this.buscar.Text = "buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(453, 91);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(195, 23);
            this.eliminar.TabIndex = 13;
            this.eliminar.Text = "eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // modificar
            // 
            this.modificar.Location = new System.Drawing.Point(672, 91);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(106, 23);
            this.modificar.TabIndex = 14;
            this.modificar.Text = "modificar";
            this.modificar.UseVisualStyleBackColor = true;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // tabla
            // 
            this.tabla.AllowUserToAddRows = false;
            this.tabla.AllowUserToDeleteRows = false;
            this.tabla.AllowUserToResizeColumns = false;
            this.tabla.AllowUserToResizeRows = false;
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
            this.fotoE});
            this.tabla.Location = new System.Drawing.Point(12, 120);
            this.tabla.MultiSelect = false;
            this.tabla.Name = "tabla";
            this.tabla.RowTemplate.Height = 120;
            this.tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla.Size = new System.Drawing.Size(984, 375);
            this.tabla.TabIndex = 15;
            // 
            // dbescuelaDataSet
            // 
            this.dbescuelaDataSet.DataSetName = "dbescuelaDataSet";
            this.dbescuelaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estudianteBindingSource
            // 
            this.estudianteBindingSource.DataMember = "estudiante";
            this.estudianteBindingSource.DataSource = this.dbescuelaDataSet;
            // 
            // estudianteTableAdapter
            // 
            this.estudianteTableAdapter.ClearBeforeFill = true;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(784, 91);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(83, 23);
            this.clear.TabIndex = 17;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(846, 502);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(150, 23);
            this.aceptar.TabIndex = 18;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // foto
            // 
            this.foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.foto.Location = new System.Drawing.Point(873, 9);
            this.foto.Name = "foto";
            this.foto.Size = new System.Drawing.Size(123, 105);
            this.foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.foto.TabIndex = 16;
            this.foto.TabStop = false;
            this.foto.Click += new System.EventHandler(this.foto_Click);
            // 
            // documentoE
            // 
            this.documentoE.HeaderText = "documento";
            this.documentoE.Name = "documentoE";
            // 
            // nombreE
            // 
            this.nombreE.HeaderText = "nombre";
            this.nombreE.Name = "nombreE";
            // 
            // apellidoE
            // 
            this.apellidoE.HeaderText = "apellidos";
            this.apellidoE.Name = "apellidoE";
            // 
            // gradoE
            // 
            this.gradoE.HeaderText = "grado";
            this.gradoE.Name = "gradoE";
            // 
            // grupoE
            // 
            this.grupoE.HeaderText = "grupo";
            this.grupoE.Name = "grupoE";
            // 
            // fotoE
            // 
            this.fotoE.HeaderText = "foto";
            this.fotoE.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.fotoE.Name = "fotoE";
            this.fotoE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fotoE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ConfiguracionEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.foto);
            this.Controls.Add(this.tabla);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.grupo);
            this.Controls.Add(this.grado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.documento);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.apellido);
            this.Name = "ConfiguracionEstudiantes";
            this.Text = "ConfiguracionEstudiantes";
            this.Load += new System.EventHandler(this.ConfiguracionEstudiantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbescuelaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox documento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox grado;
        private System.Windows.Forms.TextBox grupo;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button modificar;
        private dbescuelaDataSet dbescuelaDataSet;
        private System.Windows.Forms.BindingSource estudianteBindingSource;
        private dbescuelaDataSetTableAdapters.estudianteTableAdapter estudianteTableAdapter;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.PictureBox foto;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoE;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreE;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoE;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradoE;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupoE;
        private System.Windows.Forms.DataGridViewImageColumn fotoE;
    }
}