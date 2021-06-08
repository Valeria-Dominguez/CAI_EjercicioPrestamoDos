using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPrestamo.Entidades
{
    public class Operador
    {
        List<Prestamo> _prestamos;
        double _comision;
        double _procentajeComision;

        public Operador()
        {
        }

        public List<Prestamo> Prestamos { get => _prestamos; set => _prestamos = value; }
        public double Comision { get => _comision; set => _comision = value; }
        public double ProcentajeComision { get => _procentajeComision; set => _procentajeComision = value; }
    }
}
