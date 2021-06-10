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

        public PrestamoNegocio()
        {
            this._tipoPrestamoMapper = new TipoPrestamoMapper();
            this._prestamoMapper = new PrestamoMapper();
            this._listaTiposPrestamos = new List<TipoPrestamo>();
        }

        public List<TipoPrestamo> TraerTiposPrestamo()
        {
            this._listaTiposPrestamos = this._tipoPrestamoMapper.TraerTodos();
            return this._listaTiposPrestamos;
        }

        public Operador Traer()
        {
            Operador operador = new Operador(this._prestamoMapper.TraerTodos());
            return operador;
        }

        public ResultadoTransaccion Agregar(Prestamo prestamo, TipoPrestamo tipoPrestamo)
        {
            return this._prestamoMapper.Agregar(prestamo, tipoPrestamo);
        }

    }
}
