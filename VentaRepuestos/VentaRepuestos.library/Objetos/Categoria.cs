using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRepuestos.library.Objetos
{
    public class Categoria
    {
        private int _codigo;
        private string _nombre;

       public Categoria()
        {

        }


        public Categoria (int Codigo, string Nombre)
        {
            _codigo = Codigo;
            _nombre = Nombre;
        }

      public int codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }


        public override string ToString()
        {
            return _nombre + " - código: " +_codigo;
        }
    }
}
