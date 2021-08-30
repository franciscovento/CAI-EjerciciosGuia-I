using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10.console
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                string Mensaje;
                ConsoleKeyInfo cki;

                Console.WriteLine("Ingrese un caracter");
                cki = Console.ReadKey();
                char caracter = cki.KeyChar;

                Mensaje = VerificarTipo(Char.ToLower(caracter));

                Console.WriteLine(System.Environment.NewLine + Mensaje);
                Console.WriteLine("Presiona escape para salir cualquie otra tecla para continuar");

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

       
        }

        static string VerificarTipo(char caracter)
        {
            if (Int32.TryParse(Convert.ToString(caracter), out int Salida))
            {
                return "El caracter ingresado es de tipo número";
            }
            else if (caracter == 'a' || caracter == 'e' || caracter == 'i' || caracter == 'o' || caracter == 'u')
            {
                return "El caracter ingresado es un vocal";
            }
            else
            {
                return "El caracter ingresado es una constante";
            }
        }
    }
}
