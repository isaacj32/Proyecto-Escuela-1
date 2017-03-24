using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MySql.Data.MySqlClient;
using Proyecto_Escuela.Models;

namespace Proyecto_Escuela.DAOS
{
    class DAOSecuenciaImagen
    {
        public DAOSecuenciaImagen()
        {
        }

        public static int AgregarActividad(MySqlConnection conexion, SecuenciaImagenModel modelo)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO SecuenciaImagen (titulo, imagen 1, imagen 2, imagen 3, imagen 4, imagen 5, imagen 6, imagen 7, imagen 8, secuencia) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')", modelo.GetTitulo(), modelo.GetImagen(0).GetRuta(), modelo.GetImagen(1).GetRuta(), modelo.GetImagen(2).GetRuta(), modelo.GetImagen(3).GetRuta(), modelo.GetImagen(4).GetRuta(), modelo.GetImagen(5).GetRuta(), modelo.GetImagen(6).GetRuta(), modelo.GetImagen(7).GetRuta(), modelo.GetSecuencia()), conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static int ElimminarActividad(MySqlConnection conexion, int documento)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("DELETE FROM SecuenciaImagen WHERE titulo='{0}'", documento), conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static IList<SecuenciaImagenModel> BuscarActividad(MySqlConnection conexion, DescribeImagenModel model, int i)
        {
            Imagen imagen = new Imagen();
            List<SecuenciaImagenModel> lista = new List<SecuenciaImagenModel>();
            MySqlCommand comando;
            comando = new MySqlCommand(string.Format("SELECT * FROM SecuenciaImagen WHERE titulo LIKE ('%{0}%')", model.GetTexto()), conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                
                SecuenciaImagenModel actividad = new SecuenciaImagenModel(reader.GetString(9));


                actividad.SetTexto(reader.GetString(0));

                imagen.SetRuta(reader.GetString(1));
                actividad.SetImagen(imagen, 0);

                imagen = new Imagen();
                imagen.SetRuta(reader.GetString(2));
                actividad.SetImagen(imagen, 1);

                imagen = new Imagen();
                imagen.SetRuta(reader.GetString(3));
                actividad.SetImagen(imagen, 2);

                imagen = new Imagen();
                imagen.SetRuta(reader.GetString(4));
                actividad.SetImagen(imagen, 3);

                imagen = new Imagen();
                imagen.SetRuta(reader.GetString(5));
                actividad.SetImagen(imagen, 4);

                imagen = new Imagen();
                imagen.SetRuta(reader.GetString(6));
                actividad.SetImagen(imagen, 5);

                imagen = new Imagen();
                imagen.SetRuta(reader.GetString(7));
                actividad.SetImagen(imagen, 6);

                imagen = new Imagen();
                imagen.SetRuta(reader.GetString(8));
                actividad.SetImagen(imagen, 7);



                lista.Add(actividad);
            }


            return lista;
        }

        public static int ModificarActividad(MySqlConnection conexion, DescribeImagenModel modelo)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("UPDATE DescribeImagen set imagen 1='{1}', imagen 2='{2}', imagen 3='{3}', imagen 4='{4}', imagen 5='{5}' WHERE titulo='{0}'", modelo.GetTexto(), modelo.GetImagen(0).GetRuta(), modelo.GetImagen(1).GetRuta(), modelo.GetImagen(2).GetRuta(), modelo.GetImagen(3).GetRuta(), modelo.GetImagen(4).GetRuta()), conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static DescribeImagenModel ObtenerActividad(MySqlConnection conexion, string titulo)
        {
            Estudiante estudiante = new Estudiante();
            Imagen imagen = new Imagen();
            DescribeImagenModel actividad = new DescribeImagenModel();

            MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM DescribeImagen WHERE titulo='{0}'", titulo), conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {

                actividad.SetTexto(reader.GetString(0));
                imagen.SetRuta(reader.GetString(1));
                actividad.SetImagen(imagen, 0);

                imagen = new Imagen();
                imagen.SetRuta(reader.GetString(2));
                actividad.SetImagen(imagen, 1);

                imagen = new Imagen();
                imagen.SetRuta(reader.GetString(3));
                actividad.SetImagen(imagen, 2);

                imagen = new Imagen();
                imagen.SetRuta(reader.GetString(4));
                actividad.SetImagen(imagen, 3);

                imagen = new Imagen();
                imagen.SetRuta(reader.GetString(5));
                actividad.SetImagen(imagen, 4);
            }

            return actividad;
        }

        public static List<DescribeImagenModel> ListarActividades(MySqlConnection conexion)
        {
            List<DescribeImagenModel> lista = new List<DescribeImagenModel>();
            MySqlCommand comando = new MySqlCommand("SELECT * FROM DescribeImagen", conexion);
            Imagen imagen = new Imagen();
            MySqlDataReader reader = comando.ExecuteReader();



            while (reader.Read())
            {
                DescribeImagenModel actividad = new DescribeImagenModel();

                actividad.SetTexto(reader.GetString(0));
                imagen.SetRuta(reader.GetString(1));
                actividad.SetImagen(imagen, 0);

                imagen = new Imagen();
                imagen.SetRuta(reader.GetString(2));
                actividad.SetImagen(imagen, 1);

                imagen = new Imagen();
                imagen.SetRuta(reader.GetString(3));
                actividad.SetImagen(imagen, 2);

                imagen = new Imagen();
                imagen.SetRuta(reader.GetString(4));
                actividad.SetImagen(imagen, 3);

                imagen = new Imagen();
                imagen.SetRuta(reader.GetString(5));
                actividad.SetImagen(imagen, 4);


                lista.Add(actividad);
            }
            return lista;
        }
    }
}
