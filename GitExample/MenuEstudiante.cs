using System;
using System.Collections.Generic;
using System.Text;

namespace GitExample
{
    public class MenuEstudiante : IMenu
    {
        private ServicioEstudiante servicio { get; set; }

        public MenuEstudiante()
        {
            servicio = new ServicioEstudiante();
        }


        public void ImprimirMenu()
        {
            try
            {
                MenuPrincipal menu = new MenuPrincipal();

                Console.Clear();
                Console.WriteLine("1-Agregar estudiantes\n2-Listar estudiantes\n3-Editar estudiantes\n4-Borrar estudiantes\n5-Listar inscripciones\n6-Volver atras");
                Console.Write("Seleccione una de las opciones: ");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        servicio.AgregarEstudiante();
                        ImprimirMenu();
                        break;
                    case 2:
                        servicio.ListarEstudiante();
                        Console.ReadKey();
                        ImprimirMenu();
                        break;
                    case 3:
                        servicio.EditarEstudiante();
                        ImprimirMenu();
                        break;
                    case 4:
                        servicio.BorrarEstudiante();
                        ImprimirMenu();
                        break;
                    case 5:
                        servicio.ListarInscripciones();
                        Console.ReadKey();
                        ImprimirMenu();
                        break;
                    case 6:
                        menu.ImprimirMenu();
                        break;
                    default:
                        Console.WriteLine("Debe colocar una opcion valida");
                        Console.ReadKey();
                        ImprimirMenu();
                        break;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Debe colocar una opcion valida");
                Console.ReadKey();
                ImprimirMenu();

            }

        }

    }
}
