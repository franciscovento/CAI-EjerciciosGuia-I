using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Ejercicio6.console
{
    class Program
    {
        static void Main(string[] args)
        {

            bool flag = true;
            string numero1;
            string numero2;

            do
            {
                Console.WriteLine("Ingrese numero 1");
                numero1 = Console.ReadLine();
                flag = VerificarEntero(numero1, ref flag);

            } while (!flag);

            do
            {
                Console.WriteLine("Ingrese numero 2");
                numero2 = Console.ReadLine();
                flag = VerificarEntero(numero2, ref flag);

            } while (!flag);


            int resp = (Convert.ToInt32(numero1) + Convert.ToInt32(numero2)) * (Convert.ToInt32(numero1) - Convert.ToInt32(numero2));
            Console.WriteLine(resp);


            Console.WriteLine("Pulse una tecla para salir");
            Console.ReadLine();
        }

        private static bool VerificarEntero(string numero1, ref bool flag)
        {
            if (!Int32.TryParse(numero1, out int Salida))
            {
                flag = false;
                return flag;
            }
            else
            {
                flag = true;
                return flag;
            }
      
        }
    }
}
