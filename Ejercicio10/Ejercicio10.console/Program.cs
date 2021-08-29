using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10.console
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 2, 3, 4, 5, 6, 7, 8, 9, };

            int [] number = Array.FindAll(numbers, p => p > 5);

            int indice = Array.IndexOf(numbers, 3);

            Console.WriteLine(indice);

            Console.WriteLine("Pulse una tecla para salir...");
            Console.ReadLine();
        }
    }
}
