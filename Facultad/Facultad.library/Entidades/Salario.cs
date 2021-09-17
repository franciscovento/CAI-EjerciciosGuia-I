using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.library.Entidades
{
    public class Salario
    {
        private double _bruto;
        private string _codigoTransferencia;
        private double _descuentos;
        private DateTime _fecha;

        public Salario()
        {

        }
        public Salario(double Bruto, string CodigoTransfrencia, double Descuentos, DateTime Fecha)
        {
            _bruto = Bruto;
            _codigoTransferencia = CodigoTransfrencia;
            _descuentos = Descuentos;
            _fecha = Fecha;
        }

        public double Bruto
        {
            get => _bruto;
            set => _bruto = value;
        }

        public string CodigoTransferencia
        {
            get => _codigoTransferencia;
            set => _codigoTransferencia = value;
        }

        public double Descuentos
        {
            get => _descuentos;
            set => _descuentos = value;
        }

        public DateTime Fecha
        {
            get => _fecha;
            set => _fecha = value;
        }

        public double getSalarioNeto()
        {
            return _bruto - _descuentos;
        }

      



    }
}
