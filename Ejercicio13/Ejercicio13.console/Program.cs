using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13.console
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag;
            string num;
            do
            {
                Console.WriteLine("Ingrese un número");
                num = Console.ReadLine();
                flag = VerificarNumero(num);
            } while (!flag);

            

            Console.WriteLine( "El factorial de " + num + " es: " + Factorial(Convert.ToInt32(num)));


            Console.WriteLine("Pulsa una tecla para salir...");
            Console.ReadLine();

        }

        static long Factorial (long a)
        {
            if( a == 1)
            {
                return 1;
            }
            return a * Factorial(a - 1);
        }

        static bool VerificarNumero ( string n)
        {
            if (long.TryParse(n, out long Salida))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
