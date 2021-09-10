using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaRepuestos.library.Objetos;

namespace VentaRepuestos.console
{
    class Program
    {
        static void Main(string[] args)
        {

            Categoria primera = new Categoria(10, "Importadas");
            Categoria segunda = new Categoria(100, "Segunda");
            Repuesto A = new Repuesto(1, "Llantas", 25, 200, primera);
            Repuesto B = new Repuesto(1, "Puertas", 25, 200, primera);
            Repuesto C = new Repuesto(1, "Timones", 25, 200, segunda);
            Repuesto D = new Repuesto(1, "Perillas", 25, 200, segunda);
            Repuesto E = new Repuesto(1, "Bujias", 25, 200, primera);
            Repuesto F = new Repuesto(1, "Vidrios", 25, 200, segunda);


            List<Repuesto> Lista1 = new List<Repuesto>();
            VentasRepuestos tienda1 = new VentasRepuestos("Las vengas", "Otamendi 230", Lista1);

            tienda1.AgregaRepuesto(A);
            tienda1.AgregaRepuesto(B);
            tienda1.AgregaRepuesto(C);
            tienda1.AgregaRepuesto(D);
            tienda1.AgregaRepuesto(E);
            tienda1.AgregaRepuesto(F);

            tienda1.AgregarStock(1, 20);
            tienda1.ModificarPrecio(1, 31);
            foreach (var categoria in tienda1.TraerCategoria(10))
            {
                Console.WriteLine(categoria);
            }

            foreach (var categoria in tienda1.TraerCategoria(100))
            {
                Console.WriteLine(categoria);
            }


            Console.WriteLine(A.Stock);
            
          

           

            Console.WriteLine("Pulse una tecla para salir...");
            Console.ReadLine();
        }
    }
}
