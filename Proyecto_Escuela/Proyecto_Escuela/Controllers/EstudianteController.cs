using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Escuela.DAOS;
using Proyecto_Escuela.Models;
using MySql.Data.MySqlClient;

namespace Proyecto_Escuela.Controllers
{
    public class EstudianteController
    {
        ConexionDB conexion = new ConexionDB();
        public EstudianteController()
        {

        }

        public int Agregar(Estudiante estudiante)
        {
            try
            {
                if(conexion.AbrirConexion()== true)
                {
                    int resultado;
                    resultado = DAOS.DAOEstudiante.AgregarEstudiante(conexion.GetConexion(), estudiante);
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

        public void Buscar(Estudiante estudiante, DataGridView tabla)
        {
            try
            {
                if (conexion.AbrirConexion() == true)
                {
                    tabla.DataSource = DAOS.DAOEstudiante.BuscarEstudiante(conexion.GetConexion(), estudiante);
                    conexion.CerrarConexion();
                    
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                conexion.CerrarConexion();
            }            
        }

        public Estudiante Seleccionar(DataGridView tabla)
        {
            try
            {
                if(tabla.SelectedRows.Count == 1)
                {
                    int documento = Convert.ToInt32(tabla.CurrentRow.Cells[0].Value);
                    if (conexion.AbrirConexion() == true)
                    {
                        Estudiante seleccionado = DAOEstudiante.ObtenerUsuario(conexion.GetConexion(),documento);
                        return seleccionado;                        
                    }
                }
            } catch(MySqlException ex)
            {
                MessageBox.Show("Debe seleccionar un registro");
            }
            return null;
        }

        public int Editar(Estudiante estudiante)
        {
            try
            {
                if (conexion.AbrirConexion() == true)
                {
                    int resultado;
                    resultado = DAOS.DAOEstudiante.ModificarEstudiante(conexion.GetConexion(), estudiante);
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
                    resultado = DAOS.DAOEstudiante.ElimminarEstudiante(conexion.GetConexion(), documento);
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
    }
    
}
