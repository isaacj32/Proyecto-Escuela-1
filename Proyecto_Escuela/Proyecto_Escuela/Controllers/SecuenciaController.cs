using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Escuela.Models;
using System.Drawing;

namespace Proyecto_Escuela.Controllers
{
    class SecuenciaController
    {
        public bool Comprobar(smTile[] encaje, string[] orden)
        {
            try
            {
                smTile[] comprobanding = new smTile[encaje.Length];
                for (int yes = 0; yes < encaje.Length; yes++)
                {
                    comprobanding[yes] = new smTile(orden[yes]);
                    if (!(compare(encaje[yes].FilledImage, comprobanding[yes].FilledImage)))
                    {
                        return false;
                    }
                }
                return true;
            }
            catch
            {
                Console.WriteLine("Obveo que falló papuh e,e");
                return false;
            }
        }

        private bool compare(Bitmap bmp1, Bitmap bmp2)
        {
            bool equals = true;
            bool flag = true;  //Inner loop isn't broken

            //Test to see if we have the same size of image
            if (bmp1.Size == bmp2.Size)
            {
                for (int x = 0; x < bmp1.Width; ++x)
                {
                    for (int y = 0; y < bmp1.Height; ++y)
                    {
                        if (bmp1.GetPixel(x, y) != bmp2.GetPixel(x, y))
                        {
                            equals = false;
                            flag = false;
                            break;
                        }
                    }
                    if (!flag)
                    {
                        break;
                    }
                }
            }
            else
            {
                equals = false;
            }
            return equals;
        }
    }
}