using System;
using System.Collections.Generic;
using System.Text;

namespace GitExample
{
    public class ServicioInscripcion
    {

        private List<Materia> MateriasSeleccionadas { get; set; } = new List<Materia>();

        private bool ValidarExistenciaEstudiante()
        {
            if (Repositorio.Instancia.Estudiantes.Count <= 0)
            {
                return false;
            }

            return true;
        }

        private bool ValidarExistenciaMateria()
        {
            if (Repositorio.Instancia.Materias.Count <= 0)
            {
                return false;
            }

            return true;
        }

        public void Inscribir()
        {

            MenuPrincipal menu = new MenuPrincipal();
            ServicioEstudiante servicioEstudiante = new ServicioEstudiante();

            if (ValidarExistenciaEstudiante() == false)
            {
                Console.WriteLine("No hay estudiantes en el sistema");
                Console.ReadKey();
                menu.ImprimirMenu();
            }

            if (ValidarExistenciaMateria() == false)
            {
                Console.WriteLine("No hay materias en el sistema");
                Console.ReadKey();
                menu.ImprimirMenu();
            }

            servicioEstudiante.ListarEstudiante();

            Console.WriteLine("Seleccione al estudiante que desea inscribir");
            int indexInscripcion = Convert.ToInt32(Console.ReadLine());
            
            ProcesoDeInscripcion();

            Repositorio.Instancia.Estudiantes[indexInscripcion - 1].MateriasInscrita = MateriasSeleccionadas;

            Console.WriteLine("Se inscribio con exito");
            Console.ReadKey();

             menu.ImprimirMenu();
        }

        private void ProcesoDeInscripcion()
        {
            Console.Clear();
            ServicioMateria servicioMateria = new ServicioMateria();

            servicioMateria.ListarMateria();
            Console.WriteLine("Seleccione la materia a inscribir");
            int indexMateria = Convert.ToInt32(Console.ReadLine());

            Materia materiaSeleccionada = Repositorio.Instancia.Materias[indexMateria - 1];

            if (ValidarMateriaRepetida(materiaSeleccionada))
            {
                MateriasSeleccionadas.Add(materiaSeleccionada);

                Console.WriteLine("Desea aregar otra materia? S/N");
                string respuesta = Console.ReadLine();

                if (respuesta == "S")
                {
                    ProcesoDeInscripcion();
                }
            }
            else
            {
                Console.WriteLine("Usted ya selecciono esa materia");

                Console.WriteLine("Desea aregar otra materia? S/N");
                string respuesta = Console.ReadLine();

                if (respuesta == "S")
                {
                    ProcesoDeInscripcion();
                }
            }
        }

        private bool ValidarMateriaRepetida(Materia nuevaMateriaSeleccionada)
        {
            foreach (Materia item in MateriasSeleccionadas)
            {
                if (item.Nombre == nuevaMateriaSeleccionada.Nombre)
                {
                    return false;
                }
            }

            return true;
        }

    }
}
