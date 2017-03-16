using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Escuela.Models
{
    class Estudiante
    {
        //Atributos
        private string nombre;
        private string id;
        private string grupo;
        private string grado;
        private Image foto;

        #region Getters y Setters
        // Getters y Setters para los atributos
        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string getId()
        {
            return id;
        }

        public void setId(string id)
        {
            this.id = id;
        }

        public string getGrupo()
        {
            return grupo;
        }

        public void setGrupo(string grupo)
        {
            this.grupo = grupo;
        }

        public string getGrado()
        {
            return grado;
        }

        public void setGrado(string grado)
        {
            this.grado = grado;
        }

        public Image getFoto()
        {
            return foto;
        }

        public void setFoto(Image foto)
        {
            this.foto = foto;
        } 
        #endregion
    }
}
