using System;
using System.Collections.Generic;
using System.Text;

namespace GitExample
{
    public class ServicioEstudiante
    {

        public static string hola { get; set; } = "Hola";

        public void AgregarEstudiante()
        {
            Console.WriteLine("Ingrese el nombre del estudiante");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el apellido del  estudiante");
            string apellido = Console.ReadLine();

            Estudiante nuevaEstudiante = new Estudiante(nombre,apellido);

            Repositorio.Instancia.Estudiantes.Add(nuevaEstudiante);

            Console.WriteLine("Se agrego con exito");
            Console.ReadKey();
        }

        public void EditarEstudiante()
        {
            ListarEstudiante();

            Console.WriteLine("Seleccione el estudiante que desea editar");
            int indexEstudianteEditar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el nuevo nombre del estudiante");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el nuevo apellido del  estudiante");
            string apellido = Console.ReadLine();

            Repositorio.Instancia.Estudiantes[indexEstudianteEditar - 1].Nombre = nombre;
            Repositorio.Instancia.Estudiantes[indexEstudianteEditar - 1].Apellido = apellido;

            Console.WriteLine("Se edito con exito");
            Console.ReadKey();
        }

        public void BorrarEstudiante()
        {
            ListarEstudiante();

            Console.WriteLine("Seleccioneel estudiante que desea borrar");
            int indexEstudianteEliminar = Convert.ToInt32(Console.ReadLine());

            Repositorio.Instancia.Estudiantes.RemoveAt(indexEstudianteEliminar - 1);

            Console.WriteLine("Se elimino con exito");
            Console.ReadKey();
        }

        public void ListarEstudiante()
        {
            for (int i = 0; i < Repositorio.Instancia.Estudiantes.Count; i++)
            {
                Estudiante estudianteInterada = Repositorio.Instancia.Estudiantes[i];
                Console.WriteLine((i+1 + "- " + estudianteInterada.Nombre + " " + estudianteInterada.Apellido));
            }
        }

        public void ListarInscripciones()
        {
            int i = 1;
            int j = 1;

            foreach (Estudiante item in Repositorio.Instancia.Estudiantes)
            {
                j = 1;
                Console.WriteLine((i + "- " + item.Nombre + " " + item.Apellido));
              
                Console.WriteLine("Materias inscritas");

                foreach (Materia materia in item.MateriasInscrita)
                {
                    Console.WriteLine((j ) + "- " + materia.Nombre);
                    j++;
                }

                i++;
            }
            }
        

    }
}
