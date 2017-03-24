using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Escuela.Models
{
    public class Estudiante
    {
        string nombre { get; set; }
        string apellidos { get; set; }
        int grupo { get; set; }
        int documento { get; set; }

        public Estudiante()
        {
        }

        public Estudiante(string nombre, string apellido, int grupo, int documento)
        {
            this.nombre = nombre;
            this.apellidos = apellido;
            this.grupo = grupo;
            this.documento = documento;
        }
    }
}
