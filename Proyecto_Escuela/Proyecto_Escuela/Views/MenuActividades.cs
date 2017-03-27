using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Escuela.Controllers;
using Proyecto_Escuela.Models;

namespace Proyecto_Escuela.Views
{
    public partial class MenuActividades : Form
    {
        DescribeImagenModel describeImagenModel = new DescribeImagenModel();
        Jugador jugador;
        public MenuActividades(string titulo, Jugador jugador)
        {
            InitializeComponent();
            tituloLabel.Text = titulo;
            this.jugador = jugador;
        }

        //Getter y Setter de los componentes para su utilización
        public Label getLabel1()
        {
            return tituloLabel;
        }

        public void setLabel1(string titulo)
        {
            tituloLabel.Text = titulo; 
        }

        private void MenuActividades_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        public void JuegoTerminado(int i)
        {
            switch (i)
            {
                case 1:
                    describe.Enabled = false;
                    describe.ForeColor = Color.Black;
                    break;
                case 2:                    
                    secuencia.Enabled = false;
                    secuencia.ForeColor = Color.Black;
                    break;               
            }
        }

        private void describe_Click(object sender, EventArgs e)
        {            
            new DescribeImagenController(this,jugador);
            this.Visible = false;
        }

        public string GetTitulo()
        {
            return tituloLabel.Text;
        }

        private void secuencia_Click(object sender, EventArgs e)
        {
            //new SecuenciaImagenController(6, tituloLabel.Text,);
            this.Visible = false;
        }
    }
}
