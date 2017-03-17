using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Escuela.Models;
using MySql.Data.MySqlClient;

namespace Proyecto_Escuela.DAOS
{
    class DAOEstudiante
    {

        public static bool AgregarEstudiante(Estudiante estudiante)
        {
            try
            {
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool ElimminarEstudiante(Estudiante estudiante)
        {
            try
            {
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static Estudiante BuscarEstudiante(MySqlConnection conexion, Estudiante estudiante)
        {
            try
            {
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool ModificarEstudiante(Estudiante estudiante)
        {
            try
            {
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
