using Proyecto_Escuela.Controllers;
using Proyecto_Escuela.Models;
using System;
using System.Windows.Forms;

namespace Proyecto_Escuela.Views
{
    public partial class Estadistica : Form
    {
        EstadisticaController estadisticaController = new EstadisticaController();
        Jugador jugador = new Jugador();

        public Estadistica()
        {
            InitializeComponent();            
        }

        private void comboEstadisticas_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboOpciones.Items.Clear();
            comboOpciones.Enabled = false;
            comboGrupos.Enabled = false;
            textBoxEstudiante.Enabled = false;
            labelEstudiante.Text = null;
            labelSeleccion.Text = null;

            if (comboEstadisticas.SelectedIndex == 0 || comboEstadisticas.SelectedIndex == 1)
            {
                labelSeleccion.Text = "Seleccione un grado";
                comboOpciones.Enabled = true;
                comboOpciones.Items.Add("Primero");
                comboOpciones.Items.Add("Segundo");
                comboOpciones.Items.Add("Tercero");
            }            
            else if (comboEstadisticas.SelectedIndex == 2)
            {
                labelSeleccion.Text = "Seleccione una actividad:";
                comboOpciones.Enabled = true;
                comboOpciones.Items.Add("Secuencia de mágenes");
                comboOpciones.Items.Add("Descripción de imágenes");
                comboOpciones.Items.Add("Apareamiento");
                comboOpciones.Items.Add("Colorear palabras");
                comboOpciones.Items.Add("Dictado");
                comboOpciones.Items.Add("Preguntas sobre el texto");
            }
            else if (comboEstadisticas.SelectedIndex == 3)
            {
                labelEstudiante.Text = "Ingrese el documento del estudiante:";
                textBoxEstudiante.Enabled = true;
            }
            comboOpciones.Text = null;
            comboGrupos.Text = null;
            comboGrupos.Items.Clear();
            textBoxEstudiante.Text = null;
            labelGrupos.Text = null;
        }

        private void comboOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboEstadisticas.SelectedIndex == 1 && comboOpciones.SelectedIndex == 0)
            {
                labelGrupos.Text = "Seleccione un grupo:";
                comboGrupos.Items.Add("tu puta madre");
                comboGrupos.Enabled = true;
            }
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            jugador.SetDocumento(textBoxEstudiante.Text);
            if (string.IsNullOrEmpty(textBoxEstudiante.Text))
            {
                estadisticaController.Buscar(jugador, tabla, 0);
            }
            else
            {
                estadisticaController.Buscar(jugador, tabla, 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            estadisticaController.CalcularEstadisticas(tabla);
        }
    }
}
