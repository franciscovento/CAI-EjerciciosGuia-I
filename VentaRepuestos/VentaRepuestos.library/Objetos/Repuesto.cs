using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRepuestos.library.Objetos
{
    public class Repuesto
    {
        private int _codigo;
        private string _nombre;
        private double _precio;
        private int _stock;
        private Categoria _categoria;

        public Repuesto()
        {

        }

        public Repuesto(int Codigo, string Nombre, double Precio, int Stock, Categoria Categoria)
        {
            _codigo = Codigo;
            _nombre = Nombre;
            _precio = Precio;
            _stock = Stock;
            _categoria = Categoria;
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public int Codigo
        {
            get { return _codigo; }
            set
            {
                if (_codigo > 0) _codigo = value;
                else _codigo = 0;
            }
        }

        public double Precio
        {
            get
            { return _precio; }
            set
            { _precio = value; }
        }

        public int Stock
        {
            get
            { return _stock; }
            set
            { _stock = value; }
        }

        public Categoria Categoria
        {
            get
            { return _categoria; }

            set
            { _categoria = value; }
        }

       

        public override string ToString()
        {
            return

                "Codigo: "+ _codigo + " - Nombre: " + _nombre + " - Precio: " + _precio + " - Stock: " + _stock + " - Categoria: " + _categoria.ToString(); 


        }

    }
}
