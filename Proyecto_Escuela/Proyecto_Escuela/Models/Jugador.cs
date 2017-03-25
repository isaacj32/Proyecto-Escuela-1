using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Escuela.Models
{
    public class Jugador: Estudiante 
    {
        Desempeño[] desempeño = new Desempeño[2];
                
        public Jugador()
        {            
        }

        public Desempeño[] GetDesempeño()
        {
            return desempeño;
        }

        




    }
}
