using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Escuela.Models
{
    public class Desempeño
    {
        private int aciertos=0;
        private int errores=0;
        private int intentos = 0;
        private string juego = "";

        public Desempeño()
        {
        }

        public Desempeño(int aciertos, int erroes)
        {
            this.aciertos = aciertos;
            this.errores = erroes;
        }

        public int GetAciertos()
        {
            return aciertos;
        }
        public int GetErrores()
        {
            return errores;
        }
        public void SumarAcierto(int i)
        {
            aciertos += i;
        }
        public void SumarError(int i)
        {
            errores += i;
        }
        public void SetDesempeño(int aciertos, int errores)
        {
            SumarAcierto(aciertos);
            SumarError(errores);
            intentos = errores + aciertos;
        }
        
        public void SetJuego(string juego)
        {
            this.juego = juego;
        }
    }
}
