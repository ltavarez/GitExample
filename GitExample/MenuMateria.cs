using System;
using System.Collections.Generic;
using System.Text;

namespace GitExample
{
    public class MenuMateria : IMenu
    {

        private ServicioMateria servicio { get; set; }


        public MenuMateria()
        {
            servicio = new ServicioMateria();
        }

        public void ImprimirMenu()
        {
            try
            {
                MenuPrincipal menu = new MenuPrincipal();

                Console.Clear();
                Console.WriteLine("1-Agregar materias\n2-Listar materias\n3-Editar materias\n4-Borrar materias\n5-Volver atras");
                Console.Write("Seleccione una de las opciones: ");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        servicio.AgregarMateria();
                        ImprimirMenu();
                        break;
                    case 2:
                        servicio.ListarMateria();
                        Console.ReadKey();
                        ImprimirMenu();
                        break;
                    case 3:
                       servicio.EditarMateria();
                        ImprimirMenu();
                        break;
                    case 4:
                        servicio.BorrarMateria();
                        ImprimirMenu();
                        break;
                    case 5:
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
