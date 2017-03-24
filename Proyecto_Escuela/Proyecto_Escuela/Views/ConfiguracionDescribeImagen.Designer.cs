namespace Proyecto_Escuela.Views
{
    partial class ConfiguracionDescribeImagen
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
            this.botonAgregar = new System.Windows.Forms.Button();
            this.botonBorrar = new System.Windows.Forms.Button();
            this.botonModificar = new System.Windows.Forms.Button();
            this.campoDescripcion = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.campoImagen = new System.Windows.Forms.PictureBox();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.botnoAceptar = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.campoImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configuración de juego: Describir Imágenes";
            // 
            // botonAgregar
            // 
            this.botonAgregar.Location = new System.Drawing.Point(671, 59);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(195, 30);
            this.botonAgregar.TabIndex = 2;
            this.botonAgregar.Text = "Agregar Imagen";
            this.botonAgregar.UseVisualStyleBackColor = true;
            // 
            // botonBorrar
            // 
            this.botonBorrar.Location = new System.Drawing.Point(671, 95);
            this.botonBorrar.Name = "botonBorrar";
            this.botonBorrar.Size = new System.Drawing.Size(195, 30);
            this.botonBorrar.TabIndex = 3;
            this.botonBorrar.Text = "Borrar Imagen";
            this.botonBorrar.UseVisualStyleBackColor = true;
            // 
            // botonModificar
            // 
            this.botonModificar.Location = new System.Drawing.Point(671, 131);
            this.botonModificar.Name = "botonModificar";
            this.botonModificar.Size = new System.Drawing.Size(195, 30);
            this.botonModificar.TabIndex = 4;
            this.botonModificar.Text = "Modificar";
            this.botonModificar.UseVisualStyleBackColor = true;
            // 
            // campoDescripcion
            // 
            this.campoDescripcion.Location = new System.Drawing.Point(103, 167);
            this.campoDescripcion.Name = "campoDescripcion";
            this.campoDescripcion.Size = new System.Drawing.Size(195, 20);
            this.campoDescripcion.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descripcion,
            this.imagen});
            this.dataGridView1.Location = new System.Drawing.Point(103, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 100;
            this.dataGridView1.Size = new System.Drawing.Size(763, 270);
            this.dataGridView1.TabIndex = 6;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Palabra clave";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // imagen
            // 
            this.imagen.HeaderText = "Imagen";
            this.imagen.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.imagen.Name = "imagen";
            this.imagen.ReadOnly = true;
            // 
            // campoImagen
            // 
            this.campoImagen.Location = new System.Drawing.Point(432, 59);
            this.campoImagen.Name = "campoImagen";
            this.campoImagen.Size = new System.Drawing.Size(106, 102);
            this.campoImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.campoImagen.TabIndex = 7;
            this.campoImagen.TabStop = false;
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(432, 167);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(106, 23);
            this.botonBuscar.TabIndex = 8;
            this.botonBuscar.Text = "Buscar Imagen";
            this.botonBuscar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Palabra clave de la imagen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Título del texto:";
            // 
            // botnoAceptar
            // 
            this.botnoAceptar.Location = new System.Drawing.Point(671, 498);
            this.botnoAceptar.Name = "botnoAceptar";
            this.botnoAceptar.Size = new System.Drawing.Size(195, 27);
            this.botnoAceptar.TabIndex = 12;
            this.botnoAceptar.Text = "Aceptar";
            this.botnoAceptar.UseVisualStyleBackColor = true;
            // 
            // titulo
            // 
            this.titulo.FormattingEnabled = true;
            this.titulo.Location = new System.Drawing.Point(103, 75);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(195, 21);
            this.titulo.TabIndex = 13;
            // 
            // ConfiguracionDescribeImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.botnoAceptar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.campoImagen);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.campoDescripcion);
            this.Controls.Add(this.botonModificar);
            this.Controls.Add(this.botonBorrar);
            this.Controls.Add(this.botonAgregar);
            this.Controls.Add(this.label1);
            this.Name = "ConfiguracionDescribeImagen";
            this.Text = "ConfiguracionDescribeImagen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.campoImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.Button botonBorrar;
        private System.Windows.Forms.Button botonModificar;
        private System.Windows.Forms.TextBox campoDescripcion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox campoImagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewImageColumn imagen;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button botnoAceptar;
        private System.Windows.Forms.ComboBox titulo;
    }
}