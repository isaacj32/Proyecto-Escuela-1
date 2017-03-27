﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Proyecto_Escuela.Models
{
    public class Estudiante
    {
        protected int documento { get; set; }
        protected string nombre { get; set; }
        protected string apellidos { get; set; }
        protected int grupo { get; set; }
        protected string grado { get; set; }
        protected string foto { get; set; }


        public Estudiante()
        {
        }

        public Estudiante(string nombre, string apellido, int grupo, int documento, string grado, string foto)
        {
            this.nombre = nombre;
            this.apellidos = apellido;
            this.grupo = grupo;
            this.documento = documento;
            this.grado = grado;
            this.foto = foto;
        }

        #region Getters y Setters
        public string GetNombre()
        {
            return nombre;
        }
        public string GetApellido()
        {
            return apellidos;
        }
        public int GetGrupo()
        {
            return grupo;
        }
        public int GetDocumento()
        {
            return documento;
        }
        public string GetGrado()
        {
            return grado;
        }
        public string GetFoto()
        {
            return foto;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void SetApellido(string apellido)
        {
            this.apellidos = apellido;
        }
        public void SetGrupo(string grupo)
        {
            if (!string.IsNullOrEmpty(grupo))
            {
                this.grupo = int.Parse(grupo);
            }
        }
        public void SetDocumento(string documento)
        {
            if (!string.IsNullOrEmpty(documento))
            {
                this.documento = int.Parse(documento);
            }
           
        }
        public void SetGrado(string grado)
        {
            this.grado = grado;
        }
        public void SetFoto(string foto)
        {
            this.foto = foto;
        } 
        #endregion

    }
}
