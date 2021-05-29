using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Proyecto.Entidades.Ventas
{
    public class DetalleVent
    {
        public int idDetalleVent { get; set; }

        
        public decimal precioventas { get; set; }
        public decimal descuentoventas { get; set; }
        

        List<Persona> Personas { get; set; }

        List<Usuario> Usuarios { get; set; }
    }
}
