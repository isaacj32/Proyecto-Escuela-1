using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Escuela.Views;

namespace Proyecto_Escuela.Controllers
{
    public class ListaEstudianteController
    {
        ListaEstudiantes listaEstudiantes;

        public ListaEstudianteController()
        {
            listaEstudiantes = new ListaEstudiantes();
            listaEstudiantes.Show();
        }
    }
}
