using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Entidades.DetalleVenta
{
    public class DetalleVenta
    {
        public int idDetalleventa { get; set; }

        public int cantidad { get; set; }
        public decimal precioDetalleventa { get; set; }
        public decimal descuento { get; set; }
    }
}
