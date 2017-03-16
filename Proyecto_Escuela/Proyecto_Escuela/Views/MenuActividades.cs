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

        private void button1_Click(object sender, EventArgs e)
        {
            describeImagenModel.setDescription("holi");
            describeImagenController = new DescribeImagenController(describeImagenModel, tituloLabel.Text);
            this.Dispose();
        }
    }
}
