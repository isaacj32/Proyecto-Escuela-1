using Proyecto_Escuela.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Escuela.Views;

namespace Proyecto_Escuela.Controllers
{
    public class DescribeImagenController
    {
        DescripcionImagen div;
        DescribeImagenModel dim;

        public DescribeImagenController(string titulo)
        {
            div = new DescripcionImagen();
            dim = new DescribeImagenModel();
            div.getButton1().Click += new EventHandler(Click);
            div.Show();
        }

        public void Click(object sender, EventArgs e)
        {
            bool acierto = CompararRespuesta();
            if (acierto == true)
            {
                div.getImagen().BackgroundImage = Proyecto_Escuela.Properties.Resources.felicitaciones;
            }
        }

        public bool CompararRespuesta()
        {
            string texto1 = dim.getDescripcion();
            string texto2 = div.getRespuesta().Text;
            return compararTextos(texto1, texto2);
        }

        private bool compararTextos(string texto1, string texto2)
        {
            if (texto1.Equals(texto2))
            {
                return true;
            }
            return false;
        }
    }    
}
