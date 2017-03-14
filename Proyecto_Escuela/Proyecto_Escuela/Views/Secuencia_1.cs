using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Escuela
{
    public partial class Secuencia_1 : Form
    {
        public Secuencia_1()
        {
            InitializeComponent();
        }

        //Código que permite arrastrar la imagen a otro PictureBox
        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox5.DoDragDrop(pictureBox5.Image, DragDropEffects.Move);
        }

        private void pictureBox6_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox6.DoDragDrop(pictureBox6.Image, DragDropEffects.Move);
        }

        private void pictureBox7_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox7.DoDragDrop(pictureBox7.Image, DragDropEffects.Move);
        }

        private void pictureBox8_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox8.DoDragDrop(pictureBox8.Image, DragDropEffects.Move);
        }

        //Código que permite al PictureBox recibir la imagen
        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            pictureBox1.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pictureBox2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void pictureBox2_DragDrop(object sender, DragEventArgs e)
        {
            pictureBox2.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pictureBox3_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void pictureBox3_DragDrop(object sender, DragEventArgs e)
        {
            pictureBox3.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pictureBox4_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void pictureBox4_DragDrop(object sender, DragEventArgs e)
        {
            pictureBox4.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }

        private void Secuencia_1_Load(object sender, EventArgs e)
        {
            pictureBox1.AllowDrop = true;
            pictureBox2.AllowDrop = true;
            pictureBox3.AllowDrop = true;
            pictureBox4.AllowDrop = true;
        }        
    }
}
