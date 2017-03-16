﻿using System;
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
    public partial class DescripcionImagen : Form
    {
        DescribeImagenController describeImagen;

        public DescripcionImagen(DescribeImagenController controller, String texto)
        {
            InitializeComponent();
            describeImagen = controller;
            textoLabel.Text = texto;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (respuesta.Enabled == true) { 
            bool acierto = describeImagen.compararRespuesta();
            if (acierto == true)
            {
                imagen.BackgroundImage = Proyecto_Escuela.Properties.Resources.felicitaciones;
            }
            else
            {
                imagen.BackgroundImage = Proyecto_Escuela.Properties.Resources.equivocacion;
            }

        }
        }

        public string GetRespuesta()
        {
            return respuesta.Text;
        }
    }
}
