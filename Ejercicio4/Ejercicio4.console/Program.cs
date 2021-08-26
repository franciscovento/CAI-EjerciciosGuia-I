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

                int contador = 0;

                for (int i = 0; i < Caracteres1.Length; i++)
                {
                    
                    for (int j = 0; j < Caracteres2.Length; j++)
                    {
                        if (Caracteres1[i] == Caracteres2[j])
                        {
                            contador++;

                        }
                    }
                }


                if (contador == Caracteres1.Length)
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
