using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRepuestos.library.Utilidades
{
    public class Validaciones
    {
        public static bool ValidarNumero(string x)
        {
            if (!Int32.TryParse(x, out int Salida))
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public static bool ValidarVacio(string x)
        {
            if (String.IsNullOrEmpty(x))
            {
                return false;
            }
            else
            {
                return true;
            }
        }


    }
}
