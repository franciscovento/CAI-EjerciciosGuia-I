using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.console
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag;
            decimal primerTermino = 0;
            decimal segundoTermino = 0;
            char tercerTermino = '+';
            string nombreOperacion = "";
            do
            {
                do
                {
                    Console.Write("\nIngrese el primer numero: ");
                    string numero1 = Console.ReadLine();
                    flag = VerificarDecimal(numero1, ref primerTermino);
                } while (!flag);

                do
                {
                    Console.Write("Ingrese el segundo numero: ");
                    string numero2 = Console.ReadLine();
                    flag = VerificarDecimal(numero2, ref segundoTermino);
                } while (!flag);

                do
                {
                    Console.WriteLine("Ingrese el número de operación o el símbolo: " + System.Environment.NewLine + "1. Suma (+)" + System.Environment.NewLine + "2. Resta (-)" + System.Environment.NewLine + "3. Multiplicación (*)" + System.Environment.NewLine + "4. División (/)");
                    string operacion = Console.ReadLine();
                    flag = VerificarOperacion(operacion, ref tercerTermino);

                } while (!flag);


                decimal respuesta = calculadora(primerTermino, segundoTermino, tercerTermino, ref nombreOperacion);

                Console.WriteLine("El resultado de la " + nombreOperacion + " entre " + primerTermino + " y " + segundoTermino + " es: " + respuesta);
                Console.WriteLine("Presiona escape para salir, cualquier otra tecla para realizar otra operación");

            } while (Console.ReadKey().Key != ConsoleKey.Escape);

        }

        static decimal calculadora(decimal a, decimal b, char operacion, ref string nombreOperacion)
        {
            decimal resultado;

            switch (operacion)
            {
                case '+':
                case '1':    
                    resultado = a + b; 
                    nombreOperacion = "suma";
                    break;
                case '-':
                case '2':
                    resultado = a - b;
                    nombreOperacion = "resta";
                    break;
                case '*':
                case '3': 
                   resultado = a * b;
                   nombreOperacion = "multiplicación";
                   break;
                case '/':
                case '4':
                    resultado = a / b;
                    nombreOperacion = "división";
                    break;
                default: resultado = 0; break;
            }


            return resultado;
        }

        static bool VerificarDecimal(string numero1, ref decimal primerTermino)
        {
            if (!Decimal.TryParse(numero1, out primerTermino))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static bool VerificarOperacion(string operacion, ref char tercerTermino)
        {
            if (!Char.TryParse(operacion, out tercerTermino))
            {
                return false;
            }
            else
            {
                if ((tercerTermino == '+' || tercerTermino == '-' || tercerTermino == '*' || tercerTermino == '/' || tercerTermino == '1' || tercerTermino == '2' || tercerTermino == '3' || tercerTermino == '4'))
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
}
