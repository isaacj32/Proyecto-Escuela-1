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
            this.tabla = new System.Windows.Forms.DataGridView();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.campoImagen = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.modificar = new System.Windows.Forms.Button();
            this.campoDescripcion = new System.Windows.Forms.TextBox();
            this.agregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.campoImagen)).BeginInit();
            this.SuspendLayout();
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
            this.tabla.Location = new System.Drawing.Point(82, 230);
            this.tabla.Name = "tabla";
            this.tabla.ReadOnly = true;
            this.tabla.RowTemplate.Height = 100;
            this.tabla.Size = new System.Drawing.Size(839, 244);
            this.tabla.TabIndex = 0;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
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
            this.botonAceptar.Location = new System.Drawing.Point(788, 491);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(133, 34);
            this.botonAceptar.TabIndex = 1;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // campoImagen
            // 
            this.campoImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.campoImagen.Location = new System.Drawing.Point(414, 65);
            this.campoImagen.Name = "campoImagen";
            this.campoImagen.Size = new System.Drawing.Size(134, 129);
            this.campoImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.campoImagen.TabIndex = 2;
            this.campoImagen.TabStop = false;
            this.campoImagen.Click += new System.EventHandler(this.campoImagen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(506, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Configuración: Descripción de Imágenes";
            // 
            // modificar
            // 
            this.modificar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificar.Location = new System.Drawing.Point(771, 150);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(150, 31);
            this.modificar.TabIndex = 4;
            this.modificar.Text = "Modificar";
            this.modificar.UseVisualStyleBackColor = true;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // campoDescripcion
            // 
            this.campoDescripcion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoDescripcion.Location = new System.Drawing.Point(82, 168);
            this.campoDescripcion.Name = "campoDescripcion";
            this.campoDescripcion.Size = new System.Drawing.Size(196, 26);
            this.campoDescripcion.TabIndex = 5;
            // 
            // agregar
            // 
            this.agregar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar.Location = new System.Drawing.Point(771, 113);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(150, 31);
            this.agregar.TabIndex = 6;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descripción de la imagen:";
            // 
            // titulo
            // 
            this.titulo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.FormattingEnabled = true;
            this.titulo.Location = new System.Drawing.Point(82, 97);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(196, 28);
            this.titulo.TabIndex = 8;
            this.titulo.SelectedIndexChanged += new System.EventHandler(this.titulo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Seleccione el texto asociado:";
            // 
            // cancelar
            // 
            this.cancelar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.Location = new System.Drawing.Point(12, 491);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(133, 34);
            this.cancelar.TabIndex = 10;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // ConfigDescribeImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.campoDescripcion);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.campoImagen);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.tabla);
            this.Name = "ConfigDescribeImagen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfigDescribeImagen";
            this.Load += new System.EventHandler(this.ConfigDescribeImagen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.campoImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewImageColumn imagen;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.PictureBox campoImagen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button modificar;
        private System.Windows.Forms.TextBox campoDescripcion;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox titulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancelar;
    }
}