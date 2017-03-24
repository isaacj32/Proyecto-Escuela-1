﻿using Proyecto_Escuela.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Escuela.Views
{
    public partial class ListaTextos : Form
    {
        Texto texto;
        
        public ListaTextos(Texto texto)
        {
            this.texto = texto;
            InitializeComponent();
        }

        //Getter para usar el DataGrid en el controller
        public DataGridView getLista()
        {
            return dataGridView1;
        }

        //Características del DataGrid cuando carga la ventana
        private void ListaTextos_Load(object sender, EventArgs e)
        {
            portada.ImageLayout = DataGridViewImageCellLayout.Zoom;

            DataGridViewTextBoxColumn dgt = new DataGridViewTextBoxColumn();
            dgt.HeaderText = "Título";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 120;

            MemoryStream ms = new MemoryStream();
            Image imagen;
            imagen = Proyecto_Escuela.Properties.Resources.buho;
            dataGridView1.Rows.Add(texto.getTitulo(), imagen);
        }
    }
}
