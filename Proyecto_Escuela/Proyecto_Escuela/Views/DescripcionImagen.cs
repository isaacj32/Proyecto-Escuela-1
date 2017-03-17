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

namespace Proyecto_Escuela.Views
{
    public partial class DescripcionImagen : Form
    {        
        public DescripcionImagen()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        #region Getters de elementos del form
        //Getters para los campos de respuesta e imagen
        public TextBox getRespuesta()
        {
            return respuesta;
        }

        public PictureBox getImagen()
        {
            return imagen;
        } 

        public Button getButton1()
        {
            return button1;
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
