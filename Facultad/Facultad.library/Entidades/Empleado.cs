using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.library.Entidades
{
    public abstract class Empleado:Persona
    {
        private DateTime _fechaIngreso;
        private int _legajo;
        private Salario _ultimoSalario;
        private List<Salario> _salarios;


        public Empleado()
        {

        }

        public Empleado(string Nombre, string Apellido, DateTime FechaNac, DateTime FechaIngreso, int Legajo, Salario UltimoSalario, List<Salario> Salarios):base(Nombre, Apellido, FechaNac)
        {
            _fechaIngreso = FechaIngreso;
            _legajo = Legajo;
            _ultimoSalario = UltimoSalario;
            _salarios = Salarios;
        }

        public int Antiguedad
        {
            get => DateTime.Now.Year - _fechaIngreso.Year;
        }


        public DateTime FechaIngreso
        {
            get => _fechaIngreso;
            set => _fechaIngreso = value;
        }

        public DateTime FechaNacimiento
        {
            get => FechaNac;
        }

        public int Legajo
        {
            get => _legajo;
            set => _legajo = value;
        }

        public Salario UltimoSalario
        {
            get => _ultimoSalario;
            set => _ultimoSalario = value;
        }

        public List<Salario> Salario
        {
            get => _salarios;
            set => _salarios = value;
        }

        public override string GetCredencial()
        {
            return $"Legajo: {_legajo} - {GetNombreCompleto()} salario $ {_ultimoSalario.Bruto}";
        }

        public override string ToString()
        {
            return GetCredencial();
        }

        public override bool Equals(object obj)
        {
            if (_legajo == ((Empleado)obj)._legajo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return _legajo.GetHashCode();
        }
    }
}
