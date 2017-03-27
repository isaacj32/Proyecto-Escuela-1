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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void profesor_Click(object sender, EventArgs e)
        {
            new Login(this).Show();
            this.Enabled = false;
            
        }

        private void Estudiante_Click(object sender, EventArgs e)
        {
            ListaEstudianteController lista = new ListaEstudianteController(); 
            this.Dispose();
        }
    }
}
