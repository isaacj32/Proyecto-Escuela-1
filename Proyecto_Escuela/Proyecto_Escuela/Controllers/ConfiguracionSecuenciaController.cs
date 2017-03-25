using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Escuela.Models;
using Proyecto_Escuela.DAOS;

namespace Proyecto_Escuela.Controllers
{
    class ConfiguracionSecuenciaController
    {
        public ConfiguracionSecuenciaController()
        {

        }

        public List<DescribeImagenModel> LlenarActividades()
        {
            ConexionDB conexion = new ConexionDB();
            List<DescribeImagenModel> listaActividades = DAOSecuenciaImagen.ListarActividades(conexion.GetConexion());
            return listaActividades;
        }
    }
}
