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
            gridSecuencia.Enabled = true;
            //Aquí estan las rutas de las imagenes en un arreglo de STRINGS
            string[] imagenes = Directory.GetFiles(txtRutaCarpeta.Text, "*.png");
            for(int i = 0; i < imagenes.Length; i++)
            {
                gridSecuencia.Rows.Add(i, imagenes[i], Image.FromFile(imagenes[i]));
            }
        }

        private void gridSecuencia_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ConfiguracionSecuencia_Load(object sender, EventArgs e)
        {
            secuenciaController.BuscarTextos(t);
        }
    }
}
