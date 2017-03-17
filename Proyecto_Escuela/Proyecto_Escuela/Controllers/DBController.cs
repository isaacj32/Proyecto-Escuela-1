using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Proyecto_Escuela.Controllers
{
    public class DBController
    {
        MySqlConnection conexion;

        public DBController()
        {
            conexion = new MySqlConnection("server=127.0.0.1; port=3306; database=dbEscuela; Uid=admin; pwd=12345");
        }

        public bool AbrirConexcion()
        {
            try
            {
                conexion.Open();
                return true;
            }
            catch(MySqlException ex)
            {
                return false;
                throw ex;
            }
        }

        public bool cerrarConecion()
        {
            try
            {
                conexion.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
                throw ex;
            }
        }
    }
}
