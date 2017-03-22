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
    public class LecturaController{
        private VistaLectura vistaTexto;
        

        public LecturaController(Texto texto)
        {
            vistaTexto = new VistaLectura(texto.getTitulo());
            vistaTexto.setLabel3(texto.getTitulo()); 
            vistaTexto.setTextBox(texto.getTexto());
            vistaTexto.setLabel4("Tiempo: " + texto.getTiempo().ToString());
            vistaTexto.setTiempo(texto.getTiempo());
            vistaTexto.getTimer().Start();
            vistaTexto.Show(); 
        }
    }
}
