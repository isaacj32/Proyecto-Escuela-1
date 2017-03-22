using Proyecto_Escuela.Controllers;
using Proyecto_Escuela.Models;
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
    public partial class VistaLectura : Form
    {
        //Atrubuto tiempo, necesario para contar cuánto se demora el estudiante en leer el texto
        private int tiempo;
        private string titulo;
        private MenuActividadesController menuActividades;
        //Constructor
        public VistaLectura(string titulo)
        {
            InitializeComponent();
            this.titulo = titulo;
            tituloLabel.Text = titulo;

        }

        #region Getter y Setters
        //Getters y Seters para la modificación de los mismos
        public Label getLabel3()
        {
            return tituloLabel;
        }

        public void setLabel3(string texto)
        {
            tituloLabel.Text = texto;
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
        #endregion

        #region Método de Timer
        //Método que controla el tiempo de lectura del texto
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
                if (MessageBox.Show("¡Se agotó el tiempo!\n¿Deseas más tiempo para terminar la lectura?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    tiempo = 30;
                    timer1.Start();
                }
                else
                {
                    Application.Exit();
                    //this.Dispose();
                }
            }
        }
        #endregion

        private void jugar_Click(object sender, EventArgs e)
        {
            menuActividades = new MenuActividadesController(titulo);
            this.Dispose();
        }
    }
}
