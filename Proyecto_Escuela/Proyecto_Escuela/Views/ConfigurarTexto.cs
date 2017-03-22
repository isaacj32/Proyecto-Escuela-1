using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Escuela.Models;
using Proyecto_Escuela.Controllers;
using MySql.Data.MySqlClient;

namespace Proyecto_Escuela.Views
{
    public partial class ConfigurarTexto : Form
    {
        private Texto texto = new Texto();
        private TextoController textoController = new TextoController();
        private bool modificacion = false;
            
        public ConfigurarTexto()
        {
            InitializeComponent();
        }

        private void ConfigurarTexto_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            textoController.Listar(tabla);
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            texto.setTitulo(titulo.Text);
            texto.setTiempo(int.Parse(tiempo.Text));
            texto.setTexto(cuento.Text);
            if (modificacion == false)
            {
                if (textoController.Agregar(texto) != 0)
                {
                    titulo.Clear();
                    tiempo.Clear();
                    cuento.Clear();
                    Listar();

                }
            }
            else
            {
                if (textoController.Editar(texto) != 0)
                {
                    titulo.Clear();
                    tiempo.Clear();
                    cuento.Clear();
                    Listar();
                    modificacion = false;
                }
            }
            


        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            new Configuracion().Show();
            this.Dispose();
        }

        private void tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            titulo.Clear();
            tiempo.Clear();
            cuento.Clear();
            texto = textoController.Seleccionar(tabla);
            cuento.Text = texto.getTexto();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            textoController.Buscar(titulo.Text, tabla);
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            try
            {
                texto = textoController.Seleccionar(tabla);
                titulo.Text = texto.getTitulo();
                titulo.Text = texto.getTitulo();
                tiempo.Text = texto.getTiempo().ToString();
                cuento.Text = texto.getTexto();
                modificacion = true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + " Debe seleccionar un registro.");
            }
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(titulo.Text))
            {
                texto = textoController.Seleccionar(tabla);
                titulo.Text = texto.getTitulo();
                tiempo.Text = texto.getTiempo().ToString();
                cuento.Text = texto.getTexto();


            }
            else
            {
                DialogResult confirmar = MessageBox.Show("Se eliminará el cuento: " + titulo.Text + " desea continuar?", "Alerta Eliminacion", MessageBoxButtons.YesNo);
                if (confirmar == DialogResult.Yes)
                {
                    if (textoController.Eliminar(titulo.Text) != 0)
                    {
                        titulo.Clear();
                        tiempo.Clear();
                        cuento.Clear();
                        Listar();
                    }
                }
                else
                {
                    MessageBox.Show("Eliminacion cancelada");
                }
            }
        }
    }
}
