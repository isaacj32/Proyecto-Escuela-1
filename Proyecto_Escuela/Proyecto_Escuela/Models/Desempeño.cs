using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Escuela.Models
{
    public class Desempeño
    {
        int aciertos=0;
        int errores=0;

        public int GetAciertos()
        {
            return aciertos;
        }
        public int GetErrores()
        {
            return errores;
        }
        public void SumarAcierto()
        {
            aciertos++;
        }
        public void SumarError()
        {
            errores++;
        }
    }
}
