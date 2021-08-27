using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7.console
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];
            string variable;

            for (int i = 0; i < 5; i++)
            {
                bool flag;
                do
                {
                    Console.WriteLine("Ingrese el valor " + (i + 1) + ": ");
                    variable = Console.ReadLine();
                    flag = VerificarNumero(variable);
                    if (flag)
                    {
                      numeros[i] = Convert.ToInt32(variable);
                    }
                    
                } while (!flag);
                
            }

            int menor = numeros.Min();
            int mayor = numeros.Max();
            Array.Sort(numeros);

            Console.WriteLine("El numero del medio es " + numeros[2]);
            Console.WriteLine("El numero menor es " + menor + " y el mayor es " + mayor + ".");
            
            Console.WriteLine("Pulsa un tecla para salir...");
            Console.ReadLine();
         

        }

        private static bool VerificarNumero(string variable)
        {
            if (!Int32.TryParse(variable, out int Salida))
            {
                return false;
            }
            else
            {
               return true;
            }
           
        }
    }
}
