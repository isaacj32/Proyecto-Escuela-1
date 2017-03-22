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
    public partial class DescripcionImagen : Form
    {
        DescribeImagenController describeImagen;
        DescribeImagenModel describeImagenModel;
        MenuActividades menuActividades;

        public DescripcionImagen(DescribeImagenController controller, DescribeImagenModel model, MenuActividades menu)
        {
            InitializeComponent();
            describeImagen = controller;
            describeImagenModel = model;
            textoLabel.Text = menu.GetTitulo();
            imagen.BackgroundImage = describeImagenModel.getImagen();
            menuActividades = menu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (respuesta.Enabled == true) { 
            bool acierto = describeImagen.compararRespuesta();
            if (acierto == true)
            {
                imagen.BackgroundImage = Proyecto_Escuela.Properties.Resources.felicitaciones;
                respuesta.Enabled = false;
                }
            else
            {
                imagen.BackgroundImage = Proyecto_Escuela.Properties.Resources.equivocacion;
            }
               
            }
            else
            {

            }
        }

        public string GetRespuesta()
        {
            return respuesta.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            menuActividades.Visible = true;
            this.Dispose();
            menuActividades.JuegoTerminado(1);
        }
    }
}
