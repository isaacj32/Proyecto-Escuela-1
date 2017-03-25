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
        Jugador jugador;
        
        public ListaTextos(Jugador jugador)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.jugador = jugador;
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

       

        private void tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            texto = textoController.Seleccionar(tabla);
            new LecturaController(texto,jugador);
            this.Dispose();

        }

        private void volver_Click(object sender, EventArgs e)
        {
            ListaEstudianteController estudiantes = new ListaEstudianteController();
            this.Dispose();
        }
    }
}
