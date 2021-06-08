using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPrestamo.Entidades
{
    [DataContract]

    public class TipoPrestamo
    {
        string _linea;
        double _tNA;
        int _id;

        public TipoPrestamo()
        {
        }

        public TipoPrestamo(string linea, double tNA, int id)
        {
            _linea = linea;
            _tNA = tNA;
            _id = id;
        }

        [DataMember(Name= "linea")]
        public string Linea { get => _linea; set => _linea = value; }
        [DataMember(Name= "tna")]
        public double TNA { get => _tNA; set => _tNA = value; }
        [DataMember(Name= "id")]
        public int id { get => _id; set => _id = value; }

        public override string ToString()
        {
            return $"{this._linea} - TNA: {this._tNA}";
        }
    }
}
