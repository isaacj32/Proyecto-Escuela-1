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
    class LecturaController
    {
        Texto texto;
        VistaLectura vistaTexto;         

        public LecturaController(Texto texto)
        {
            vistaTexto = new VistaLectura();
            this.texto = texto;
            vistaTexto.setLabel3(texto.getTitulo());
            vistaTexto.setTextBox(texto.getTexto());
            vistaTexto.setLabel4("Tiempo: " + texto.getTiempo().ToString());
            vistaTexto.setTiempo(texto.getTiempo());
            vistaTexto.getTimer().Start();
            vistaTexto.Show();
            vistaTexto.getButonActividades().Click += new EventHandler(Click);
        }

        public void Click(object sender, EventArgs e)
        {
            MenuActividadesController mac = new MenuActividadesController(texto.getTitulo());
            vistaTexto.Dispose();
        }
    }
}
