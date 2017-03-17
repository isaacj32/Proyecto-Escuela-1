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
using Proyecto_Escuela.Models;

namespace Proyecto_Escuela.Views
{
    public partial class MenuActividades : Form
    {
        DescribeImagenController describeImagenController;
        DescribeImagenModel describeImagenModel = new DescribeImagenModel();

        public MenuActividades(string titulo)
        {
            InitializeComponent();
            tituloLabel.Text = titulo;
        }

        //Getter y Setter de los componentes para su utilización
        public Label getLabel1()
        {
            return tituloLabel;
        }

        public void setLabel1(string titulo)
        {
            tituloLabel.Text = titulo; 
        }

        private void MenuActividades_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        public void JuegoTerminado(int i)
        {
            switch (i)
            {
                case 1:
                    describe.ForeColor = Color.Black;
                    describe.Enabled = false;
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
            }
        }

        private void describe_Click(object sender, EventArgs e)
        {
            describeImagenModel.setDescription("varita magica");
            describeImagenModel.setImage(Proyecto_Escuela.Properties.Resources.barita);
            describeImagenController = new DescribeImagenController(describeImagenModel,describeImagenModel, this);
            this.Visible = false;
        }

        public string GetTitulo()
        {
            return tituloLabel.Text;
        }
    }
}
