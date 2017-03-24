using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Escuela.Models
{
    public class Relacion
    {
        private int izquierdo;
        private int derecho;

        public Relacion(int i, int d)
        {
            this.izquierdo = i;
            this.derecho = d;
        }

        public int GetIzquierdo()
        {
            return izquierdo;
        }
        public int GetDerecho()
        {
            return derecho;
        }


        public bool Comparar(Relacion relacion)
        {
            if (relacion.GetIzquierdo()==izquierdo)
            {
                if (relacion.GetDerecho() == derecho)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
