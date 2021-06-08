using EjercicioPrestamo.Datos;
using EjercicioPrestamo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPrestamo.Negocio
{
    public class PrestamoNegocio
    {
        TipoPrestamoMapper _tipoPrestamoMapper;
        PrestamoMapper _prestamoMapper;
        List<TipoPrestamo> _listaTiposPrestamos;
        Operador _operador;

        public PrestamoNegocio()
        {
            this._tipoPrestamoMapper = new TipoPrestamoMapper();
            this._prestamoMapper = new PrestamoMapper();
            this._listaTiposPrestamos = new List<TipoPrestamo>();
            this._operador = new Operador();
            this._operador.ProcentajeComision = 0.15;
        }

        public List<TipoPrestamo> TraerTiposPrestamo()
        {
            this._listaTiposPrestamos = this._tipoPrestamoMapper.TraerTodos();
            return this._listaTiposPrestamos;
        }

        public Operador Traer()
        {
            this._operador.Prestamos = this._prestamoMapper.TraerTodos();
            this._operador.Comision = CalcularComision();
            return this._operador;
        }

        private double CalcularComision()
        {
            double interesTotal = 0;
            foreach (Prestamo prestamo in this._operador.Prestamos)
            {
                interesTotal = interesTotal + prestamo.CuotaInteres * prestamo.Plazo;
            }
            return interesTotal * this._operador.ProcentajeComision;
        }

        public ResultadoTransaccion Agregar(Prestamo prestamo, TipoPrestamo tipoPrestamo)
        {
            return this._prestamoMapper.Agregar(prestamo, tipoPrestamo);
        }

    }
}
