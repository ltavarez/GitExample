using System;
using System.Collections.Generic;
using System.Text;

namespace GitExample
{
    public class MenuPrincipal : IMenu
    {

        public void ImprimirMenu()
        {

            try
            {
                ServicioInscripcion servicioInscripcion = new ServicioInscripcion();
                IMenu menu;
                Console.Clear();
                Console.WriteLine("1-Mantenimiento de materias\n2-Mantenimiento de estudiantes\n3-Inscripcion\n4-Salir");
                Console.Write("Seleccion una opcion: ");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        menu = new MenuMateria();
                        menu.ImprimirMenu();
                        break;
                    case 2:
                        menu = new MenuEstudiante();
                        menu.ImprimirMenu();
                        break;
                    case 3:
                        servicioInscripcion.Inscribir();
                        break;
                    case 4:
                        Console.WriteLine("Gracias por utilizar nuestro sistema");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Debe seleccionar una opcion valida");
                        Console.ReadKey();
                        ImprimirMenu();
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Debe seleccionar una opcion valida");
                Console.ReadKey();
                ImprimirMenu();
            }

           

        }


    }
}
