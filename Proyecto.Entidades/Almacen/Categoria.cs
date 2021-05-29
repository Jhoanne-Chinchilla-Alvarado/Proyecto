using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Proyecto.Entidades.Almacen
{
    public class Categoria
    {
        

        public int Idcategoria { get; set; }
        
        [Required]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "El nombre Categoria debe tener un Máximo de 100 o Mínimo 10 carácteres.")]
        public string Nombrecategoria { get; set; }
        
    }
}
