using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Entidades.Ventas
{
    public class Venta
    {
        public int idVenta { get; set; }

        public string tipocomprobanteventa { get; set; }
        public decimal impuesto { get; set; }
        public decimal total { get; set; }
        public bool condicionventa { get; set; }
    }
}
