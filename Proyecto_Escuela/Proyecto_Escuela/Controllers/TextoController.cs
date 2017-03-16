using Proyecto_Escuela.Models;
using Proyecto_Escuela.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Escuela.Controllers
{
    class TextoController
    {
        //private Text texto = new Text();
        //private Texto vistaTexto = new Texto();
        private SecuenciaImagenes secuencia = new SecuenciaImagenes(4);

        public TextoController()
        {
            //vistaTexto.setLabel3(texto.getTitulo());
            //vistaTexto.setTextBox(texto.getTexto());
            //vistaTexto.setLabel4("Tiempo: " + texto.getTiempo().ToString());
            //vistaTexto.setTiempo(texto.getTiempo());
            //vistaTexto.getTimer().Start();
            //vistaTexto.Show();
            secuencia.Show();
        }
    }
}
