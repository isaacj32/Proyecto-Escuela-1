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
        }
    }
}
