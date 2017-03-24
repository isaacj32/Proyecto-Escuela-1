using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Proyecto_Escuela.DAOS;
using Proyecto_Escuela.Models;
using System.Windows.Forms;

namespace Proyecto_Escuela.Controllers
{
    public class TextoController
    {
        ConexionDB conexion = new ConexionDB();
        public TextoController()
        {

        }

        public int Agregar(Texto texto)
        {
            try
            {
                if (conexion.AbrirConexion() == true)
                {
                    int resultado;
                    resultado = DAOS.DAOTexto.AgregarTexto(conexion.GetConexion(), texto);
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

        public void Buscar(string titulo, DataGridView tabla)
        {
            try
            {
                if (conexion.AbrirConexion() == true)
                {
                    IList<Texto> lista = DAOS.DAOTexto.BuscarTexto(conexion.GetConexion(), titulo);
                    tabla.Rows.Clear();
                    for (int i = 0; i < lista.Count; i++)
                    {
                        tabla.Rows.Add(lista[i].getTitulo(), lista[i].getTiempo());
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

        public Texto Seleccionar(DataGridView tabla)
        {

            if (tabla.SelectedRows.Count == 1)
            {
                string titulo = Convert.ToString(tabla.CurrentRow.Cells[0].Value);
                if (conexion.AbrirConexion() == true)
                {
                    Texto texto = DAOTexto.ObtenerTexto(conexion.GetConexion(), titulo);
                    conexion.CerrarConexion();
                    return texto;
                }
            }

            return null;
        }

        public int Editar(Texto texto)
        {
            try
            {
                if (conexion.AbrirConexion() == true)
                {
                    int resultado;
                    resultado = DAOS.DAOTexto.ModificarTexto(conexion.GetConexion(), texto);
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

        public int Eliminar(string titulo)
        {
            try
            {
                if (conexion.AbrirConexion() == true)
                {
                    int resultado;
                    resultado = DAOS.DAOTexto.EliminarTexto(conexion.GetConexion(), titulo);
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

        public void Listar(DataGridView tabla, int index)
        {
            try
            {

                if (conexion.AbrirConexion() == true)
                {
                    tabla.Rows.Clear();
                    IList<Texto> lista = DAOS.DAOTexto.ListarTextos(conexion.GetConexion());
                    if (index == 0)
                    {
                        for (int i = 0; i < lista.Count; i++)
                        {
                            tabla.Rows.Add(lista[i].getTitulo(), lista[i].getTiempo());
                        }
                    }
                    else if (index == 1)
                    {
                        for (int i = 0; i < lista.Count; i++)
                        {
                            tabla.Rows.Add(lista[i].getTitulo());
                        }
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