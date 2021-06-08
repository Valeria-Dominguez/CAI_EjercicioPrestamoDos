using EjercicioPrestamo.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPrestamo.Datos
{
    public class TipoPrestamoMapper
    {
        static string rutaTipoPrestamo;


        public TipoPrestamoMapper()
        {
            rutaTipoPrestamo = ConfigurationManager.AppSettings["URL_TIPO_PRESTAMO"];
        }

        public List<TipoPrestamo> TraerTodos()
        {
            string json = WebHelper.Get(rutaTipoPrestamo);
            List<TipoPrestamo> resultado = MapList(json);
            return resultado;
        }

        private List<TipoPrestamo> MapList(string json)
        {
            List<TipoPrestamo> lista = JsonConvert.DeserializeObject<List<TipoPrestamo>>(json);
            return lista;
        }
    }
}
