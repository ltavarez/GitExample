using System;
using System.Collections.Generic;
using System.Text;

namespace GitExample
{
    public class Estudiante
    {

        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public List<Materia> MateriasInscrita { get; set; }

        public Estudiante(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

    }
}
