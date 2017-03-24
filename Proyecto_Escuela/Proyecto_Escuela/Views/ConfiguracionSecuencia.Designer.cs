namespace Proyecto_Escuela.Views
{
    partial class ConfiguracionSecuencia
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.titulo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboGrados = new System.Windows.Forms.ComboBox();
            this.campoImagen = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelRuta = new System.Windows.Forms.Label();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.botonModificar = new System.Windows.Forms.Button();
            this.botonBorrar = new System.Windows.Forms.Button();
            this.botonAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.campoImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(606, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configuración de juego: Secuencia de Imágenes";
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
            this.dataGridView1.Location = new System.Drawing.Point(121, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 100;
            this.dataGridView1.Size = new System.Drawing.Size(763, 270);
            this.dataGridView1.TabIndex = 8;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Ruta/Orden";
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
            // titulo
            // 
            this.titulo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.FormattingEnabled = true;
            this.titulo.Location = new System.Drawing.Point(122, 67);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(195, 28);
            this.titulo.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Título del texto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Grado al que está dirigido el juego:";
            // 
            // comboGrados
            // 
            this.comboGrados.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboGrados.FormattingEnabled = true;
            this.comboGrados.Items.AddRange(new object[] {
            "Primero",
            "Segundo",
            "Tercero"});
            this.comboGrados.Location = new System.Drawing.Point(121, 139);
            this.comboGrados.Name = "comboGrados";
            this.comboGrados.Size = new System.Drawing.Size(195, 28);
            this.comboGrados.TabIndex = 18;
            // 
            // campoImagen
            // 
            this.campoImagen.Location = new System.Drawing.Point(462, 58);
            this.campoImagen.Name = "campoImagen";
            this.campoImagen.Size = new System.Drawing.Size(106, 102);
            this.campoImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.campoImagen.TabIndex = 19;
            this.campoImagen.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 201);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 20);
            this.textBox1.TabIndex = 20;
            // 
            // labelRuta
            // 
            this.labelRuta.AutoSize = true;
            this.labelRuta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRuta.Location = new System.Drawing.Point(118, 175);
            this.labelRuta.Name = "labelRuta";
            this.labelRuta.Size = new System.Drawing.Size(114, 20);
            this.labelRuta.TabIndex = 21;
            this.labelRuta.Text = "Ruta del texto:";
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(462, 175);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(106, 23);
            this.botonBuscar.TabIndex = 22;
            this.botonBuscar.Text = "Buscar Imagen";
            this.botonBuscar.UseVisualStyleBackColor = true;
            // 
            // botonAceptar
            // 
            this.botonAceptar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAceptar.Location = new System.Drawing.Point(689, 503);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(195, 27);
            this.botonAceptar.TabIndex = 23;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            // 
            // botonModificar
            // 
            this.botonModificar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonModificar.Location = new System.Drawing.Point(734, 137);
            this.botonModificar.Name = "botonModificar";
            this.botonModificar.Size = new System.Drawing.Size(195, 30);
            this.botonModificar.TabIndex = 26;
            this.botonModificar.Text = "Modificar";
            this.botonModificar.UseVisualStyleBackColor = true;
            // 
            // botonBorrar
            // 
            this.botonBorrar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonBorrar.Location = new System.Drawing.Point(734, 101);
            this.botonBorrar.Name = "botonBorrar";
            this.botonBorrar.Size = new System.Drawing.Size(195, 30);
            this.botonBorrar.TabIndex = 25;
            this.botonBorrar.Text = "Borrar Imagen";
            this.botonBorrar.UseVisualStyleBackColor = true;
            // 
            // botonAgregar
            // 
            this.botonAgregar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAgregar.Location = new System.Drawing.Point(734, 65);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(195, 31);
            this.botonAgregar.TabIndex = 24;
            this.botonAgregar.Text = "Agregar Imagen";
            this.botonAgregar.UseVisualStyleBackColor = true;
            // 
            // ConfiguracionSecuencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.botonModificar);
            this.Controls.Add(this.botonBorrar);
            this.Controls.Add(this.botonAgregar);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.labelRuta);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.campoImagen);
            this.Controls.Add(this.comboGrados);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "ConfiguracionSecuencia";
            this.Text = "ConfiguracionSecuencia";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.campoImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox titulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboGrados;
        private System.Windows.Forms.PictureBox campoImagen;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelRuta;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewImageColumn imagen;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.Button botonModificar;
        private System.Windows.Forms.Button botonBorrar;
        private System.Windows.Forms.Button botonAgregar;
    }
}