using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Escuela.Models
{
    public class Jugador: Estudiante 
    {
        Desempeño desempeño;
                
        public Jugador()
        {
            desempeño = new Desempeño();
        }

        public Desempeño GetDesempeño()
        {
            return desempeño;
        }

        public void SetDesempeño(int aciertos, int errores)
        {
            this.desempeño = new Desempeño(aciertos, errores);
        }

        


    }
}
