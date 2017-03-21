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
            conexion = new MySqlConnection("server="+Properties.Settings.Default.DBServer+ "; port=" + Properties.Settings.Default.DBPort + "; database=" + Properties.Settings.Default.DBName + "; Uid=" + Properties.Settings.Default.DBUser + "; pwd=" + Properties.Settings.Default.DBPassword);

        }

        public bool AbrirConexion()
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

        public MySqlConnection GetConexion()
        {
            return conexion;
        }
    }
}
