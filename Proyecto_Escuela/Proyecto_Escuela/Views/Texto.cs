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
    public partial class Texto : Form
    {
        private int tiempo;

        public Texto()
        {
            InitializeComponent();
        }

        public Label getLabel3()
        {
            return label3;
        }

        public void setLabel3(string texto)
        {
            label3.Text=texto;
        }

        public Label getLabel4()
        {
            return label4;
        }

        public void setLabel4(string tiempo)
        {
            label4.Text = tiempo;
        }

        public RichTextBox getTextBox()
        {
            return richTextBox1;
        }

        public void setTextBox(string texto)
        {
            richTextBox1.Text = texto;
        }

        public Timer getTimer()
        {
            return timer1;
        }

        public void setTiempo(int tiempo)
        {
            this.tiempo = tiempo;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tiempo > 0)
            {
                tiempo = tiempo - 1;
                label4.Text = "Tiempo: " + tiempo;
            }
            else
            {
                timer1.Stop();
                //MessageBox.Show("Se agotó el tiempo" + "\n¿Desea aumentar el tiempo de lectura?", "",MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (MessageBox.Show("Se agotó el tiempo\n¿Desea aumentar el tiempo de lectura?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                     == DialogResult.Yes)
                {
                    tiempo = 30;
                    timer1.Start();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
