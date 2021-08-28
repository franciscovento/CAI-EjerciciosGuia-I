using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9.console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese nombre de usuario: ");
            string nombre = Console.ReadLine();

            if (String.IsNullOrEmpty(nombre))
            {
                Console.WriteLine("No te conozco");
            } else
            {
                Console.WriteLine("Hola " + nombre + "!");
            }

            Console.WriteLine("Pulse una tecla para salir...");
            Console.ReadLine();
        }
    }
}
