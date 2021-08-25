using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio1.Validacion;


namespace Ejercicio1.console
{
    class Program
    {
        static void Main(string[] args)
        {

            bool flag;
            string registro;
            do
            {
                Console.WriteLine("Ingresa tu número de registro");
                registro = Console.ReadLine();
                flag = ValidarInt.ValidarINT(registro);
                
                Console.WriteLine(flag ? "Numero correcto" : "El dato debe ser un número y tener 6 digitos");

            } while (!flag);

            string word = registro.Substring(3,3);

            for (int i = 0; i <= Int32.Parse(word); i++)
            {
                if (i % 5 == 0 && i % 3 == 0 && i != 0)
                {
                    Console.WriteLine(i + " - FooBar");
                }
                else if (i % 3 == 0 && i != 0 )
                {
                    Console.WriteLine(i + " - Foo");
                }
                else if (i % 5 == 0 && i != 0)
                {
                    Console.WriteLine(i + " - Bar");
                }
                else
                {
                    Console.WriteLine(i);
                }
                
            }

           
            




            Console.WriteLine("Pulsa una tecla para salir");
            Console.ReadLine();
        }
    }
}
