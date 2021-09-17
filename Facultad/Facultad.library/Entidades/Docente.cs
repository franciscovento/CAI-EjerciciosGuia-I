using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.library.Entidades
{
     public class Docente:Empleado
    {

        public override string GetNombreCompleto()
        {
            return "Docente: " + _nombre;
        }

    }
}
