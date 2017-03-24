using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Escuela.Views;
using Proyecto_Escuela.Models;

namespace Proyecto_Escuela.Controllers
{
    public class SecuenciaImagenController
    {
        private SecuenciaImagenes secuenciaImagenes;
        private SecuenciaImagenModel secuenciaImagenModel;

        public SecuenciaImagenController(int n, string titulo)
        {
            secuenciaImagenes = new Views.SecuenciaImagenes(n);
            secuenciaImagenes.Show();
        }


    }
}
