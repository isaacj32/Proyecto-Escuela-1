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
        private Image imagen;
        private string descripcion= "holi";

        public DescribeImagenModel() { }

        #region Getters y Setters
        //Getters y Setters del modelo para el juego
        public Image getImagen()
        {
            return imagen;
        }

        public void setImage(Image imagen)
        {
            this.imagen = imagen;
        }

        public string getDescripcion()
        {
            return descripcion;
        }

        public void setDescription(string descripcion)
        {
            this.descripcion = descripcion;
        } 
        #endregion
    }
}
