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
        ListaEstudianteController listaEstudianteController;
        public ListaEstudiantes(ListaEstudianteController listaEstudianteController)
        {
            this.listaEstudianteController = listaEstudianteController;
            InitializeComponent();

        }      
        private void ListaEstudiantes_Load(object sender, EventArgs e)
        {
            Listar();
        }
        private void Listar()
        {
            listaEstudianteController.Listar(tablaPrimero);
        }

        private void tablaPrimero_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ListaTextosController ListaTextos = new ListaTextosController();
        }
    }
}
