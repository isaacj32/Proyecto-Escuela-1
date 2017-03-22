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
        Estudiante limpio = new Estudiante();
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
            if (string.IsNullOrEmpty(documento.Text))
            {
                estudianteController.Buscar(estudiante, tabla, 0);
            }
            else
            {
                estudianteController.Buscar(estudiante, tabla, 1);
            }
        }

        private void guardar_Click(object sender, EventArgs e)
        {            
            estudiante.SetApellido(apellido.Text);
            estudiante.SetNombre(nombre.Text);
            estudiante.SetDocumento(documento.Text);
            estudiante.SetGrupo(grupo.Text);
            estudiante.SetGrado(grado.SelectedItem.ToString());

            if (documento.ReadOnly == false)
            {
                if (estudianteController.Agregar(estudiante) != 0)
                {
                    nombre.Clear();
                    apellido.Clear();
                    documento.Clear();
                    grupo.Clear();
                    grado.SelectedIndex = 0;                   
                    Listar(limpio);
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
                    grado.SelectedIndex = 0;
                    Listar(limpio);
                    documento.ReadOnly = false;

                }
            }

           
        }

        private void ConfiguracionEstudiantes_Load(object sender, EventArgs e)
        {            
            Listar(estudiante);                    
        }

        private void Listar(Estudiante estudiante)
        {
            estudianteController.Listar(tabla);
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            try
            {
                estudiante = estudianteController.Seleccionar(tabla);
                documento.Text = estudiante.GetDocumento().ToString();
                nombre.Text = estudiante.GetNombre();
                apellido.Text = estudiante.GetApellido();
                grupo.Text = estudiante.GetGrupo().ToString();
                asignarGrado(estudiante.GetGrado());
                documento.ReadOnly = true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + " Debe seleccionar un registro.");
            }

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
                asignarGrado(estudiante.GetGrado());
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
                        grado.SelectedIndex = 0;

                        Listar(limpio);
                    }
                }
                else
                {
                    MessageBox.Show("Eliminacion cancelada");
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            nombre.Clear();
            apellido.Clear();
            documento.Clear();
            grupo.Clear();
            Listar(limpio);
            grado.SelectedIndex = 0;
            documento.ReadOnly = false;
        }

        private void asignarGrado(string grado)
        {
            switch (grado)
            {
                case "Primero":
                    this.grado.SelectedIndex = 1;
                    break;
                case "Segundo":
                    this.grado.SelectedIndex = 2;

                    break;
                case "Tercero":
                    this.grado.SelectedIndex = 3;
                    break;
            }
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            new Configuracion().Show();
            this.Dispose();
        }
    }
}
