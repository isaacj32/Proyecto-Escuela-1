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
        private string texto = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
            + "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
            + "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
            + "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
            + "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
            + "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
            + "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
        private string titulo = "Título quemado para efectos de ensayo";
        private Image imagen = Image.FromFile(@"C:\Users\Equipo\Source\Repos\Proyecto-Escuela\Proyecto_Escuela\Proyecto_Escuela\Resources\buho.png");
        private int tiempo = 5;


        #region Getters y Setters del modelo
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

        public void setImagen(Image imagen)
        {
            this.imagen = imagen;
        }

        public Image getImage()
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
        #endregion
    }
}
