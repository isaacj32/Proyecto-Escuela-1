﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Proyecto_Escuela.Models;
using Proyecto_Escuela.Controllers;

namespace Proyecto_Escuela.Views
{
    public partial class SecuenciaImagenes : Form
    {
        #region Constantes
        public const int maxAnchuraDelGrid = 4;
        public const int maxAlturaDelGrid = 2;
        public const int anchoImagen = 140;
        public const int altoImagen = 120;
        public const int bordeEnGrid = 60;
        #endregion

        private smTile[] grid;
        private smTile[] encaje;
        private SecuenciaController tc;
        private string[] ordenCorrecto;
        private bool ansiado = false;
        private int intentos = 1;

        #region Empty constructor
        /// <summary>
        /// Empty constructor
        /// </summary>
        public SecuenciaImagenes(int numImagenes, Jugador nino, string[] rutaDeImagenes, string[] ordenCorrectoImagenes)
        {
            InitializeComponent();
            this.BackColor = Color.Chocolate;
            this.lblNombre.Text = nino.GetNombre() + " " + nino.GetApellido();
            int xSpot;
            int ySpot;
            int pp;
            string[] imagenes = rutaDeImagenes;
            ordenCorrecto = ordenCorrectoImagenes;
            Random rnd = new Random();
            bool[] imgUsada = new bool[numImagenes];
            // Initialize the grid
            grid = new smTile[numImagenes];

            // Initialize each tile in the grid
            for (int row = 0; row < numImagenes; row++)
            {
                try
                {
                    pp = rnd.Next() % numImagenes;
                    while (imgUsada[pp])
                    {
                        pp = rnd.Next() % numImagenes;
                    }

                    // Create the tile
                    grid[row] = new smTile(imagenes[pp]);
                    grid[row].PutItem(grid[row].FilledImage);
                    imgUsada[pp] = true;

                    // Set the location for the tile
                    if (row < 4)
                    {
                        xSpot = (row * anchoImagen) + bordeEnGrid;
                        ySpot = bordeEnGrid;
                        grid[row].Location = new Point(xSpot, ySpot);
                    }
                    else
                    {
                        xSpot = ((row - 4) * anchoImagen) + bordeEnGrid;
                        ySpot = altoImagen + bordeEnGrid + 30;
                        grid[row].Location = new Point(xSpot, ySpot);
                    }

                    // Add the tile to the form
                    this.Controls.Add(grid[row]);


                }
                catch
                {
                    // Just catch an exception, no error handling yet
                    Console.WriteLine("Exception caught for tile[{0}]", row);
                }
            }

            encaje = new smTile[numImagenes];

            for (int i = 0; i < numImagenes; i++)
            {
                try
                {
                    encaje[i] = new smTile();
                    // Set the location for the tile
                    if (i < 4)
                    {
                        xSpot = (i * anchoImagen) + bordeEnGrid;
                        ySpot = 3 * altoImagen;
                        encaje[i].Location = new Point(xSpot, ySpot);
                    }
                    else
                    {
                        xSpot = ((i - 4) * anchoImagen) + bordeEnGrid;
                        ySpot = 4 * altoImagen + bordeEnGrid;
                        encaje[i].Location = new Point(xSpot, ySpot);
                    }
                    this.Controls.Add(encaje[i]);
                }
                catch
                {
                    Console.WriteLine("Error en: {0}", i);
                }
            }
        }
        #endregion

        private void SecuenciaImagenes_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnComprobacion_Click(object sender, EventArgs e)
        {

            tc = new SecuenciaController();
            ansiado = tc.Comprobar(encaje, ordenCorrecto);
            if (ansiado)
            {
                MessageBox.Show("Felicidades :D","Felicitaciones");

            }
            else
            {
                intentos++;
                MessageBox.Show("Sigue intentando, vas para el intento #" + intentos,"Felicitaciones");
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Buen día querido jugador/a, para jugar debes arrastrar las imágenes\ny colocarlas en el orden correcto, buena suerte.");
        }
    }
}