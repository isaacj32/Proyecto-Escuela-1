using Proyecto_Escuela.Controllers;
using Proyecto_Escuela.Models;
using Proyecto_Escuela.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Escuela
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Texto t = new Texto();
            ListaTextosController ltc = new ListaTextosController(t);      
            Application.Run();
        }
    }
}
