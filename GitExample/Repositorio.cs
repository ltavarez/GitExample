using System;
using System.Collections.Generic;
using System.Text;

namespace GitExample
{
    public class Repositorio
    {
        public static Repositorio Instancia { get; } = new Repositorio();
        public List<Materia> Materias { get; set; } = new List<Materia>();
        public List<Estudiante> Estudiantes { get; set; } = new List<Estudiante>();

        private Repositorio()
        {

        }

    }
}
