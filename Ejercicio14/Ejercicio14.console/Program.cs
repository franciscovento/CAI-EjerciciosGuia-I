using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14.console
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            bool flag;
            do
            {
                Console.WriteLine("Ingrese un número");
                string a = Console.ReadLine();
                flag = ValidarNumero(a, ref num);

            } while (!flag);

            Console.WriteLine("La tabla de multiplicar del {0} es: ", num);

            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("{0} x {1} = " + (num*(i+1)) , num, i +1);
            }


            Console.WriteLine("Pulsa una tecla para salir...");
            Console.ReadLine();

        }

        static bool ValidarNumero(string x, ref int num)
        {
            if (Int32.TryParse(x, out num))
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
