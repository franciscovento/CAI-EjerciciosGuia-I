using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.library.Entidades
{
     public abstract class Persona
    {
        protected string _nombre;
        protected string _apellido;
        protected DateTime _fechaNac;
        

        public Persona()
        {

        }

        public Persona(string Nombre, string Apellido, DateTime FechaNac)
        {
            this._nombre = Nombre;
            this._apellido = Apellido;
            this._fechaNac = FechaNac;
        }

        public string Nombre
        {
            get => _nombre;
            set => _nombre = value;
        }
        public string Apellido
        {
            get => _apellido;
            set => _apellido = value;
        }

        public DateTime FechaNac
        {
            get => _fechaNac;
            set => _fechaNac = value;
        }

        public virtual string GetNombreCompleto() {
            return $"{_nombre} {_apellido}";
        }

        public abstract string GetCredencial();






    }

  
}
