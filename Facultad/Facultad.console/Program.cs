using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facultad.library.Entidades;
using Facultad.library.Utilidades;

namespace Facultad.console
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                bool flag;
                string mensaje;
                int opcion = 0;
                do
                {
                    mensaje = "";
                    DesplegarMenu();
                    string x = Console.ReadLine();
                    flag = Validadores.ValidarOpcion(x, ref opcion, ref mensaje);
                    if (mensaje != "" )
                    {
                        Console.WriteLine(mensaje);
                    }
                } while (!flag);

                Console.WriteLine("Haz elegido la opción " + opcion);
                

               

               
                
                Console.WriteLine("Para salir presiona escape, cualquier otra para continuar");

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

           
        }


        static void DesplegarMenu()
        {
            Console.WriteLine("Ingresa la opción que deseas realizar: ");
            Console.WriteLine("1. Agregar Empleado" + System.Environment.NewLine + "2. Agregar Alumno" + System.Environment.NewLine + "3. Traer alumnos" + System.Environment.NewLine + "4. Traer empleados");
        }


    }
}
