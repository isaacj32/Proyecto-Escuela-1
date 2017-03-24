using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Proyecto_Escuela.Models
{
    public class Texto
    {
        //Atributos
        private string texto;
        private string titulo;
        private string imagen;
        private int tiempo = 5;

        public Texto()
        {

        }

        //Getters y Setters para los atributos
        public void setTexto(string texto)
        {
            this.texto = texto;
        }

        public string getTexto()
        {
            return texto;
        }

        public void setTitulo(string titulo)
        {
            this.titulo = titulo;
        }

        public string getTitulo()
        {
            return titulo;
        }

        public void setImagen(string imagen)
        {
            this.imagen = imagen;
        }

        public string getImage()
        {
            return imagen;
        }

        public int getTiempo()
        {
            return tiempo;
        }

        public void setTiempo(int tiempo)
        {
            this.tiempo = tiempo;
        }
    }
}
