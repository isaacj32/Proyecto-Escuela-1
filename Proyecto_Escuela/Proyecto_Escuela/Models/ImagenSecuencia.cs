using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Escuela.Models
{
    class ImagenSecuencia: PictureBox
    {
        private int posicion;

        public ImagenSecuencia(int i)
        {
            posicion = i;
        }
    }
}
