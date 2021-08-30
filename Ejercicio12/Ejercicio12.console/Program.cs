using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12.console
{
    class Program
    {
        static void Main(string[] args)
        {

            string FechaActual = DateTime.Now.ToString("dd-MM-yyyy");
            string FechaIngresada;
            bool flag;

            do
            {
                Console.WriteLine("Ingrese fecha en formato {0}.", FechaActual);
                FechaIngresada = Console.ReadLine();
                flag = VerificaFecha(FechaIngresada);

            } while (!flag);

            decimal Diferencia = Convert.ToInt32((Convert.ToDateTime(FechaActual) - Convert.ToDateTime(FechaIngresada)).Days);

            decimal years = Math.Floor(Diferencia / 365);

            decimal meses = Math.Floor((Diferencia % 365) / 31);

            decimal dias = ((Diferencia % 365) % 31);

            Console.WriteLine(years);
            Console.WriteLine(meses);
            Console.WriteLine(dias);

            Console.WriteLine("Hay una diferencia de {0} años, {1} meses y {2} días.", years, meses, dias);
            
            
            

            Console.WriteLine("Pulse una tecla para salir...");
            Console.ReadLine();
        }

        static bool VerificaFecha(string FechaIngresada)
        {
            if (DateTime.TryParse(FechaIngresada, out DateTime Salida))
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
