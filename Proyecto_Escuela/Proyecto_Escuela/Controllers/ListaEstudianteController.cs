using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Escuela.Views;
using System.Windows.Forms;
using Proyecto_Escuela.DAOS;
using MySql.Data.MySqlClient;
using Proyecto_Escuela.Models;

namespace Proyecto_Escuela.Controllers
{
    public class ListaEstudianteController
    {
        ConexionDB conexion = new ConexionDB();           
        ListaEstudiantes listaEstudiantes;

        public ListaEstudianteController()
        {
            listaEstudiantes = new ListaEstudiantes(this);
            listaEstudiantes.Show();

        }
        public void Listar(DataGridView tabla)
        {
            try
            {
                if (conexion.AbrirConexion() == true)
                {
                    IList<Estudiante> lista = DAOS.DAOEstudiante.ListarEstudiantes(conexion.GetConexion());
                    List<List<Imagen>> filas = new List<List<Imagen>>();
                    for (int i = 0; i < lista.Count; i += 4)
                    {
                        List<Imagen> estudiantes = new List<Imagen>();
                        for (int j = 0; j < 4; j++)
                        {
                            Imagen boton = new Imagen();
                            try
                            {
                                boton.SetDescripcion(lista[i + j].GetNombre());
                                boton.SetImagen(Properties.Resources.buho);
                                estudiantes.Add(boton);
                            }
                            catch
                            {
                            }
                        }
                        filas.Add(estudiantes);


                    }
                    tabla.Rows.Clear();
                    for (int i = 0; i < filas.Count; i++)
                    {
                        switch (filas[i].Count)
                        {
                            case 1:

                                tabla.Rows.Add(filas[i][0].GetImagen());
                                break;
                            case 2:
                                tabla.Rows.Add(filas[i][0].GetImagen(), filas[i][1].GetImagen());

                                break;
                            case 3:
                                tabla.Rows.Add(filas[i][0].GetImagen(), filas[i][1].GetImagen(), filas[i][2].GetImagen());

                                break;
                            case 4:
                                tabla.Rows.Add(filas[i][0].GetImagen(), filas[i][1].GetImagen(), filas[i][2].GetImagen(), filas[i][3].GetImagen());
                                break;
                        }
                    }
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
