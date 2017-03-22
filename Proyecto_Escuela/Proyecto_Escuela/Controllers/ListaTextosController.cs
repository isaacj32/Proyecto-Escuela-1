


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
        ListaTextos lt;
        Texto texto;

        public ListaTextosController(Texto texto)
        {
            this.texto = texto;
            lt = new ListaTextos(texto);            
            lt.getLista().CellClick += new DataGridViewCellEventHandler(ClickEnCelda);
            lt.Show();
        }

        //Evento que lleva a la ventana de actividades relacionadas a un texto
        //Cuando se selecciona de la lista de textos
        public void ClickEnCelda(object sender, DataGridViewCellEventArgs e)
        {
            string titulo = lt.getLista()[0, e.RowIndex].Value.ToString();
            LecturaController lc = new LecturaController(texto);
            //MenuActividadesController mac = new MenuActividadesController(titulo);
            lt.Dispose();
        }
    }
}
