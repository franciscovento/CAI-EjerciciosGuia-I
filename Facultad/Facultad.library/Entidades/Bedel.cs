using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.library.Entidades
{
      public class Bedel : Empleado
    {
        protected string _apodo;

        public Bedel()
        {

        }

        public Bedel(string Apodo)
        {
            _apodo = Apodo;
        }

        public string Apodo
        {
            get => _apodo;
            set => _apodo = value;
        }

        public override string GetNombreCompleto()
        {
            return "Bedel " + _apodo; 
        }
    }
}
