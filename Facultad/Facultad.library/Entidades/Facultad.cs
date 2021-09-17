using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.library.Entidades
{
    public class Facultad
    {

        private List<Alumno> _alumnos;
        private int _cantidadSedes;
        private List<Empleado> _empleados;
        private string _nombre;


        public int CantidadSedes
        {
            get => _cantidadSedes;
            set => _cantidadSedes = value;
        }

        public string Nombre
        {
            get => _nombre;
            set => _nombre = value;
        }

        public List<Empleado> Empleados
        {
            set => _empleados = value;
        }

        public List<Alumno> Alumnos
        {
            set => _alumnos = value;
        }

        public void AgregarAlumno(int Codigo, string Nombre, string Apellido, DateTime FechaNac)
        {
            Alumno x = new Alumno(Codigo, Nombre, Apellido, FechaNac);
            _alumnos.Add(x);
        }

        public void AgregarAlumno( Alumno x)
        {
            _alumnos.Add(x);
        }

        public void EliminarAlumno( int codigo)
        {
            Alumno x = _alumnos.Find(alumno => alumno.Codigo == codigo);
            _alumnos.Remove(x);
        }

        public void AgregarEmpleado (Empleado x)
        {
            _empleados.Add(x);
        }

        public void EliminarEmpleado(int legajo)
        {
            Empleado x = _empleados.Find(empleado => empleado.Legajo == legajo);
            _empleados.Remove(x);
        }

        public List<Alumno> TraerAlumnos()
        {
            return _alumnos;
        }

        public List<Empleado> TraerEmpleados()
        {
            return _empleados;
        }

        public Empleado TraerEmpleadoPorLegajo(int legajo)
        {
            return _empleados.Find(x => x.Legajo == legajo);
        }

        public List<Empleado> TraerEmpleadosPorNombre(string nombre)
        {
            List<Empleado> x = _empleados.FindAll(emp => emp.Nombre == nombre);
            return x;
        }

    }
}
