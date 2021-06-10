using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPrestamo.Entidades
{
    [DataContract]
    public class Prestamo
    {
        string _linea;
        double _tNA;
        int _plazo;
        double _monto;
        int _id;

        public Prestamo()
        {
        }

        public Prestamo(string linea, int plazo, double monto)
        {
            _linea = linea;
            _plazo = plazo;
            _monto = monto;
        }

        [DataMember(Name= "Linea")]
        public string Linea { get => _linea; set => _linea = value; }

        [DataMember(Name= "TNA")]
        public double TNA { get => _tNA; set => _tNA = value; }

        [DataMember(Name= "Plazo")]
        public int Plazo { get => _plazo; set => _plazo = value; }

        [DataMember(Name= "Monto")]
        public double Monto { get => _monto; set => _monto = value; }

        [DataMember(Name= "id")]
        public int id { get => _id; set => _id = value; }

        public double CuotaCapital { get=> this._monto/this._plazo; }

        public double CuotaInteres { get => this.CuotaCapital*(this.TNA/12/100); }

        [DataMember(Name= "Cuota")]
        public double Cuota { get => this.CuotaCapital+this.CuotaInteres; }

        public override string ToString()
        {
            return $"{this._id}) Capital: ARS {this._monto.ToString("0.00")}, Interés: ARS {(this.CuotaInteres * this._plazo).ToString("0.00")} - TNA {this._tNA}";
        }
    }
}
