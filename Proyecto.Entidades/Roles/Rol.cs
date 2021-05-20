using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Entidades.Rol
{
    public class Rol
    {
        public int idrol { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "El nombre Usuario debe tener un Máximo de 100 o Mínimo 10 carácteres.")]
        public string nombre { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 25, ErrorMessage = "La descripción Máximo de carácteres 100 o Mínimo 25.")]
        public string descripcion;
        public bool condicion { get; set; }
    }
}
