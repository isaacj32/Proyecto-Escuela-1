using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Escuela.Models;
using Proyecto_Escuela.DAOS;
using Proyecto_Escuela.Views;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proyecto_Escuela.Controllers
{
    public class ConfiguracionSecuenciaController
    {
        ConexionDB conexion = new ConexionDB();
        ConfiguracionSecuencia configuracionSecuencia;
        public ConfiguracionSecuenciaController()
        {
            configuracionSecuencia = new ConfiguracionSecuencia(this);
            configuracionSecuencia.Show();
        }

        public void BuscarTextos(ComboBox combo)
        {
            try
            {
                if (conexion.AbrirConexion() == true)
                {
                    IList<Texto> lista = DAOTexto.ListarTextos(conexion.GetConexion());

                    for (int i = 0; i < lista.Count; i++)
                    {
                        combo.Items.Add(lista[i].getTitulo());
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
