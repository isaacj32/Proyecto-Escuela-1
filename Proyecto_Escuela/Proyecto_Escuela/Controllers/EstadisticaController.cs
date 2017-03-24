using MySql.Data.MySqlClient;
using Proyecto_Escuela.DAOS;
using Proyecto_Escuela.Models;
using Proyecto_Escuela.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Escuela.Controllers
{
    class EstadisticaController
    {
        ConexionDB conexion = new ConexionDB();

        public EstadisticaController()
        {
        }

        public void Buscar(Jugador jugador, DataGridView tabla, int x)
        {
            try
            {
                if (conexion.AbrirConexion() == true)
                {
                    jugador = DAOJugador.ObtenerJugador(conexion.GetConexion(), jugador);
                    tabla.Rows.Clear();                   
                    tabla.Rows.Add(jugador.GetDocumento(), jugador.GetNombre(), jugador.GetApellido(), jugador.GetGrado(), jugador.GetGrupo(), jugador.GetDesempeño().GetAciertos(), jugador.GetDesempeño().GetErrores());
                    Console.WriteLine("holi " + jugador.GetDocumento());                    
                    conexion.CerrarConexion();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                conexion.CerrarConexion();
            }
        }

        public ModeloEstadistica CalcularEstadisticas(DataGridView tabla)
        {
            ModeloEstadistica me = new ModeloEstadistica();
            me.setMedia(CalcularMedia(tabla));
            me.setMediana(CalcularMediana(tabla));
            me.setModa(CalcularModa(tabla));
            return me;       
        }

        //Métopdo para calcular la media
        public double CalcularMedia(DataGridView tabla)
        {           
            int total = 0;
            double media = 0.0;
            int [] intentos = Intentos(tabla);
            int suma = 0;

            for (int i = 0; i < intentos.Length; i++)
            {
                suma = suma + intentos[i];
            }
            media = suma / total;

            return media;
        }

        //Método para calcular la mediana
        public double CalcularMediana(DataGridView tabla)
        {
            int[] arreglo = Intentos(tabla);                              

            Array.Sort(arreglo);

            if (arreglo.Length % 2 == 0)
            {
                return (arreglo[(arreglo.Length -1)/ 2] + arreglo[((arreglo.Length -1)/ 2) + 1]) / 2;
            }
            else return arreglo[(arreglo.Length-1) / 2];            
        }

        //Método para calcular la moda
        public int CalcularModa(DataGridView tabla)
        {
            int[] intentos = Intentos(tabla);
            int moda = 0;
            int numMayor = 0;
            int contador = 0;

            for (int i = 0; i < intentos.Length; i++)
            {
                for (int j = 0; j < intentos.Length; j++)
                {
                    if (intentos[i] == intentos[j])
                    {
                        contador = contador + 1;
                    }
                }

                if (contador > numMayor)
                {
                    moda = intentos[i];
                    numMayor = contador;
                }
                
            }

            return moda;
        }

        //Método que calcula el número de intentos de cada jugador
        public int [] Intentos(DataGridView tabla)
        {
            int[] intentos = new int [tabla.Rows.Count];
            int pos = 0;
            int sumaAciertos = 0;
            int sumaErrores = 0;

            foreach (DataGridView col in tabla.Columns)
            {
                if (col.Name == "Aciertos")
                {
                    int aciertos = (int)col.CurrentCell.Value;
                    sumaAciertos += aciertos;
                }
                if (col.Name == "Errores")
                {
                    int errores = (int)col.CurrentCell.Value;
                    sumaErrores += errores;
                } 
                intentos[pos]= sumaAciertos + sumaErrores;
                pos = pos + 1;
            }            

            return intentos;
        }
    }
}
