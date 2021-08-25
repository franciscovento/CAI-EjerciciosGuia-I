using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ejercicio3.console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una palabra");
            string UserInput = Console.ReadLine();
            char[] Reverse = UserInput.ToCharArray();
            Array.Reverse(Reverse);
            string ReverseInput = string.Join("", Reverse);

            if (String.Compare(UserInput, ReverseInput, CultureInfo.CurrentCulture, CompareOptions.IgnoreNonSpace) == 0)
            {
                Console.WriteLine("La palabra es un palíndromo");
            }
            else
            {
                Console.WriteLine("La palabra no es un palíndromo");
            }
         

            Console.WriteLine("Pulsa un tecla para salir");
            Console.ReadLine();
        }
    }
}
