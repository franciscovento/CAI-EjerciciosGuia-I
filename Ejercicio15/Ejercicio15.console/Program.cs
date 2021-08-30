using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15.console
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag;
            string password;
            int contador = 0;
            do
            {

                Console.WriteLine("Ingrese la contrasena:");
                password = Console.ReadLine();
                flag = VerificarPass(password);
                contador++;
                if (!flag)
                {
                    Console.WriteLine("Acesso denegado");
                };

                if (contador == 3)
                {
                    Console.WriteLine("Clave Bloqueada");
                    flag = true;
                }
            } while (!flag);

            if (contador != 3)
            {
                Console.Write("Bienvenido " + password + ". ");
                Console.WriteLine("Pulse una tecla para salir...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Pulse una tecla para salir...");
                Console.ReadLine();
            }

        }

        static bool VerificarPass(string pass)
        {
            if (pass == "Francisco Vento")
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
