using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Entidades.Ventas
{
    public class Vent
    {
        public int idVent { get; set; }

        public int idUsuario { get; set; }
        public int idPersona { get; set; }
        public string seriecomprobante { get; set; }
        public string numerocomprobante { get; set; }
        public DateTime fechaHora { get; set; }

        public List<Venta> Ventas { get; set; }
    }
}
