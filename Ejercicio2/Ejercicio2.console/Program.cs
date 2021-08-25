using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.console
{
    class Program
    {
        static void Main(string[] args)
        {
            string nroRegistro;
            Console.WriteLine("Ingrese numero de registro");
            nroRegistro = Console.ReadLine();

            Console.WriteLine("1 - Es primo");
            int Limit = Int32.Parse(nroRegistro.Substring(3, 3));
            for (int i = 2; i <= Limit; i++)
            {
                bool IsPrime = true;
                bool Divisible3 = false;
                for (int j = 2; j <= i; j++)
                {
                    if (i % j == 0 && i != j)
                    {
                        if (i % 3 == 0)
                        {
                            Divisible3 = true;
                            IsPrime = false;
                            break;
                        }
                        else
                        {
                            Divisible3 = false;
                            IsPrime = false;
                            break;
                        }
                       
                    }
                    else
                    {
                        if (i % 3 == 0)
                        {
                            Divisible3 = true;
                            IsPrime = true;
                        }
                        else
                        {
                            Divisible3 = false;
                            IsPrime = true;
                        }
                        
                    }
                    
                }

                if (IsPrime)
                {
                    if (Divisible3)
                    {
                        Console.WriteLine(i + " - Es Primo y divisible por 3");
                    }
                    else
                    {
                        Console.WriteLine(i + " - Es Primo");
                    }
                   
                }
                else
                {
                    if (Divisible3)
                    {
                        Console.WriteLine(i + " - Es divisible por 3 ");
                    }
                    else
                    {
                        Console.WriteLine(i + " - No es primo");
                    }
                   
                }
                
            }





            Console.WriteLine("Ingrese una letra para salir ...");
            Console.ReadLine();
        }
    }
}
