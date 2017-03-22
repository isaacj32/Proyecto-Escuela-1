using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Proyecto_Escuela.Models;

namespace Proyecto_Escuela.DAOS
{
    public class DAOTexto
    {
        public DAOTexto()
        {
        }
        public static int AgregarTexto(MySqlConnection conexion, Texto texto)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO Cuento (titulo, texto, tiempo) VALUES('{0}', '{1}', '{2}')", texto.getTitulo(), texto.getTexto(), texto.getTiempo()), conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static int ElimminarJugador(MySqlConnection conexion, string titulo)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("DELETE FROM Cuento WHERE titulo='{0}'", titulo), conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        public static IList<Estudiante> BuscarJugador(MySqlConnection conexion, Jugador jugador)
        {
            List<Estudiante> lista = new List<Estudiante>();

            MySqlCommand comando = new MySqlCommand(string.Format("SELECT titulo, texto, tiempo FROM Jugador WHERE documento LIKE ('%{0}%')", jugador.GetDocumento()), conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Jugador estudiante = new Jugador();
                estudiante.SetDocumento(jugador.GetDocumento().ToString());
                estudiante.SetDesempeño(reader.GetInt32(1), reader.GetInt32(2));
                lista.Add(estudiante);
            }


            return lista;
        }

        public static int ModificarEstudiante(MySqlConnection conexion, Jugador jugador)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("UPDATE Estudiante set aciertos='{1}', errores='{2}' WHERE documento='{0}'", jugador.GetDocumento(), jugador.GetDesempeño().GetAciertos(), jugador.GetDesempeño().GetErrores()), conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static Jugador ObtenerJugador(MySqlConnection conexion, Jugador jugador)
        {
            Jugador estudiante = new Jugador();
            MySqlCommand comando = new MySqlCommand(string.Format("SELECT documento, aciertos, errores FROM Jugador WHERE documento LIKE ('%{0}%')", jugador.GetDocumento()), conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                estudiante.SetDocumento(jugador.GetDocumento().ToString());
                estudiante.SetDesempeño(reader.GetInt32(1), reader.GetInt32(2));

            }
            return estudiante;
        }
    }
}
