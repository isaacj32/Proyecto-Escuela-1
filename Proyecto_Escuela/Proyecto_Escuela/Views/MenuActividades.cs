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
        string titulo;
        public MenuActividades(string titulo)
        {
            this.titulo = titulo;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        #region Getters de componentes
        //Getter y Setter de los componentes para su utilización
        public Label getLabel1()
        {
            return label1;
        }

        public void setLabel1(string titulo)
        {
            label1.Text = titulo;
        } 
        #endregion

        private void botonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void botonSecuencia_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void botonDescripcion_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DescribeImagenController dic = new DescribeImagenController(titulo);
        }
    }
}
