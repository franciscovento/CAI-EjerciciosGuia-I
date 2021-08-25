using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cuatri2021.PrimeraClase.Validacion;

namespace Cuatri2021.PrimeraClase.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero.");
            string ingresoUsuario = Console.ReadLine();

            int numeroIngresado = int.Parse(ingresoUsuario);

            bool esValido = Validador.EsValido(numeroIngresado);

            Console.WriteLine(esValido ? "Es válido" : "No es válido");

            Console.WriteLine("Ingrese enter para salir");
            Console.ReadLine();
        }
    }
}
