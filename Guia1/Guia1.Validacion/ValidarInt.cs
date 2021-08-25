using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia1.Validacion
{
    public class ValidarInt
    {
        public static bool ValidarINT(string x)
        {
            
            if(!Int32.TryParse(x, out int Salida))
            {
                return false;
            }
            else
            {
                if (Salida.ToString().Length == 6)
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
