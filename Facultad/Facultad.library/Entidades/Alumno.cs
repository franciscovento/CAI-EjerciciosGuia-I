using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.library.Entidades
{
    public class Alumno:Persona
    {
        private int _codigo;

        public Alumno() {

        }

        public Alumno(int Codigo, string Nombre, string Apellido, DateTime FechaNac) : base(Nombre, Apellido, FechaNac)
        {
            _codigo = Codigo;
        }


        public int Codigo
        {
            get => _codigo;
            set => _codigo = value;
        }

        public override string GetCredencial()
        {
            return $"Código: {Codigo} - {Apellido}, {Nombre}";
        }

        public override string ToString()
        {
            return GetCredencial();
        }



        public override bool Equals(object obj)
        {
            if (obj == null || !(_codigo == ((Alumno)obj)._codigo))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override int GetHashCode()
        {
            return _codigo.GetHashCode();
        }

    }
}
