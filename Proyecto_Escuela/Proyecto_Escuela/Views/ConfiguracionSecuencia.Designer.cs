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
            this.botonAgregar = new System.Windows.Forms.Button();
            this.gridSecuencia = new System.Windows.Forms.DataGridView();
            this.orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutaEnTabla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.titulo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboGrados = new System.Windows.Forms.ComboBox();
            this.txtRutaCarpeta = new System.Windows.Forms.TextBox();
            this.labelRuta = new System.Windows.Forms.Label();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.btnCarpeta = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOrden = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridSecuencia)).BeginInit();
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
            this.botonModificar.Location = new System.Drawing.Point(614, 165);
            this.botonModificar.Name = "botonModificar";
            this.botonModificar.Size = new System.Drawing.Size(270, 30);
            this.botonModificar.TabIndex = 7;
            this.botonModificar.Text = "Modificar";
            this.botonModificar.UseVisualStyleBackColor = true;
            // 
            // botonAgregar
            // 
            this.botonAgregar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAgregar.Location = new System.Drawing.Point(614, 129);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(270, 30);
            this.botonAgregar.TabIndex = 5;
            this.botonAgregar.Text = "Eliminar imagen del listado";
            this.botonAgregar.UseVisualStyleBackColor = true;
            // 
            // gridSecuencia
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
            // orden
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
            // titulo
            // 
            this.titulo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.FormattingEnabled = true;
            this.titulo.Location = new System.Drawing.Point(122, 67);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(262, 28);
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
            this.txtRutaCarpeta.Location = new System.Drawing.Point(121, 191);
            this.txtRutaCarpeta.Name = "txtRutaCarpeta";
            this.txtRutaCarpeta.Size = new System.Drawing.Size(228, 20);
            this.txtRutaCarpeta.TabIndex = 20;
            // 
            // labelRuta
            // 
            this.labelRuta.AutoSize = true;
            this.labelRuta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRuta.Location = new System.Drawing.Point(117, 165);
            this.labelRuta.Name = "labelRuta";
            this.labelRuta.Size = new System.Drawing.Size(151, 20);
            this.labelRuta.TabIndex = 21;
            this.labelRuta.Text = "Ruta de la carpeta:";
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
            // btnCarpeta
            // 
            this.btnCarpeta.Location = new System.Drawing.Point(355, 188);
            this.btnCarpeta.Name = "btnCarpeta";
            this.btnCarpeta.Size = new System.Drawing.Size(28, 23);
            this.btnCarpeta.TabIndex = 24;
            this.btnCarpeta.Text = "...";
            this.btnCarpeta.UseVisualStyleBackColor = true;
            this.btnCarpeta.Click += new System.EventHandler(this.btnCarpeta_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(610, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Orden:";
            // 
            // txtOrden
            // 
            this.txtOrden.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrden.Location = new System.Drawing.Point(614, 100);
            this.txtOrden.Name = "txtOrden";
            this.txtOrden.Size = new System.Drawing.Size(136, 26);
            this.txtOrden.TabIndex = 27;
            // 
            // ConfiguracionSecuencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.txtOrden);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCarpeta);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.labelRuta);
            this.Controls.Add(this.txtRutaCarpeta);
            this.Controls.Add(this.comboGrados);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridSecuencia);
            this.Controls.Add(this.botonModificar);
            this.Controls.Add(this.botonAgregar);
            this.Controls.Add(this.label1);
            this.Name = "ConfiguracionSecuencia";
            this.Text = "ConfiguracionSecuencia";
            this.Load += new System.EventHandler(this.ConfiguracionSecuencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSecuencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonModificar;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.DataGridView gridSecuencia;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOrden;
    }
}