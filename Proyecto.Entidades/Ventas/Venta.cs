using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Proyecto.Entidades.Ventas
{
    public class Venta
    {
        public int idventa { get; set; }

        public string tipocomprobante { get; set; }
        public string numerocomprobante { get; set; }
        public string seriecomprobante { get; set; }
        public DateTime fechaHora { get; set; }
        public decimal impuesto { get; set; }
        public decimal total { get; set; }
        [Required]
        [StringLength(70, MinimumLength = 25, ErrorMessage = "La descripción Máximo de carácteres 70 o Mínimo 25.")]
        public string descripcion;
    }
}
