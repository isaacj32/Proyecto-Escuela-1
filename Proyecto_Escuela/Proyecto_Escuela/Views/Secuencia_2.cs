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
    public partial class Secuencia_2 : Form
    {
        public Secuencia_2()
        {
            InitializeComponent();
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox5.DoDragDrop(pictureBox5.Image, DragDropEffects.Move);
            pictureBox6.DoDragDrop(pictureBox6.Image, DragDropEffects.Move);
            pictureBox7.DoDragDrop(pictureBox7.Image, DragDropEffects.Move);
            pictureBox8.DoDragDrop(pictureBox8.Image, DragDropEffects.Move);
            pictureBox9.DoDragDrop(pictureBox9.Image, DragDropEffects.Move);
            pictureBox10.DoDragDrop(pictureBox10.Image, DragDropEffects.Move);
        }

        private void pictureBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void pictureBox_DragDrop(object sender, DragEventArgs e)
        {
            pictureBox1.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            pictureBox2.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            pictureBox3.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            pictureBox4.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            pictureBox11.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            pictureBox12.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }

        private void Secuencia_2_Load(object sender, EventArgs e)
        {
            pictureBox1.AllowDrop = true;
            pictureBox2.AllowDrop = true;
            pictureBox3.AllowDrop = true;
            pictureBox4.AllowDrop = true;
            pictureBox11.AllowDrop = true;
            pictureBox12.AllowDrop = true;
        }
    }
}
