using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRepuestos.library.Objetos
{
   public class VentasRepuestos
    {
        private string _nombreComercio;
        private string _direccion;
        private List<Repuesto> _listaProductos;


        public VentasRepuestos()
        {

        }

        public VentasRepuestos(string NombreComercio, string Direccion, List<Repuesto> ListaProductos)
        {
            _nombreComercio = NombreComercio;
            _direccion = Direccion;
            _listaProductos = ListaProductos;
        }

        public void AgregaRepuesto(Repuesto x)
        {
            _listaProductos.Add(x);
        }

        public void QuitarRepuesto(Repuesto x)
        {
            _listaProductos.Remove(x);
        }

        public void ModificarPrecio(int codigoProducto, double y)
        {
            _listaProductos.Find(x => x.Codigo == codigoProducto).Precio = y;
        }
        public void AgregarStock(int codigoProducto, int Cantidad)
        {
            _listaProductos.Find(x => x.Codigo == codigoProducto).Stock = _listaProductos.Find(x => x.Codigo == codigoProducto).Stock + Cantidad;
        }


        public void QuitarStock(int codigoProducto, int Cantidad)
        {
            _listaProductos.Find(x => x.Codigo == codigoProducto).Stock = _listaProductos.Find(x => x.Codigo == codigoProducto).Stock - Cantidad;
        }


        public List<Repuesto> TraerCategoria(int codigoCategoria)
        {
            List<Repuesto> porCategoria = _listaProductos.FindAll(x => x.Categoria.codigo == codigoCategoria);

            return porCategoria;
        }
    }
}
