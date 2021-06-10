using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPrestamo.Entidades
{
    public class Operador
    {
        List<Prestamo> _prestamos;
        double _procentajeComision;
        static string porcComision;

        public Operador(List<Prestamo> prestamos, double porcentajeComision = 0)
        {
            porcComision = ConfigurationManager.AppSettings["PORC_COMISION"];
            if (porcentajeComision == 0 && porcComision != null)
            {
                this._procentajeComision = double.Parse(porcComision);
            }

            _prestamos = prestamos;
        }

        public List<Prestamo> Prestamos { get => _prestamos; set => _prestamos = value; }
        public double ProcentajeComision { get => _procentajeComision; set => _procentajeComision = value; }
        public double Comision { get => this._prestamos.Sum(d => d.Monto) * this._procentajeComision; }
    }
}
