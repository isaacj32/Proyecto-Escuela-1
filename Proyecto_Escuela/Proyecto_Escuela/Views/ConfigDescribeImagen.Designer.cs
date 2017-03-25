namespace Proyecto_Escuela.Views
{
    partial class ConfigDescribeImagen
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
            this.modificar = new System.Windows.Forms.Button();
            this.agregar = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.ComboBox();
            this.botnoAceptar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.campoImagen = new System.Windows.Forms.PictureBox();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.campoDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.campoImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // modificar
            // 
            this.modificar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificar.Location = new System.Drawing.Point(692, 141);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(195, 30);
            this.modificar.TabIndex = 40;
            this.modificar.Text = "Modificar";
            this.modificar.UseVisualStyleBackColor = true;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // agregar
            // 
            this.agregar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar.Location = new System.Drawing.Point(692, 83);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(195, 31);
            this.agregar.TabIndex = 38;
            this.agregar.Text = "Agregar Imagen";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // titulo
            // 
            this.titulo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.FormattingEnabled = true;
            this.titulo.Location = new System.Drawing.Point(125, 83);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(195, 28);
            this.titulo.TabIndex = 37;
            this.titulo.SelectedIndexChanged += new System.EventHandler(this.titulo_SelectedIndexChanged);
            // 
            // botnoAceptar
            // 
            this.botnoAceptar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botnoAceptar.Location = new System.Drawing.Point(692, 499);
            this.botnoAceptar.Name = "botnoAceptar";
            this.botnoAceptar.Size = new System.Drawing.Size(195, 27);
            this.botnoAceptar.TabIndex = 36;
            this.botnoAceptar.Text = "Aceptar";
            this.botnoAceptar.UseVisualStyleBackColor = true;
            this.botnoAceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Título del texto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Palabra clave de la imagen:";
            // 
            // campoImagen
            // 
            this.campoImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.campoImagen.Location = new System.Drawing.Point(393, 60);
            this.campoImagen.Name = "campoImagen";
            this.campoImagen.Size = new System.Drawing.Size(240, 144);
            this.campoImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.campoImagen.TabIndex = 33;
            this.campoImagen.TabStop = false;
            this.campoImagen.Click += new System.EventHandler(this.campoImagen_Click);
            // 
            // tabla
            // 
            this.tabla.AllowUserToAddRows = false;
            this.tabla.AllowUserToDeleteRows = false;
            this.tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descripcion,
            this.imagen});
            this.tabla.Location = new System.Drawing.Point(124, 210);
            this.tabla.Name = "tabla";
            this.tabla.ReadOnly = true;
            this.tabla.RowTemplate.Height = 120;
            this.tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla.Size = new System.Drawing.Size(763, 270);
            this.tabla.TabIndex = 32;
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
            // campoDescripcion
            // 
            this.campoDescripcion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoDescripcion.Location = new System.Drawing.Point(124, 168);
            this.campoDescripcion.Name = "campoDescripcion";
            this.campoDescripcion.Size = new System.Drawing.Size(195, 26);
            this.campoDescripcion.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(541, 30);
            this.label1.TabIndex = 30;
            this.label1.Text = "Configuración de juego: Describir Imágenes";
            // 
            // ConfigDescribeImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.botnoAceptar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.campoImagen);
            this.Controls.Add(this.tabla);
            this.Controls.Add(this.campoDescripcion);
            this.Controls.Add(this.label1);
            this.Name = "ConfigDescribeImagen";
            this.Text = "ConfigDescribeImagen";
            this.Load += new System.EventHandler(this.ConfigDescribeImagen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.campoImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button modificar;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.ComboBox titulo;
        private System.Windows.Forms.Button botnoAceptar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox campoImagen;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewImageColumn imagen;
        private System.Windows.Forms.TextBox campoDescripcion;
        private System.Windows.Forms.Label label1;
    }
}