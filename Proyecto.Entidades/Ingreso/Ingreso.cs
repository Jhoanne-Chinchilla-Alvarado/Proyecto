using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Entidades.Ingreso
{
    public class Ingreso
    {
        public int idingreso { get; set; }

        public string tipocomprobante { get; set; }
        public string seriecomprobante { get; set; }
        public string numerocomprobante { get; set; }
        public DateTime fechaHora { get; set; }
        public decimal impuesto { get; set; }
        public string estado { get; set; }
    }
}
