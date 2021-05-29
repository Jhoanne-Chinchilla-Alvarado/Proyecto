using Proyecto.Entidades.Ventas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Entidades.DetalleVenta
{
    public class DetalleVenta
    {
        public int idDetalleVenta { get; set; }

        public int cantidadventas { get; set; }
        public decimal idventa { get; set; }
        
            
        List<DetalleVent> DetalleVentas { get; set; }
    }
}
