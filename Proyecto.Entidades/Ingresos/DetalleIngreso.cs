using Proyecto.Entidades.Almacen;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Entidades.Ingresos
{
    public class DetalleIngreso
    {
        public int idDetalleingreso { get; set; }

        public int Cantidaddetalleingreso { get; set; }
        
        public decimal Preciodetalleingreso { get; set; }
        

        List<Ingreso> Ingresos { get; set; }
    
        List<Articulo> Articulos { get; set; }
        }
}
