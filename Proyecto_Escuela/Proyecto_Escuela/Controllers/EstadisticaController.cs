using MySql.Data.MySqlClient;
using Proyecto_Escuela.DAOS;
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
    class EstadisticaController
    {
        ConexionDB conexion = new ConexionDB();

        public EstadisticaController()
        {
        }

        public void Buscar(Jugador jugador, DataGridView tabla, int x)
        {
            try
            {
                if (conexion.AbrirConexion() == true)
                {
                    jugador = DAOJugador.ObtenerJugador(conexion.GetConexion(), jugador);
                    tabla.Rows.Clear();                   
                    tabla.Rows.Add(jugador.GetDocumento(), jugador.GetNombre(), jugador.GetApellido(), jugador.GetGrado(), jugador.GetGrupo(), jugador.GetDesempeño().GetAciertos(), jugador.GetDesempeño().GetErrores());
                    Console.WriteLine("holi " + jugador.GetDocumento());                    
                    conexion.CerrarConexion();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                conexion.CerrarConexion();
            }
        }
    }
}
