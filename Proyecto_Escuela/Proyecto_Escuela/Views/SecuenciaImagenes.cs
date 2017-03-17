using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proyecto_Escuela.Views
{
    public partial class SecuenciaImagenes : Form
    {
        public SecuenciaImagenes(int numImagenes)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            PictureBox[] pictureBox = new PictureBox[numImagenes];
            Rectangle[] recPicBox = new Rectangle[numImagenes];
            string pathImg = "C:\\Users\\Alejo Castaño Rojas\\Desktop\\DEVELOPMENT\\C#\\JuegosProyectoEscuela\\JuegosProyectoEscuela\\Resources";
            string[] imagenes = Directory.GetFiles(pathImg, "*.jpg");
            for (int i = 0; i < numImagenes; i++)
            {
                //int pos = i;
                pictureBox[i] = new PictureBox();
                if (i < 4)
                {
                    pictureBox[i].Location = new System.Drawing.Point((i * 145) + 20, 56);
                }
                else
                {
                    pictureBox[i].Location = new System.Drawing.Point(((i - 4) * 145) + 20, 240);
                }
                pictureBox[i].Name = "pictureBox" + i;
                pictureBox[i].Size = new System.Drawing.Size(140, 120);
                pictureBox[i].TabIndex = i;
                pictureBox[i].TabStop = false;
                pictureBox[i].BackColor = Color.Transparent;
                pictureBox[i].Visible = true;
                pictureBox[i].BackgroundImage = Image.FromFile(imagenes[i]);
                pictureBox[i].BackgroundImageLayout = ImageLayout.Zoom;
                this.Controls.Add(pictureBox[i]);
                recPicBox[i] = new Rectangle();
                recPicBox[i].Size = pictureBox[i].Size;
                recPicBox[i].Location = pictureBox[i].Location;
                Mover(pictureBox[i]);
            }
        }

        public void Mover(PictureBox pb)
        {
            Point firstPoint = new Point();
            pb.MouseDown += (ss, ee) =>
            {
                if (ee.Button == MouseButtons.Left)
                {
                    firstPoint = MousePosition;
                }
            };

            pb.MouseMove += (ss, ee) =>
            {
                if (ee.Button == MouseButtons.Left)
                {
                    Point temp = MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);
                    pb.Location = new Point(pb.Location.X - res.X, pb.Location.Y - res.Y);
                    firstPoint = temp;
                }
            };

        }
    }
}
