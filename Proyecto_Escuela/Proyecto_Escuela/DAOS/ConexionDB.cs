using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Proyecto_Escuela.DAOS
{
    class ConexionDB
    {
        MySqlConnection conexion;

        public ConexionDB()
        {
            conexion = new MySqlConnection("server=localhost; port=3306; database=dbescuela; Uid=root; pwd=1234");
        } 

        public bool AbrirCOnexion()
        {
            try
            {
                conexion.Open();
                return true;
            }
            catch(MySqlException e)
            {
                return false;
                throw e;
            }
        }

        public bool CerrarConexion()
        {
            try
            {
                conexion.Close();
                return true;
            }
            catch(MySqlException e)
            {
                return false;
                throw e;

            }
        }
    }
}
