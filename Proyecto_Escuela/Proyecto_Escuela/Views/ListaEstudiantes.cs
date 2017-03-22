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
    public partial class ListaEstudiantes : Form
    {
        public ListaEstudiantes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Texto texto = new Texto();
            texto.setImagen(Properties.Resources.buho);
            texto.setTitulo("Prueba");
            ListaTextosController listaTexto = new ListaTextosController(texto);
            this.Dispose();
        }
    }
}
