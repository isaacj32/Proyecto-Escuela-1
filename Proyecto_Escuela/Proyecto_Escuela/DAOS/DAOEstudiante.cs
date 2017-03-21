using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Escuela.Models;
using MySql.Data.MySqlClient;

namespace Proyecto_Escuela.DAOS
{
    public class DAOEstudiante
    {
        public DAOEstudiante()
        {

        }
        public static int AgregarEstudiante(MySqlConnection conexion, Estudiante estudiante)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO Estudiante (documento, nombre, apellidos, grupo) VALUES('{0}', '{1}', '{2}', '{3}')", estudiante.GetDocumento(), estudiante.GetNombre(), estudiante.GetApellido(), estudiante.GetGrupo()), conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static int ElimminarEstudiante(MySqlConnection conexion, int documento)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("DELETE FROM Estudiante WHERE documento='{0}'", documento), conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        public static IList<Estudiante> BuscarEstudiante(MySqlConnection conexion, Estudiante pEstudiante)
        {
            List<Estudiante> lista = new List<Estudiante>();

            MySqlCommand comando = new MySqlCommand(string.Format("SELECT documento, nombre, apellidos, grupo FROM Estudiante WHERE documento LIKE ('%{0}%') AND nombre LIKE ('%{1}%') AND apellidos LIKE ('%{2}%') AND grupo LIKE ('%{3}%')", pEstudiante.GetDocumento(), pEstudiante.GetNombre(), pEstudiante.GetApellido(), pEstudiante.GetGrupo()), conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Estudiante estudiante = new Estudiante();
                estudiante.SetDocumento(reader.GetString(0));
                estudiante.SetNombre(reader.GetString(1));
                estudiante.SetApellido(reader.GetString(2));
                estudiante.SetGrupo(reader.GetString(3));
                lista.Add(estudiante);
            }
            return lista;
        }

        public static int ModificarEstudiante(MySqlConnection conexion, Estudiante estudiante)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("UPDATE Estudiante set nombre='{1}', apellidos='{2}', grupo='{3}' WHERE documento='{0}'", estudiante.GetDocumento(), estudiante.GetNombre(), estudiante.GetApellido(), estudiante.GetGrupo()), conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static Estudiante ObtenerUsuario(MySqlConnection conexion, int documento)
        {
            Estudiante estudiante = new Estudiante();

            MySqlCommand comando = new MySqlCommand(string.Format("SELECT documento, nombre, apellidos, grupo FROM Estudiante WHERE documento LIKE ('%{0}%')", documento), conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                estudiante.SetDocumento(reader.GetString(0));
                estudiante.SetNombre(reader.GetString(1));
                estudiante.SetApellido(reader.GetString(2));
                estudiante.SetGrupo(reader.GetString(3));
            }

            return estudiante;
        }

        
    }
}
