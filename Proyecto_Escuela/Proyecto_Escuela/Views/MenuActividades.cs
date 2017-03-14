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
        DescribeImagenModel describeImagenModel;

        public MenuActividades(DescribeImagenModel model)
        {
            InitializeComponent();
            describeImagenModel = model;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            describeImagenController = new DescribeImagenController(describeImagenModel);
            this.Dispose();
        }
    }
}
