using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Entidades.Ingresos
{
    public class Ingreso
    {
        public int idingreso { get; set; }

        public int idusuario { get; set; }
        public string tipocomprobanteingreso { get; set; }
        public string seriecomprobanteingreso { get; set; }
        public string numerocomprobanteingreso { get; set; }
        public DateTime fechaHoraingreso { get; set; }
        public decimal impuestoingreso { get; set; }
        
        public List<Ingresos> Ingresos { get; set; }
    }
}
