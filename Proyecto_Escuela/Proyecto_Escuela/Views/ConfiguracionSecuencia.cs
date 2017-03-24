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

namespace Proyecto_Escuela.Views
{
    public partial class ConfiguracionSecuencia : Form
    {
        public ConfiguracionSecuencia()
        {
            InitializeComponent();
            ConfiguracionSecuenciaController csc = new ConfiguracionSecuenciaController();
            List<DescribeImagenModel> titulosDisponibles = csc.LlenarActividades();
            for (int i = 0; i < titulosDisponibles.Count; i++)
            {
                listTitulo.Items.Add(titulosDisponibles[i].GetTexto());
            }
            gridSecuencia.Enabled = false;
        }

        private void btnCarpeta_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog escanerDeCarpeta = new FolderBrowserDialog();
            DialogResult res = escanerDeCarpeta.ShowDialog();
            if(res == DialogResult.OK)
            {
                txtRutaCarpeta.Text = escanerDeCarpeta.SelectedPath;
            }
        }
        
    }
}
