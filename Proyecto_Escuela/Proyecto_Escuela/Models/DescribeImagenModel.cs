using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Escuela.Models
{
    public class DescribeImagenModel
    {
        private List<Imagen> imagenes = new List<Imagen>();

        public DescribeImagenModel() { }

        #region Getters y Setters
        //Getters y Setters del modelo para el juego
        public List<Imagen> GetImagenes()
        {
            return imagenes;
        }
        public Imagen GetImagen(int i)
        {
            return imagenes[i];
        } 
        public void SetImagenes(List<Imagen> imagenes)
        {
            this.imagenes = imagenes;
        }
        public void SetImagen(Imagen imagen, int i)
        {
            this.imagenes[i] = imagen;
        }
        public void AgregarImagen(Imagen imagen)
        {
            this.imagenes.Add(imagen);
        }
        #endregion
    }
}
