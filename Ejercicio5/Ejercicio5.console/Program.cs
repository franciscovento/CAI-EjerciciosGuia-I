using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5.console
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag;
            string numeroIngresado;
            do
            {
                
                Console.WriteLine("Ingresa un número de 5 cifras");
                numeroIngresado = Console.ReadLine();

                if (Int32.TryParse(numeroIngresado, out int Salida))
                {
                    if (numeroIngresado.Length != 5)
                    {
                        Console.WriteLine("El número debe tener 5 cifras");
                        flag = false;
                    }
                    else
                    {
                        flag = true;
                    }
                }
                else
                {
                    Console.WriteLine("Debes ingresar un dato numérico");
                    flag = false;
                }
            } while (!flag);

            char[] arrayNumero = numeroIngresado.ToCharArray();
            Array.Reverse(arrayNumero);
            string numeroInvertido = string.Join("",arrayNumero);
            Console.WriteLine("El numero invertido es " + numeroInvertido);



            Console.WriteLine("Pulsa una tecla para salir...");
            Console.ReadLine();
        }
    }
}
