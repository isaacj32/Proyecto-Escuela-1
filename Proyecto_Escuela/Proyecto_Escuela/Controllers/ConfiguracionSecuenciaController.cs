using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Escuela.Models;
using Proyecto_Escuela.DAOS;
using Proyecto_Escuela.Views;

namespace Proyecto_Escuela.Controllers
{
    public class ConfiguracionSecuenciaController
    {
        ConexionDB conexion = new ConexionDB();
        ConfiguracionSecuencia configuracionSecuencia;
        public ConfiguracionSecuenciaController()
        {
            configuracionSecuencia = new ConfiguracionSecuencia(this);
        }

        public IList<Texto> LlenarActividades()
        {
            if (conexion.AbrirConexion() == true)
            {
                IList<Texto> listaActividades = DAOTexto.ListarTextos(conexion.GetConexion());
                return listaActividades;
            }
            return null;
        }
    }
}
