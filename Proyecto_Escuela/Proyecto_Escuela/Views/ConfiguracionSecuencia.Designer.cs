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
            this.botonModificar = new System.Windows.Forms.Button();
            this.botonBorrar = new System.Windows.Forms.Button();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.titulo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboGrados = new System.Windows.Forms.ComboBox();
            this.txtRutaCarpeta = new System.Windows.Forms.TextBox();
            this.labelRuta = new System.Windows.Forms.Label();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.botonAceptar = new System.Windows.Forms.Button();
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
            // botonModificar
            // 
            this.botonModificar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonModificar.Location = new System.Drawing.Point(689, 137);
            this.botonModificar.Name = "botonModificar";
            this.botonModificar.Size = new System.Drawing.Size(195, 30);
            this.botonModificar.TabIndex = 7;
            this.botonModificar.Text = "Modificar";
            this.botonModificar.UseVisualStyleBackColor = true;
            // 
            // botonBorrar
            // 
            this.botonBorrar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonBorrar.Location = new System.Drawing.Point(689, 101);
            this.botonBorrar.Name = "botonBorrar";
            this.botonBorrar.Size = new System.Drawing.Size(195, 30);
            this.botonBorrar.TabIndex = 6;
            this.botonBorrar.Text = "Borrar Imagen";
            this.botonBorrar.UseVisualStyleBackColor = true;
            // 
            // botonAgregar
            // 
            this.botonAgregar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAgregar.Location = new System.Drawing.Point(689, 65);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(195, 30);
            this.botonAgregar.TabIndex = 5;
            this.botonAgregar.Text = "Agregar Imagen";
            this.botonAgregar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.gridSecuencia.AllowUserToAddRows = false;
            this.gridSecuencia.AllowUserToDeleteRows = false;
            this.gridSecuencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridSecuencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSecuencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orden,
            this.rutaEnTabla,
            this.imagen});
            this.gridSecuencia.Location = new System.Drawing.Point(121, 227);
            this.gridSecuencia.Name = "gridSecuencia";
            this.gridSecuencia.ReadOnly = true;
            this.gridSecuencia.RowTemplate.Height = 100;
            this.gridSecuencia.Size = new System.Drawing.Size(763, 270);
            this.gridSecuencia.TabIndex = 8;
            this.gridSecuencia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSecuencia_CellClick);
            // 
            // titulo
            // 
            this.orden.HeaderText = "Orden";
            this.orden.Name = "orden";
            this.orden.ReadOnly = true;
            // 
            // rutaEnTabla
            // 
            this.rutaEnTabla.HeaderText = "Ruta";
            this.rutaEnTabla.Name = "rutaEnTabla";
            this.rutaEnTabla.ReadOnly = true;
            // 
            // imagen
            // 
            this.imagen.HeaderText = "Imagen";
            this.imagen.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.imagen.Name = "imagen";
            this.imagen.ReadOnly = true;
            // 
            // listTitulo
            // 
            this.listTitulo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listTitulo.FormattingEnabled = true;
            this.listTitulo.Location = new System.Drawing.Point(122, 67);
            this.listTitulo.Name = "listTitulo";
            this.listTitulo.Size = new System.Drawing.Size(262, 28);
            this.listTitulo.TabIndex = 17;
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
            this.label2.Location = new System.Drawing.Point(118, 106);
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
            this.comboGrados.Location = new System.Drawing.Point(122, 129);
            this.comboGrados.Name = "comboGrados";
            this.comboGrados.Size = new System.Drawing.Size(263, 28);
            this.comboGrados.TabIndex = 18;
            // 
            // txtRutaCarpeta
            // 
            this.txtRutaCarpeta.Location = new System.Drawing.Point(122, 201);
            this.txtRutaCarpeta.Name = "txtRutaCarpeta";
            this.txtRutaCarpeta.Size = new System.Drawing.Size(228, 20);
            this.txtRutaCarpeta.TabIndex = 20;
            // 
            // labelRuta
            // 
            this.labelRuta.AutoSize = true;
            this.labelRuta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRuta.Location = new System.Drawing.Point(118, 175);
            this.labelRuta.Name = "labelRuta";
            this.labelRuta.Size = new System.Drawing.Size(151, 20);
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
            // ConfiguracionSecuencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.labelRuta);
            this.Controls.Add(this.txtRutaCarpeta);
            this.Controls.Add(this.comboGrados);
            this.Controls.Add(this.listTitulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.botonModificar);
            this.Controls.Add(this.botonBorrar);
            this.Controls.Add(this.botonAgregar);
            this.Controls.Add(this.label1);
            this.Name = "ConfiguracionSecuencia";
            this.Text = "ConfiguracionSecuencia";
            ((System.ComponentModel.ISupportInitialize)(this.gridSecuencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonModificar;
        private System.Windows.Forms.Button botonBorrar;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox titulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboGrados;
        private System.Windows.Forms.TextBox txtRutaCarpeta;
        private System.Windows.Forms.Label labelRuta;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.Button btnCarpeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn orden;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutaEnTabla;
        private System.Windows.Forms.DataGridViewImageColumn imagen;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.Button botonAceptar;
    }
}