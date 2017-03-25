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
            this.label1 = new System.Windows.Forms.Label();
            this.comboEstadisticas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboOpciones = new System.Windows.Forms.ComboBox();
            this.labelSeleccion = new System.Windows.Forms.Label();
            this.comboGrupos = new System.Windows.Forms.ComboBox();
            this.labelGrupos = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelMedia = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelEstudiante = new System.Windows.Forms.Label();
            this.textBoxEstudiante = new System.Windows.Forms.TextBox();
            this.labelModa = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelMediana = new System.Windows.Forms.Label();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.tabla.Location = new System.Drawing.Point(12, 171);
            this.tabla.MultiSelect = false;
            this.tabla.Name = "tabla";
            this.tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla.Size = new System.Drawing.Size(984, 199);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 36);
            this.label1.TabIndex = 17;
            this.label1.Text = "Estadísticas";
            // 
            // comboEstadisticas
            // 
            this.comboEstadisticas.FormattingEnabled = true;
            this.comboEstadisticas.Items.AddRange(new object[] {
            "Grado",
            "Grupo",
            "Actividad",
            "Estudiante"});
            this.comboEstadisticas.Location = new System.Drawing.Point(12, 98);
            this.comboEstadisticas.Name = "comboEstadisticas";
            this.comboEstadisticas.Size = new System.Drawing.Size(195, 21);
            this.comboEstadisticas.TabIndex = 18;
            this.comboEstadisticas.SelectedIndexChanged += new System.EventHandler(this.comboEstadisticas_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Consultar estadísticas por:";
            // 
            // comboOpciones
            // 
            this.comboOpciones.Enabled = false;
            this.comboOpciones.FormattingEnabled = true;
            this.comboOpciones.Location = new System.Drawing.Point(279, 98);
            this.comboOpciones.Name = "comboOpciones";
            this.comboOpciones.Size = new System.Drawing.Size(152, 21);
            this.comboOpciones.TabIndex = 20;
            this.comboOpciones.SelectedIndexChanged += new System.EventHandler(this.comboOpciones_SelectedIndexChanged);
            // 
            // labelSeleccion
            // 
            this.labelSeleccion.AutoSize = true;
            this.labelSeleccion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeleccion.Location = new System.Drawing.Point(275, 74);
            this.labelSeleccion.Name = "labelSeleccion";
            this.labelSeleccion.Size = new System.Drawing.Size(0, 20);
            this.labelSeleccion.TabIndex = 21;
            // 
            // comboGrupos
            // 
            this.comboGrupos.Enabled = false;
            this.comboGrupos.FormattingEnabled = true;
            this.comboGrupos.Location = new System.Drawing.Point(520, 98);
            this.comboGrupos.Name = "comboGrupos";
            this.comboGrupos.Size = new System.Drawing.Size(121, 21);
            this.comboGrupos.TabIndex = 22;
            // 
            // labelGrupos
            // 
            this.labelGrupos.AutoSize = true;
            this.labelGrupos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrupos.Location = new System.Drawing.Point(517, 75);
            this.labelGrupos.Name = "labelGrupos";
            this.labelGrupos.Size = new System.Drawing.Size(0, 18);
            this.labelGrupos.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Media:";
            // 
            // labelMedia
            // 
            this.labelMedia.AutoSize = true;
            this.labelMedia.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMedia.Location = new System.Drawing.Point(80, 388);
            this.labelMedia.Name = "labelMedia";
            this.labelMedia.Size = new System.Drawing.Size(53, 20);
            this.labelMedia.TabIndex = 25;
            this.labelMedia.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(317, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Moda:";
            // 
            // labelEstudiante
            // 
            this.labelEstudiante.AutoSize = true;
            this.labelEstudiante.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstudiante.Location = new System.Drawing.Point(686, 74);
            this.labelEstudiante.Name = "labelEstudiante";
            this.labelEstudiante.Size = new System.Drawing.Size(0, 20);
            this.labelEstudiante.TabIndex = 27;
            // 
            // textBoxEstudiante
            // 
            this.textBoxEstudiante.Enabled = false;
            this.textBoxEstudiante.Location = new System.Drawing.Point(690, 97);
            this.textBoxEstudiante.Name = "textBoxEstudiante";
            this.textBoxEstudiante.Size = new System.Drawing.Size(134, 20);
            this.textBoxEstudiante.TabIndex = 28;
            // 
            // labelModa
            // 
            this.labelModa.AutoSize = true;
            this.labelModa.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModa.Location = new System.Drawing.Point(381, 389);
            this.labelModa.Name = "labelModa";
            this.labelModa.Size = new System.Drawing.Size(53, 20);
            this.labelModa.TabIndex = 29;
            this.labelModa.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(561, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Mediana:";
            // 
            // labelMediana
            // 
            this.labelMediana.AutoSize = true;
            this.labelMediana.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMediana.Location = new System.Drawing.Point(647, 388);
            this.labelMediana.Name = "labelMediana";
            this.labelMediana.Size = new System.Drawing.Size(53, 20);
            this.labelMediana.TabIndex = 31;
            this.labelMediana.Text = "label6";
            // 
            // botonAceptar
            // 
            this.botonAceptar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAceptar.Location = new System.Drawing.Point(818, 477);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(178, 48);
            this.botonAceptar.TabIndex = 32;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            // 
            // botonBuscar
            // 
            this.botonBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonBuscar.Location = new System.Drawing.Point(844, 87);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(122, 31);
            this.botonBuscar.TabIndex = 33;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 48);
            this.button1.TabIndex = 34;
            this.button1.Text = "Calcular estadísticas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(844, 124);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 33);
            this.button3.TabIndex = 36;
            this.button3.Text = "Filtrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Estadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.labelMediana);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelModa);
            this.Controls.Add(this.textBoxEstudiante);
            this.Controls.Add(this.labelEstudiante);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelMedia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelGrupos);
            this.Controls.Add(this.comboGrupos);
            this.Controls.Add(this.labelSeleccion);
            this.Controls.Add(this.comboOpciones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboEstadisticas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabla);
            this.Name = "Estadistica";
            this.Text = "Estadistica";
            this.Load += new System.EventHandler(this.Estadistica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboEstadisticas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboOpciones;
        private System.Windows.Forms.Label labelSeleccion;
        private System.Windows.Forms.ComboBox comboGrupos;
        private System.Windows.Forms.Label labelGrupos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelMedia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelEstudiante;
        private System.Windows.Forms.TextBox textBoxEstudiante;
        private System.Windows.Forms.Label labelModa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelMediana;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}