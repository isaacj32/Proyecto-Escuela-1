using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Escuela.Models
{
    public class Estudiante
    {
        private string nombre { get; set; }
        private string apellidos { get; set; }
        private int grupo { get; set; }
        private int documento { get; set; }

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

        public string GetNombre()
        {
            return nombre;
        }
        public string GetApellido()
        {
            return apellidos;
        }
        public int GetGrupo()
        {
            return grupo;
        }
        public int GetDocumento()
        {
            return documento;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void SetApellido(string apellido)
        {
            this.apellidos = apellido;
        }
        public void SetGrupo(string grupo)
        {
            if (!grupo.Equals(""))
            {
                this.grupo = int.Parse(grupo);
            }
           
        }
        public void SetDocumento(string documento)
        {
            if (!documento.Equals(""))
            {
                this.documento = int.Parse(documento);
            }
           
        }

    }
}
