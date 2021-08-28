using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8.console
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag;
            DateTime FechaI = DateTime.Now;
            DateTime FechaA = DateTime.Now;
            do
            {
                Console.WriteLine("Ingrese una fecha: MM/dd/AA");
                string FechaIngresada = Console.ReadLine();
                flag = ValidarFecha(FechaIngresada, ref FechaI);

            } while (!flag);

            Console.WriteLine("La diferencia de fechas es de " + Math.Abs((FechaI - FechaA).Days) + " días.");
            


            Console.WriteLine("Pulse una tecla para salir ...");
            Console.ReadLine();

        }

        static bool ValidarFecha(string Fecha, ref DateTime FechaI)
        {
            if (DateTime.TryParse(Fecha, out FechaI))
            {
                return true;
            }

            return false;
        }
    }
}
