using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17.console
{
    class Program
    {
        static void Main(string[] args)
        {

            bool flag;
            string num;
            string name;

            int[] sueldos = new int[5];
            string[] nombres = new string[5];

            for (int i = 0; i < 5 ; i++)
            {
                do
                {
                    Console.Write("Ingrese nombre de empleado nro " + (i+1) +": " );
                    name = Console.ReadLine();
                    flag = VerificarNombre(name);
                } while (!flag);
                nombres[i] = name;
               
                do
                {
                    Console.Write("Ingrese sueldo de empleado nro " + (i+1) + ": ");
                    num = Console.ReadLine();
                    flag = VerificarNum(num);
                } while (!flag);
                sueldos[i] = Convert.ToInt32(num);
                Console.WriteLine("\n");
            }

            int SueldoMayor = sueldos.Max();
            int index = Array.FindIndex(sueldos, p => p == SueldoMayor);

            Console.WriteLine("La persona con más sueldo es {0} con un monto de {1} pesos.", nombres[index], SueldoMayor);

            Console.WriteLine("Pulsa una tecla para salir...");
            Console.ReadLine();

        }

        static bool VerificarNombre(string n)
        {
            if (String.IsNullOrEmpty(n))
            {
                return false;
            }
            else if(Int32.TryParse(n, out int Salida))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static bool VerificarNum (string n)
        {
            if (Int32.TryParse(n, out int Salida))
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
