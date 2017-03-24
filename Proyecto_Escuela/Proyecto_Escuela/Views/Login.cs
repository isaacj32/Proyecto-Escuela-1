using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Escuela.Views
{
    public partial class Login : Form
    {
        DAOS.ConexionDB conexion;
        Inicio inicio;
        public Login(Inicio inicio)
        {
            InitializeComponent();
            this.inicio = inicio;
        }

        private void log_Click(object sender, EventArgs e)
        {
            conexion = new DAOS.ConexionDB(usuario.Text, contraseña.Text);
            try
            {
                if(conexion.AbrirConexion() == true)
                {
                    conexion.CerrarConexion();
                    inicio.Dispose();
                    new Configuracion().Show();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("No se puede iniciar sesion, rectifique usuario y contraseña");
                }

            }
            catch
            {
                MessageBox.Show("Error al iniciar sesion");
            }
        }

        private void atras_Click(object sender, EventArgs e)
        {
            inicio.Enabled=true;
            this.Dispose();
        }
    }
}
