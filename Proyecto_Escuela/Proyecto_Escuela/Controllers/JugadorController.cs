using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Proyecto_Escuela.Models;
using Proyecto_Escuela.DAOS;

namespace Proyecto_Escuela.Controllers
{
    
    public class JugadorController
    {
        private ConexionDB conexion = new ConexionDB();

        public JugadorController()
        {
        }

        public void Listar(DataGridView tabla)
        {
            try
            {
                if (conexion.AbrirConexion() == true)
                {
                    IList<Jugador> lista = DAOJugador.ListarJugadores(conexion.GetConexion());
                    tabla.Rows.Clear();
                    for (int i = 0; i < lista.Count; i++)
                    {
                        Estudiante estudiante = DAOEstudiante.ObtenerEstudiante(conexion.GetConexion(),lista[0].GetDocumento());
                        lista[0].SetNombre(estudiante.GetNombre());
                        lista[0].SetApellido(estudiante.GetApellido());
                        lista[0].SetGrado(estudiante.GetGrado());
                        lista[0].SetGrupo(estudiante.GetGrado());
                    }
                    for (int i = 0; i < lista.Count; i++)
                    {
                        tabla.Rows.Add(lista[i].GetDocumento(), lista[i].GetNombre(), lista[i].GetApellido(), lista[i].GetGrado(), lista[i].GetGrupo(), lista[i].GetDesempeño().GetAciertos(), lista[i].GetDesempeño().GetErrores());
                    }
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
