using EjercicioPrestamo.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPrestamo.Datos
{
    public class PrestamoMapper
    {

        static string rutaPrestamo;
        static string registro;

        public object NameValueCollection { get; private set; }

        public PrestamoMapper()
        {
            rutaPrestamo = ConfigurationManager.AppSettings["URL_PRESTAMO"];
            registro = ConfigurationManager.AppSettings["REGISTRO"];
        }

        public List<Prestamo> TraerTodos()
        {
            string json = WebHelper.Get(rutaPrestamo+registro);
            List<Prestamo> resultado = MapList(json);
            return resultado;
        }

        private List<Prestamo> MapList(string json)
        {
            List<Prestamo> lista = JsonConvert.DeserializeObject<List<Prestamo>>(json);
            return lista;
        }

        public ResultadoTransaccion Agregar(Prestamo prestamo, TipoPrestamo tipoPrestamo)
        {
            NameValueCollection parametros = ReverseMap(prestamo, tipoPrestamo);
            string json = WebHelper.Post(rutaPrestamo, parametros);
            ResultadoTransaccion resultado = JsonConvert.DeserializeObject<ResultadoTransaccion>(json);
            return resultado;
        }

        private NameValueCollection ReverseMap(Prestamo prestamo, TipoPrestamo tipoPrestamo)
        {
            NameValueCollection n = new NameValueCollection();
            //n.Add("id", "0");
            n.Add("TNA", prestamo.TNA.ToString());
            n.Add("Linea", prestamo.Linea);
            n.Add("Plazo", prestamo.Plazo.ToString());
            n.Add("idCliente", "0");
            n.Add("idTipo", tipoPrestamo.id.ToString());
            n.Add("Monto", prestamo.Monto.ToString("0.00"));
            n.Add("Cuota", prestamo.Cuota.ToString("0.00"));
            n.Add("Usuario", registro);
            //n.Add("tna", "0");
            //n.Add("linea", "0");
            //n.Add("id", "0");
            return n;
        }
    }
}
