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
using System.Drawing;

namespace Proyecto_Escuela.Controllers
{
    public class ConfiguracionDescribeControler
    {
        ConfigDescribeImagen describeImagen;
        ConexionDB conexion = new ConexionDB();

        public ConfiguracionDescribeControler()
        {
            describeImagen = new ConfigDescribeImagen(this);
            describeImagen.Show();
        }
        

        public int Agregar(DescribeImagenModel model)
        {
            try
            {
                if (conexion.AbrirConexion() == true)
                {
                    int resultado;
                    resultado = DAOS.DAODescribeImagen.AgregarActividad(conexion.GetConexion(), model);
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

        public void Buscar(ComboBox combo)
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

        public void ListarImagenes(DataGridView tabla, string titulo)
        {
            try
            {
                if (conexion.AbrirConexion() == true)
                {
                    DescribeImagenModel lista = DAOS.DAODescribeImagen.ListarActividades(conexion.GetConexion(), titulo);
                    tabla.Rows.Clear();
                    for (int i = 0; i < lista.GetImagenes().Count; i++)
                    {
                        tabla.Rows.Add(lista.GetImagen(i).GetDescripcion(), Image.FromFile(lista.GetImagen(i).GetRuta()));
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
