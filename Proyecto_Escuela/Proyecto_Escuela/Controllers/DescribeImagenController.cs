using Proyecto_Escuela.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Escuela.Views;
using System.Drawing;

namespace Proyecto_Escuela.Controllers
{
    public class DescribeImagenController
    {
        DescripcionImagen describeImagenView;
        DescribeImagenModel describeImagenModel;
        

        public DescribeImagenController(DescribeImagenModel frame,DescribeImagenModel model, MenuActividades menu)
        {
            describeImagenModel = frame;
            ListarImagenes();
            describeImagenView = new DescripcionImagen(this, model, menu);
            describeImagenView.Show();

        }
        public bool compararRespuesta(int i, string respuesta)
        {
            string texto1 = describeImagenModel.GetImagen(i).GetDescripcion();
            string texto2 = respuesta;
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

        private void ListarImagenes()
        {
            Imagen imagen = new Imagen();
            imagen.SetDescripcion("varita magica");
            imagen.SetImagen(Proyecto_Escuela.Properties.Resources.barita);
            describeImagenModel.AgregarImagen(imagen);
        }
    }    
}
