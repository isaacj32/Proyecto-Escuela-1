namespace Proyecto_Escuela.Views
{
    partial class ConfigurarTexto
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
            this.aceptar = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.foto = new System.Windows.Forms.PictureBox();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.tituloT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.potadaT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modificar = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.buscar = new System.Windows.Forms.Button();
            this.guardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.TextBox();
            this.tiempo = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.cuento = new System.Windows.Forms.RichTextBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(846, 503);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(150, 23);
            this.aceptar.TabIndex = 35;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(12, 92);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(72, 23);
            this.clear.TabIndex = 34;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = true;
            // 
            // foto
            // 
            this.foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.foto.Location = new System.Drawing.Point(782, 12);
            this.foto.Name = "foto";
            this.foto.Size = new System.Drawing.Size(214, 105);
            this.foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.foto.TabIndex = 33;
            this.foto.TabStop = false;
            this.foto.Click += new System.EventHandler(this.foto_Click);
            // 
            // tabla
            // 
            this.tabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tituloT,
            this.tiempoT,
            this.potadaT});
            this.tabla.Location = new System.Drawing.Point(12, 121);
            this.tabla.MultiSelect = false;
            this.tabla.Name = "tabla";
            this.tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla.Size = new System.Drawing.Size(445, 404);
            this.tabla.TabIndex = 32;
            this.tabla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_CellClick);
            // 
            // tituloT
            // 
            this.tituloT.HeaderText = "Titulo";
            this.tituloT.Name = "tituloT";
            // 
            // tiempoT
            // 
            this.tiempoT.HeaderText = "Tiempo";
            this.tiempoT.Name = "tiempoT";
            // 
            // potadaT
            // 
            this.potadaT.HeaderText = "Portada";
            this.potadaT.Name = "potadaT";
            // 
            // modificar
            // 
            this.modificar.Location = new System.Drawing.Point(222, 63);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(198, 23);
            this.modificar.TabIndex = 31;
            this.modificar.Text = "modificar";
            this.modificar.UseVisualStyleBackColor = true;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(222, 92);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(198, 23);
            this.eliminar.TabIndex = 30;
            this.eliminar.Text = "eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(222, 5);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(198, 23);
            this.buscar.TabIndex = 29;
            this.buscar.Text = "buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(222, 34);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(198, 23);
            this.guardar.TabIndex = 28;
            this.guardar.Text = "guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tiempo (en segundos)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Titulo";
            // 
            // titulo
            // 
            this.titulo.Location = new System.Drawing.Point(9, 27);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(198, 20);
            this.titulo.TabIndex = 21;
            // 
            // tiempo
            // 
            this.tiempo.Location = new System.Drawing.Point(12, 66);
            this.tiempo.Name = "tiempo";
            this.tiempo.Size = new System.Drawing.Size(195, 20);
            this.tiempo.TabIndex = 20;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(10, 6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(117, 17);
            this.checkBox1.TabIndex = 46;
            this.checkBox1.Text = "Describe Imagenes";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(10, 35);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(141, 17);
            this.checkBox2.TabIndex = 47;
            this.checkBox2.Text = "Secuencia de Imagenes";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(10, 65);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 48;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // cuento
            // 
            this.cuento.Location = new System.Drawing.Point(463, 121);
            this.cuento.Name = "cuento";
            this.cuento.Size = new System.Drawing.Size(533, 376);
            this.cuento.TabIndex = 38;
            this.cuento.Text = "";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(209, 65);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(80, 17);
            this.checkBox4.TabIndex = 51;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(209, 35);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(80, 17);
            this.checkBox5.TabIndex = 50;
            this.checkBox5.Text = "checkBox5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(209, 6);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(80, 17);
            this.checkBox6.TabIndex = 49;
            this.checkBox6.Text = "checkBox6";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Actividades";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkBox4);
            this.panel1.Controls.Add(this.checkBox5);
            this.panel1.Controls.Add(this.checkBox6);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Location = new System.Drawing.Point(463, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 87);
            this.panel1.TabIndex = 53;
            // 
            // ConfigurarTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cuento);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.foto);
            this.Controls.Add(this.tabla);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.tiempo);
            this.Name = "ConfigurarTexto";
            this.Text = "ConfigurarTexto";
            this.Load += new System.EventHandler(this.ConfigurarTexto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.PictureBox foto;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloT;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoT;
        private System.Windows.Forms.DataGridViewTextBoxColumn potadaT;
        private System.Windows.Forms.Button modificar;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox titulo;
        private System.Windows.Forms.TextBox tiempo;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.RichTextBox cuento;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}