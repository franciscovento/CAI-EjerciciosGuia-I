using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facultad.library.Entidades;
using Facultad.library.Utilidades;

namespace Facultad.console
{
    class Program
    {
        static void Main(string[] args)
        {
            //CARGA DE DATOS A LISTAS
            Alumno x = new Alumno(892789, "Francisco", "Vento", DateTime.Now);
            Alumno y = new Alumno(892788, "Gerardi", "Ventura", Convert.ToDateTime("16/01/1992"));


            Salario docente = new Salario(60000, "AR-2325", 12400, DateTime.Now);
            Salario bedel = new Salario(45000, "AR-2324", 11000, DateTime.Now);
            Salario directivo = new Salario(80000, "AR-1212", 10233, DateTime.Now);

            List<Salario> salario1 = new List<Salario>();

            Empleado a = new Docente();
            a.Nombre = "Roberto";
            a.Apellido = "Paredes";
            a.FechaIngreso = DateTime.Now;
            a.FechaNac = Convert.ToDateTime("16/01/1992");
            a.Legajo = 123456;
            a.UltimoSalario = docente;
            a.Salario = salario1;

            Bedel b = new Bedel();
            b.Nombre = "Juan";
            b.Apellido = "Piola";
            b.FechaIngreso = DateTime.Now;
            b.FechaNac = Convert.ToDateTime("16/01/1992");
            b.Legajo = 343434;
            b.UltimoSalario = bedel;
            b.Salario = salario1;
            b.Apodo = "Lagarto";

            Facu facultad = new Facu("FCE");
            facultad.AgregarAlumno(x);
            facultad.AgregarAlumno(y);
            facultad.AgregarEmpleado(a);
            facultad.AgregarEmpleado(b);
           
        

      
            bool continuarActivo = true;
            Console.WriteLine("Bienvenido a " + facultad.Nombre);
            do
            {
                DesplegarMenu(); //mostramos el menú
                //capturamos la seleccion
                string opcionSeleccionada = Console.ReadLine();
                // validamos si el input es válido (en este caso podemos tmb dejar que el switch se encargue en el default.
                // lo dejo igual por las dudas si quieren usar el default del switch para otra cosa.
                String[] opcionesValidas = new String[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "x" };

                if (Validadores.ValidarOpcion(opcionSeleccionada, opcionesValidas))
                {
                    if (opcionSeleccionada.ToUpper() == "X")
                    {
                        continuarActivo = false;
                        continue;
                    }
                    switch (opcionSeleccionada)
                    {
                        case "1":
                            // listar
                            ListarAlumnos(facultad);
                            break;
                        case "2":
                            // listar
                            ListarEmpleados(facultad);
                            break;
                        case "3":
                            // alta
                            Program.AgregarAlumno(facultad);
                            break;
                        case "4":
                            // modificar
                            Program.ModificarAlumno(facultad);
                            break;
                        case "5":
                            // borrar
                            Program.EliminarAlumno(facultad);
                            break;
                        case "6":
                            // alta
                            Program.AgregarEmpleado(facultad);
                            break;
                        case "7":
                            // modificar
                            Program.ModificarEmpleado(facultad);
                            break;
                        case "8":
                            // borrar
                            Program.EliminarEmpleado(facultad);
                            break;
                        case "9":
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("Opción inválida.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opción inválida.");
                }
                Console.WriteLine("Ingrese una tecla para continuar.");
                Console.ReadKey();
                Console.Clear();
            }
            while (continuarActivo);
            Console.WriteLine("Gracias por usar la app.");
            Console.ReadKey();
        }

        static void ListarAlumnos(Facu x)
        {
           List<Alumno> todoAlumnos = x.TraerAlumnos();

            foreach (Alumno alu in todoAlumnos)
            {
                Console.WriteLine(alu.ToString());
            }
        }

        static void ListarEmpleados(Facu x)
        {
            List<Empleado> todoEmpleados = x.TraerEmpleados();

            foreach (Empleado alu in todoEmpleados)
            {
                Console.WriteLine(alu.ToString());
            }
        }

        static void AgregarAlumno(Facu x)
        {
            bool flag;
            string nombre;
            string apellido;
            string fechaNac;
            string codigo;
            string msj = "";

            do
            {
                Console.WriteLine("Ingresar nombre de alumno:");
                nombre = Console.ReadLine();
                flag = Validadores.ValidarVacio(nombre);
            } while (!flag);

            do
            {
                Console.WriteLine("Ingresar apellido de alumno");
                apellido = Console.ReadLine();
                flag = Validadores.ValidarVacio(apellido);
            } while (!flag);

            do
            {
                Console.WriteLine("Ingresar fecha de nacimiento");
                fechaNac = Console.ReadLine();
                flag = Validadores.ValidarFecha(fechaNac);
            } while (!flag);

            do
            {
                Console.WriteLine("Ingresar código de alumno");
                codigo = Console.ReadLine();
                flag = Validadores.ValidarEnteroPositivo(codigo, ref msj);
                if (msj != "")
                {
                    Console.WriteLine(msj);
                }

            } while (!flag);

            Alumno nuevoalumno = new Alumno(Convert.ToInt32(codigo), nombre, apellido, Convert.ToDateTime(fechaNac));
            List<Alumno> listaAlumnos = x.TraerAlumnos();


            foreach (Alumno al in listaAlumnos)
            {
                if (al.Equals(nuevoalumno))
                {
                    flag = false;
                    break;
                }
                else
                {
                    flag = true;

                }

            }

            if (flag)
            {
                x.AgregarAlumno(nuevoalumno);
                Console.WriteLine("El alumno ha sido ingresado con éxito");
            }
            else {
                Console.WriteLine("No se ha podido agregar, el alumno ingresado ya existe");
            } 

        }

        static void ModificarAlumno(Facu x)
        {
            Console.WriteLine("Ingreso a modificar alumno");
        } 

        static void EliminarAlumno(Facu x)
        {
            bool flag;
            string codigo;
            string msj = "";
            do
            {
            Console.WriteLine("Ingresar código de alumno para eliminar");
            codigo = Console.ReadLine();
            flag = Validadores.ValidarEnteroPositivo(codigo, ref msj);
                if (msj != "")
                {
                    Console.WriteLine(msj);
                }
            } while (!flag);

            List<Alumno> al = x.TraerAlumnos();
            Alumno eliminar = al.Find(item => item.Codigo == Int32.Parse(codigo));
            if (eliminar == null)
            {
                Console.WriteLine("No se pudo eliminar, el codigo ingresado no existe en la lista");
            }else
            {
                x.EliminarAlumno(Int32.Parse(codigo));
                Console.WriteLine("Se eliminó con éxito el alumno con codigo {0}.", codigo);
            }
        }

        static void AgregarEmpleado(Facu x)
        {
            Console.WriteLine("Ingreso a agregar empleado");
        }

        static void ModificarEmpleado( Facu x)
        {
            Console.WriteLine("Ingreso a modificar empleado");
        }

        static void EliminarEmpleado(Facu x)
        {

            Console.WriteLine("Ingreso a eliminar empleado");
        }

        static void DesplegarMenu()
        {
            Console.WriteLine("1) Listar Alumnos " +
                 "\n2) Listar Empleados  " +
                 "\n3) Agregar alumno " +
                 "\n4) Modificar alumno " +
                 "\n5) Borrar alumno " +
                 "\n6) Agregar empleado " +
                 "\n7) Modificar empleado " +
                 "\n8)Eliminar empleado " +
                 "\n9)Limpiar consola " +
                 "\n10) Para salir presione X..."); 
        }

        

        
    }


}


     

    