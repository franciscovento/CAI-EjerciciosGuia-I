using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.library.Entidades
{
    public class Directivo:Empleado
    {
        public override string GetNombreCompleto()
        {
            return "Sr. Director " + _apellido;
        }
    }
}
