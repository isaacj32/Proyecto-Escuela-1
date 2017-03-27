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
    class ListaTextosController
    {
        ListaTextos listaTexto;

        public ListaTextosController(Jugador jugador)
        {
            listaTexto = new ListaTextos(jugador);
            listaTexto.Show();
        }

        
    }
}
