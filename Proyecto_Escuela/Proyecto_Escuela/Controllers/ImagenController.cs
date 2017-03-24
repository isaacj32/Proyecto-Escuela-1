using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;

namespace Proyecto_Escuela.Controllers
{
    public class ImagenController
    {
        public ImagenController()
        {
        }

        public static byte[] ConvertirImagenToBytes(Image imagen)
        {
            MemoryStream ms = new MemoryStream();
            imagen.Save(ms, ImageFormat.Png);
            byte[] bytes = ms.ToArray();
            Console.WriteLine(bytes[0].ToString());
            Console.WriteLine(bytes[1].ToString());
            Console.WriteLine(bytes[2].ToString());

            return bytes;

        }

        public static Bitmap ConvertirBytesToImagen(byte[] img)
        {
            MemoryStream stream;
            byte[] buffer = img;
            Bitmap imagen;
            stream = new MemoryStream(buffer);
            imagen = new Bitmap(stream);
            stream.Close();
            return imagen;

        
        }
    }
}
