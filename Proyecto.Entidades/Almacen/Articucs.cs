using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Proyecto.Entidades.Almacen
{
    public class Articu
    {
       
        public int Idarticu { get; set; }

        public decimal Precioarticulo { get; set; }
        public int Stock { get; set; }
    }
}
