using System;

namespace GitExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ServicioEstudiante.hola);

            IMenu menu = new MenuPrincipal();
            menu.ImprimirMenu();
        }
    }
}
