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
        int[] posicionPBx;
        int[] posicionPBy;

        public SecuenciaImagenes(int numImagenes)
        {
            InitializeComponent();
            //PictureBox[] pictureBox = new PictureBox[numImagenes];
            //Panel[] encajePB = new Panel[numImagenes];
            //Rectangle[] recPicBox = new Rectangle[numImagenes];
            //Rectangle[] recEncaje = new Rectangle[numImagenes];
            Random rnd = new Random();
            int alMargen = 50;

            string pathImg = "C:\\Users\\Alejo Castaño Rojas\\Desktop\\DEVELOPMENT\\C#\\JuegosProyectoEscuela\\JuegosProyectoEscuela\\Resources";
            string[] imagenes = Directory.GetFiles(pathImg, "*.jpg");

            //Visibilidad de los PictureBox
            pb1.Visible = false;
            pb2.Visible = false;
            pb3.Visible = false;
            pb4.Visible = false;
            pb5.Visible = false;
            pb6.Visible = false;
            pb7.Visible = false;
            pb8.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;

            //Deshabilitación de los PictureBox
            pb1.Enabled = false;
            pb2.Enabled = false;
            pb3.Enabled = false;
            pb4.Enabled = false;
            pb5.Enabled = false;
            pb6.Enabled = false;
            pb7.Enabled = false;
            pb8.Enabled = false;
            panel1.Enabled = false;
            panel2.Enabled = false;
            panel3.Enabled = false;
            panel4.Enabled = false;
            panel5.Enabled = false;
            panel6.Enabled = false;
            panel7.Enabled = false;
            panel8.Enabled = false;

            #region Visualizacion de imagenes
            for (int i = 1; i < numImagenes + 1; i++)
            {
                switch (i)
                {
                    case 1:
                        pb1.Visible = true;
                        pb1.Enabled = true;
                        panel1.Visible = true;
                        panel1.Enabled = true;
                        break;
                    case 2:
                        pb2.Visible = true;
                        pb2.Enabled = true;
                        panel2.Visible = true;
                        panel2.Enabled = true;
                        break;
                    case 3:
                        pb3.Visible = true;
                        pb3.Enabled = true;
                        panel3.Visible = true;
                        panel3.Enabled = true;
                        break;
                    case 4:
                        pb4.Visible = true;
                        pb4.Enabled = true;
                        panel4.Visible = true;
                        panel4.Enabled = true;
                        break;
                    case 5:
                        pb5.Visible = true;
                        pb5.Enabled = true;
                        panel5.Visible = true;
                        panel5.Enabled = true;
                        break;
                    case 6:
                        pb6.Visible = true;
                        pb6.Enabled = true;
                        panel6.Visible = true;
                        panel6.Enabled = true;
                        break;
                    case 7:
                        pb7.Visible = true;
                        pb7.Enabled = true;
                        panel7.Visible = true;
                        panel7.Enabled = true;
                        break;
                    case 8:
                        pb8.Visible = true;
                        pb8.Enabled = true;
                        panel8.Visible = true;
                        panel8.Enabled = true;
                        break;
                }
            }
            #endregion
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

        private void SecuenciaImagenes_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
