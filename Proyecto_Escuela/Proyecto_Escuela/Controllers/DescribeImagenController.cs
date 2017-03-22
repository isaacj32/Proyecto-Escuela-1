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
        DescripcionImagen describeImagenView;
        DescribeImagenModel describeImagenModel;
        

        public DescribeImagenController(DescribeImagenModel frame,DescribeImagenModel model, MenuActividades menu)
        {
            describeImagenView = new DescripcionImagen(this, model, menu);
            describeImagenView.Show();
            describeImagenModel = frame;           

        }
        public bool compararRespuesta()
        {
            string texto1 = describeImagenModel.getDescription();
            string texto2 = describeImagenView.GetRespuesta();
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
