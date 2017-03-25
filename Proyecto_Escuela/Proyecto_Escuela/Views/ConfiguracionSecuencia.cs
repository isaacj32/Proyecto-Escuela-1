using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Escuela.Models;
using Proyecto_Escuela.Controllers;
using System.IO;

namespace Proyecto_Escuela.Views
{
    public partial class ConfiguracionSecuencia : Form
    {
        ConfiguracionSecuenciaController secuenciaController;
        public ConfiguracionSecuencia(ConfiguracionSecuenciaController controller)
        {
            InitializeComponent();
            secuenciaController = controller;            
        }

        private void btnCarpeta_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog escanerDeCarpeta = new FolderBrowserDialog();
            DialogResult res = escanerDeCarpeta.ShowDialog();
            if(res == DialogResult.OK)
            {
                txtRutaCarpeta.Text = escanerDeCarpeta.SelectedPath;
            }
            tabla.Enabled = true;
            //Aquí estan las rutas de las imagenes en un arreglo de STRINGS
            string[] imagenes = Directory.GetFiles(txtRutaCarpeta.Text, "*.png");
            for(int i = 0; i < imagenes.Length; i++)
            {
                tabla.Rows.Add(i, imagenes[i], Image.FromFile(imagenes[i]));
            }
        }

        private void gridSecuencia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtOrden.Text = tabla.CurrentRow.Cells[0].Value.ToString();
        }

        private void ConfiguracionSecuencia_Load(object sender, EventArgs e)
        {
            secuenciaController.BuscarTextos(titulo);
        }

        private void botonModificar_Click(object sender, EventArgs e)
        {
            tabla.CurrentRow.Cells[0].Value = txtOrden.Text;
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            tabla.Rows.Remove(tabla.CurrentRow);
        }
    }
}
