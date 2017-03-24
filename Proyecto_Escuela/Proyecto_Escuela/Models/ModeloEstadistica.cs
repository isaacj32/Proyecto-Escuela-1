using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Escuela.Models
{
    class ModeloEstadistica
    {
        private double media;
        private double mediana;
        private double moda;

        public ModeloEstadistica() { }

        public ModeloEstadistica(double media, double mediana, double moda)
        {
            this.media = media;
            this.moda = moda;
            this.mediana = mediana;
        }
    }
}
