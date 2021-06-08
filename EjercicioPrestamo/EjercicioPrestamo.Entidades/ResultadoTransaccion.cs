
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPrestamo.Entidades
{
    [DataContract]
    public class ResultadoTransaccion
    {
        [DataMember]
        bool isOk { get; set; }
        [DataMember]
        string error { get; set; }
        [DataMember]
        int id { get; set; }

        public override string ToString()
        {
            if (isOk)
                return $"Operación exitosa. ID: {this.id}";
            else
                return $"La operación no pudo realizarse: {this.error}";
        }
    }
}
