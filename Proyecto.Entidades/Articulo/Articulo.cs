using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Proyecto.Entidades.Articulo
{
    public class Articulo
    {
        public int idarticulo { get; set; }
    
        [Required]
        [StringLength(50, ErrorMessage = "codigo sobrepasa Máximo permitido de 50 caracteres")]
        public string codigo { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "El nombre Usuario debe tener un Máximo de 100 o Mínimo 10 carácteres.")]
        public string nombre { get; set; }
        public decimal precio { get; set; }
        public int stock { get; set; }
        [Required]
        [StringLength(70, MinimumLength = 25, ErrorMessage = "La descripción Máximo de carácteres 70 o Mínimo 25.")]
        public string descripcion;
        public bool condicion { get; set; }

    }
}
