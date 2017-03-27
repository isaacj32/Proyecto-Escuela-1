using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Escuela.Controllers;

namespace Proyecto_Escuela.Views
{
    public partial class Configuracion : Form
    {
        public Configuracion()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void estudiantes_Click(object sender, EventArgs e)
        {
            new ConfiguracionEstudiantes().Show();
            this.Dispose();
        }

        private void atras_Click(object sender, EventArgs e)
        {
            new Inicio().Show();
            this.Dispose();
        }

        private void textos_Click(object sender, EventArgs e)
        {
            new ConfigurarTexto().Show();
            this.Dispose();
        }

        private void describe_Click(object sender, EventArgs e)
        {
            new ConfiguracionDescribeControler();
            this.Dispose();
        }

        private void secuencia_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new ConfiguracionSecuenciaController();
        }
    }
}
