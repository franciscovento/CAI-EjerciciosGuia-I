using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16.console
{
    class Program
    {
        static void Main(string[] args)
        {

            string num;
            bool flag;
            do
            {
                Console.WriteLine("Ingrese un número");
                num = Console.ReadLine();
                flag = ValidarNum(num);
            } while (!flag);

            Console.WriteLine("El numero ingresado: {0} - Tiene {1} digitos. ", num, num.Length);
            


            Console.WriteLine("Pulse una tecla para salir");
            Console.ReadLine();
        }

        static bool ValidarNum(string num)
        {
            if (Int32.TryParse(num, out int Salida))
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
