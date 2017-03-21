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
using MySql.Data.MySqlClient;

namespace Proyecto_Escuela.Views
{
    public partial class ConfiguracionEstudiantes : Form
    {
        EstudianteController estudianteController = new EstudianteController();
        Estudiante estudiante = new Estudiante();
        public ConfiguracionEstudiantes()
        {
            InitializeComponent();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            estudiante.SetApellido(apellido.Text);
            estudiante.SetNombre(nombre.Text);
            estudiante.SetDocumento(documento.Text);
            estudiante.SetGrupo(grupo.Text);
            Listar(estudiante);
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            estudiante.SetApellido(apellido.Text);
            estudiante.SetNombre(nombre.Text);
            estudiante.SetDocumento(documento.Text);
            estudiante.SetGrupo(grupo.Text);

            if (documento.ReadOnly == false)
            {
                if (estudianteController.Agregar(estudiante) != 0)
                {
                    nombre.Clear();
                    apellido.Clear();
                    documento.Clear();
                    grupo.Clear();
                    Listar(estudiante);
                }
            }
            else
            {
                if (estudianteController.Editar(estudiante) != 0)
                {
                    nombre.Clear();
                    apellido.Clear();
                    documento.Clear();
                    grupo.Clear();
                    Listar(estudiante);
                }
            }

           
        }

        private void ConfiguracionEstudiantes_Load(object sender, EventArgs e)
        {
            try
            {                
                Listar(estudiante);
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Listar(Estudiante estudiante)
        {
           estudianteController.Buscar(estudiante, tabla);
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            estudiante = estudianteController.Seleccionar(tabla);
            documento.Text = estudiante.GetDocumento().ToString();
            nombre.Text = estudiante.GetNombre();
            apellido.Text = estudiante.GetApellido();
            grupo.Text = estudiante.GetGrupo().ToString();

        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(documento.Text))
            {
                estudiante = estudianteController.Seleccionar(tabla);
                documento.Text = estudiante.GetDocumento().ToString();
                nombre.Text = estudiante.GetNombre();
                apellido.Text = estudiante.GetApellido();
                grupo.Text = estudiante.GetGrupo().ToString();
            }
            else
            {
                DialogResult confirmar = MessageBox.Show("Se eliminará el estudiante con documento: " + documento.Text + " desea continuar?", "Alerta Eliminacion", MessageBoxButtons.YesNo);
                if(confirmar == DialogResult.Yes)
                {
                    if (estudianteController.Eliminar(int.Parse(documento.Text)) != 0)
                    {
                        nombre.Clear();
                        apellido.Clear();
                        documento.Clear();
                        grupo.Clear();
                        Listar(estudiante);
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
