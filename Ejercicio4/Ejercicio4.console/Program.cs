using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese palabra nro 1");
            string palabra1 = Console.ReadLine();

            Console.WriteLine("Ingrese palabra nro 2");
            string palabra2 = Console.ReadLine();

            if (palabra1.Length != palabra2.Length)
            {
                Console.WriteLine("No es un anagrama");
            }
            else
            {
                char[] Caracteres1 = palabra1.ToCharArray();
                char[] Caracteres2 = palabra2.ToCharArray();

                Array.Sort(Caracteres2);
                Array.Sort(Caracteres1);

                if (Caracteres2.SequenceEqual(Caracteres1))
                {
                    Console.WriteLine("Es un anagrama");
                }
                else
                {
                    Console.WriteLine("No es un anagrama");
                }
              
            }


            Console.WriteLine("Pulse tecla para salir ...");
            Console.ReadLine();
        }
    }
}
