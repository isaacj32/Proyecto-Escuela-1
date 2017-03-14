using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Escuela.Models
{
    public class DescribeImagenModel
    {
        private Image image;
        private string description;

        public DescribeImagenModel() { }

        public Image getImage()
        {
            return image;
        }

        public void setImage(Image image)
        {
            this.image = image;
        }

        public string getDescription()
        {
            return description;
        }

        public void setDescription(string description)
        {
            this.description = description;
        }
    }
}
