using System;
using System.Collections.Generic;
using System.Text;

namespace GitExample
{
    public class ServicioMateria
    {
        public void AgregarMateria()
        {
            Console.WriteLine("Ingrese el nombre de la nueva materia");
            string nombreMateria = Console.ReadLine();

            Materia nuevaMateria = new Materia(nombreMateria);

            Repositorio.Instancia.Materias.Add(nuevaMateria);

            Console.WriteLine("Se agrego con exito");
            Console.ReadKey();
        }

        public void EditarMateria()
        {
            ListarMateria();

            Console.WriteLine("Seleccione la materia que desea editar");
            int indexMateriaEditar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el nuevo nombre de la materia");
            string nombreMateria = Console.ReadLine();

            Repositorio.Instancia.Materias[indexMateriaEditar - 1].Nombre = nombreMateria;

            Console.WriteLine("Se edito con exito");
            Console.ReadKey();
        }

        public void BorrarMateria()
        {
            ListarMateria();

            Console.WriteLine("Seleccione la materia que desea borrar");
            int indexMateriaEliminar = Convert.ToInt32(Console.ReadLine());

            Repositorio.Instancia.Materias.RemoveAt(indexMateriaEliminar -1);

            Console.WriteLine("Se elimino con exito");
            Console.ReadKey();
        }

        public void ListarMateria()
        {
            for (int i = 0; i < Repositorio.Instancia.Materias.Count; i++)
            {
                Materia materiaInterada = Repositorio.Instancia.Materias[i];
                Console.WriteLine((i+1 + "- " + materiaInterada.Nombre));
            }
        }

    }
}
