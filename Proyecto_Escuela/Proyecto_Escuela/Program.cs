using Proyecto_Escuela.Controllers;
using Proyecto_Escuela.Models;
using Proyecto_Escuela.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Escuela.DAOS;
using MySql.Data.MySqlClient;

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

            ConexionDB conexion = new ConexionDB();
            try
            {
                if (conexion.AbrirConexion() == true)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    //conexion.CerrarConexion();
                    new Inicio().Show();
                    Application.Run();

        }
    }catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
                
            
        }
    }
}
