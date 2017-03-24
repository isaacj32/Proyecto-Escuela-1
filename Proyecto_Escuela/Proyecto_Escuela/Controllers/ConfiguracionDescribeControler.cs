using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Escuela.Views;
using MySql.Data.MySqlClient;
using Proyecto_Escuela.Models;
using Proyecto_Escuela.DAOS;
using System.Windows.Forms;

namespace Proyecto_Escuela.Controllers
{
    public class ConfiguracionDescribeControler
    {
        ConfiguracionDescribeImagen describeImagen = new ConfiguracionDescribeImagen();
        ConexionDB conexion = new ConexionDB();

        public ConfiguracionDescribeControler()
        {
            describeImagen.Show();
        }
        

        public int Agregar(DescribeImagenModel estudiante)
        {
            try
            {
                if (conexion.AbrirConexion() == true)
                {
                    int resultado;
                    resultado = DAOS.DAODescribeImagen.AgregarActividad(conexion.GetConexion(), estudiante);
                    conexion.CerrarConexion();
                    return resultado;
                }
                conexion.CerrarConexion();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                conexion.CerrarConexion();
            }
            return 0;
        }

        public void Buscar(DescribeImagenModel modelo, DataGridView tabla)
        {
            try
            {
                if (conexion.AbrirConexion() == true)
                {
                    IList<DescribeImagenModel> lista = DAOS.DAODescribeImagen.BuscarActividad(conexion.GetConexion(), modelo);
                    tabla.Rows.Clear();
                    for (int i = 0; i < lista.Count; i++)
                    {
                        
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

        public DescribeImagenModel Seleccionar(DataGridView tabla, string titulo)
        {

                if (conexion.AbrirConexion() == true)
                {
                    DescribeImagenModel seleccionado = DAODescribeImagen.ObtenerActividad(conexion.GetConexion(), titulo);
                    conexion.CerrarConexion();
                    return seleccionado;
                }

            return null;
        }

        public int Editar(DescribeImagenModel modelo)
        {
            try
            {
                if (conexion.AbrirConexion() == true)
                {
                    int resultado;
                    resultado = DAOS.DAODescribeImagen.ModificarActividad(conexion.GetConexion(), modelo);
                    conexion.CerrarConexion();
                    return resultado;
                }
                conexion.CerrarConexion();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                conexion.CerrarConexion();
            }
            return 0;
        }

        public int Eliminar(int documento)
        {
            try
            {
                if (conexion.AbrirConexion() == true)
                {
                    int resultado;
                    resultado = DAOS.DAODescribeImagen.EliminarActividad(conexion.GetConexion(), documento);
                    conexion.CerrarConexion();
                    return resultado;
                }
                conexion.CerrarConexion();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                conexion.CerrarConexion();
            }
            return 0;
        }

        public void Listar(DataGridView tabla)
        {
            try
            {
                if (conexion.AbrirConexion() == true)
                {
                    IList<DescribeImagenModel> lista = DAOS.DAODescribeImagen.ListarActividades(conexion.GetConexion());
                    tabla.Rows.Clear();
                    for (int i = 0; i < lista.Count; i++)
                    {
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
