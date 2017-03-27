using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Proyecto_Escuela.Models;

namespace Proyecto_Escuela.DAOS
{
    public class DAODescribeImagen
    {
        public DAODescribeImagen()
        {
        }

        public static int AgregarActividad(MySqlConnection conexion, DescribeImagenModel modelo)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO DescribeImagen (titulo, imagen1, imagen2, imagen3, imagen4, imagen5, palabra1, palabra2, palabra3, palabra4, palabra5 ) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}')", modelo.GetTitulo(), modelo.GetImagen(0).GetRuta(), modelo.GetImagen(1).GetRuta(), modelo.GetImagen(2).GetRuta(), modelo.GetImagen(3).GetRuta(), modelo.GetImagen(4).GetRuta(), modelo.GetImagen(0).GetDescripcion(), modelo.GetImagen(1).GetDescripcion(), modelo.GetImagen(2).GetDescripcion(), modelo.GetImagen(3).GetDescripcion(), modelo.GetImagen(4).GetDescripcion()), conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static int ModificarActividad(MySqlConnection conexion, DescribeImagenModel modelo)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("UPDATE DescribeImagen set imagen 1='{1}', imagen 2='{2}', imagen 3='{3}', imagen 4='{4}', imagen 5='{5}', palabra 1='{6}', palabra 2='{7}', palabra 3='{8}', palabra 4='{9}', palabra 5='{10}' WHERE titulo='{0}'", modelo.GetTitulo(), modelo.GetImagen(0).GetRuta(), modelo.GetImagen(1).GetRuta(), modelo.GetImagen(2).GetRuta(), modelo.GetImagen(3).GetRuta(), modelo.GetImagen(4).GetRuta(), modelo.GetImagen(0).GetDescripcion(), modelo.GetImagen(1).GetDescripcion(), modelo.GetImagen(2).GetDescripcion(), modelo.GetImagen(3).GetDescripcion(), modelo.GetImagen(4).GetDescripcion()), conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static DescribeImagenModel ObtenerActividad(MySqlConnection conexion, string titulo)
        {
            DescribeImagenModel actividad = new DescribeImagenModel();
            MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM DescribeImagen WHERE titulo='{0}'", titulo), conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                actividad.SetTitulo(reader.GetString(0));
                Imagen imagen = new Imagen();
                imagen.SetRuta(reader.GetString(1));
                imagen.SetDescripcion(reader.GetString(6));
                actividad.AgregarImagen(imagen);

                imagen = new Imagen();
                imagen.SetRuta(reader.GetString(2));
                imagen.SetDescripcion(reader.GetString(7));
                actividad.AgregarImagen(imagen);

                imagen = new Imagen();
                imagen.SetRuta(reader.GetString(3));
                imagen.SetDescripcion(reader.GetString(8));
                actividad.AgregarImagen(imagen);

                imagen = new Imagen();
                imagen.SetRuta(reader.GetString(4));
                imagen.SetDescripcion(reader.GetString(9));
                actividad.AgregarImagen(imagen);

                imagen = new Imagen();
                imagen.SetRuta(reader.GetString(5));
                imagen.SetDescripcion(reader.GetString(10));
                actividad.AgregarImagen(imagen);                
            }
            return actividad;
        }


    }
}
