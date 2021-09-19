using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.library.Utilidades
{
    public static class Validadores
    {
        public static bool ValidarEnteroPositivo(string x, ref string msj)
        {
            if (!Int32.TryParse(x, out int Salida))
            {
                msj = "Debes ingresar un número";
                return false;
            }
            else if (Salida < 0)
            {
                msj = "No puedes ingresar un numero menor a 0";
                return false;
            }
            else
            {
                msj = "";
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

        public static bool ValidarOpcion(string opcionSelecionada, Array opcionesValidas)
        {
            foreach(string value in opcionesValidas){
                if (value == opcionSelecionada)
                {
                    return true;
                }
            }

            return false;
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
