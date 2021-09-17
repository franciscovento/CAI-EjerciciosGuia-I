using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.library.Utilidades
{
    public class Validadores
    {
        public static bool ValidarEnteroPositivo(string x)
        {
            if (!Int32.TryParse(x, out int Salida))
            {
                return false;
            }
            else if (Salida < 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public static bool ValidarDoublePositivo(string x)
        {
            if (!double.TryParse(x, out double Salida))
            {
                return false;
            }else if(Salida < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool ValidarFecha(string x)
        {
            if (!DateTime.TryParse(x, out DateTime Saluda))
            {
                return false;

            }
            else
            {
                return true;
            }
        }

        public static bool ValidarOpcion(string x, ref int option, ref string mensaje)
        {
            if (!ValidarEnteroPositivo(x))
            {
                mensaje += "Debes ingresar un numero" + System.Environment.NewLine;
                return false;
            }
            else if(Int32.Parse(x) > 0 && Int32.Parse(x) <= 3)
            {
                option = Int32.Parse(x);
               
                return true;
            }
            else
            {
                mensaje += "Número incorrecto, ingresa un número del menú";
                return false;
            }

        }


    }
}
