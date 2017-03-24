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
        Imagen imagenAux;
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
        private void DescripcionImagen_Load(object sender, EventArgs e)
        {
            imagenAux = describeImagenModel.GetImagen(0);
            imagen.BackgroundImage = imagenAux.GetImagen();
            if (indice == describeImagenModel.GetImagenes().Count-1)
            {
                siguiente.Enabled = false;
            }
            anterior.Enabled = false;
            reintentar.Enabled = false;
        }

        private void probar_Click(object sender, EventArgs e)
        {
            intentos.Text = (int.Parse(intentos.Text) + 1).ToString();
            bool acierto = describeImagenController.compararRespuesta(indice, respuesta.Text);
            if (acierto == true)
            {
                imagen.BackgroundImage = Proyecto_Escuela.Properties.Resources.felicitaciones;
                imagenAux.SetDescripcion(respuesta.Text);
                imagenAux.SetPosicion(1);
                respuesta.Enabled = false;
                reintentar.Enabled = false;
                aciertos.Text = (int.Parse(aciertos.Text) + 1).ToString();
            }
            else
            {
                imagen.BackgroundImage = Proyecto_Escuela.Properties.Resources.equivocacion;
                reintentar.Enabled = true;
                errores.Text = (int.Parse(errores.Text) + 1).ToString();
            }
            probar.Enabled = false;
        }

        private void reintentar_Click(object sender, EventArgs e)
        {
            respuesta.Clear();
            probar.Enabled = true;
            imagen.BackgroundImage = imagenAux.GetImagen();
        }

        private void siguiente_Click(object sender, EventArgs e)
        {
            indice++;
            if (indice == describeImagenModel.GetImagenes().Count - 1)
            {
                siguiente.Enabled = false;
            }
            respuesta.Enabled = true;
            probar.Enabled = true;
            reintentar.Enabled = false;
            anterior.Enabled = true;
            imagenAux = describeImagenModel.GetImagen(indice);
            imagen.BackgroundImage = imagenAux.GetImagen();
            if (imagenAux.GetPosicion() == 1)
            {
                respuesta.Enabled = false;
                respuesta.Text = imagenAux.GetDescripcion();
                probar.Enabled = false;
            }
        }

        private void anterior_Click(object sender, EventArgs e)
        {
            indice--;
            if (indice == 0)
            {
                anterior.Enabled = false;
            }
            respuesta.Enabled = true;
            probar.Enabled = true;
            reintentar.Enabled = false;
            siguiente.Enabled = true;
            imagenAux = describeImagenModel.GetImagen(indice);
            imagen.BackgroundImage = imagenAux.GetImagen();
            if (imagenAux.GetPosicion() == 1)
            {
                respuesta.Enabled = false;
                respuesta.Text = imagenAux.GetDescripcion();
                probar.Enabled = false;
            }
        }

        private void terminar_Click(object sender, EventArgs e)
        {
            menuActividades.Visible = true;
            this.Dispose();
            if (int.Parse(aciertos.Text) == describeImagenModel.GetImagenes().Count)
            {
                menuActividades.JuegoTerminado(1);

            }
        }
    }
}
