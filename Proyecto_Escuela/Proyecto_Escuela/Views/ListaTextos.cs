using Proyecto_Escuela.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Escuela.Controllers;

namespace Proyecto_Escuela.Views
{
    public partial class ListaTextos : Form
    {
        TextoController textoController = new TextoController();
        Texto texto = new Texto();
        
        public ListaTextos()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        //Getter para usar el DataGrid en el controller
        public DataGridView getLista()
        {
            return tabla;
        }

        //Características del DataGrid cuando carga la ventana
        private void ListaTextos_Load(object sender, EventArgs e)
        {
            Listar();
        }
        private void Listar()
        {
            textoController.Listar(tabla, 1);
        }

        //Evento para salir de la aplicación
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            texto = textoController.Seleccionar(tabla);
            new LecturaController(texto);
            this.Dispose();

        }

        private void volver_Click(object sender, EventArgs e)
        {
            ListaEstudianteController estudiantes = new ListaEstudianteController();
            this.Dispose();
        }
    }
}
