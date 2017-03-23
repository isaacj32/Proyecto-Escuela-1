using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        DescribeImagenController describeImagenController;
        DescribeImagenModel describeImagenModel;
        MenuActividades menuActividades;
        int indice=0;

        public DescripcionImagen(DescribeImagenController controller, DescribeImagenModel model, MenuActividades menu)
        {
            InitializeComponent();
            describeImagenController = controller;
            describeImagenModel = model;
            textoLabel.Text = menu.GetTitulo();
            menuActividades = menu;
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

        private void DescripcionImagen_Load(object sender, EventArgs e)
        {
            imagen.BackgroundImage = describeImagenModel.GetImagen(0).BackgroundImage;
        }

        private void probar_Click(object sender, EventArgs e)
        {
            if (respuesta.Enabled == true)
            {
                bool acierto = describeImagenController.compararRespuesta(indice);
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
        }

        private void reintentar_Click(object sender, EventArgs e)
        {
            imagen.BackgroundImage = describeImagenModel.GetImagen(indice).Image;
        }
    }
}
