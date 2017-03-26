using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Escuela.Models
{
    public class SecuenciaImagenModel
    {
        private string titulo;
        private string[] secuencia = new string[8];
        public SecuenciaImagenModel()
        {            
        }

        public string GetTitulo()
        {
            return titulo;
        }
        public string[] GetSecuencia()
        {
            return secuencia;
        }
        public void SetSecuencia(string[] cadena)
        {
            secuencia = cadena;
        }
        public void SetTitulo(string titulo)
        {
            this.titulo = titulo;
        }
       
    }
}
