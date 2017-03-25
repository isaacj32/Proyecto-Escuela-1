using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Escuela.Models
{
    public class SecuenciaImagenModel
    {
        private string texto;
        private Imagen[] imagenes;
        private string[] secuenciaCorrecta;
        public SecuenciaImagenModel(string secuencia)
        {
            imagenes = new Imagen[8];
        }

        public string GetTitulo()
        {
            return texto;
        }
        public Imagen[] GetImagenes()
        {
            return imagenes;
        }
        public Imagen GetImagen(int i)
        {
            return imagenes[i];
        }
        public string GetSecuencia()
        {
            string cadena = secuenciaCorrecta[0];
            for (int i = 1; i < 8; i++) {
                cadena = cadena + secuenciaCorrecta[i];
            }
            return cadena;
        }
        public void SetSecuencia(string cadena)
        {
            string[] arreglo = new string[8];
            for(int i = 0; i< cadena.Length; i++)
            {
                arreglo[i] = cadena[0].ToString();
            }
        }
        public void SetTexto(string titulo)
        {
            this.texto = titulo;
        }
        public void SetImagen(Imagen imagen, int i)
        {
            this.imagenes[i] = imagen;
        }



    }
}
